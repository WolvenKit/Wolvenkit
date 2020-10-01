﻿using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.GUI;
using IrrlichtLime.IO;
using IrrlichtLime.Scene;
using IrrlichtLime.Video;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Render
{
    public partial class frmLevelScene : DockContent
    {
        public static float Clamp(float value, float min, float max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        private void MatrixToEuler(CMatrix3x3 rm, out float rx, out float ry, out float rz)
        {
            float r11 = rm.ax.val;
            float r12 = rm.ay.val;
            float r13 = rm.az.val;

            float r21 = rm.bx.val;
            float r22 = rm.by.val;
            float r23 = rm.bz.val;

            float r31 = rm.cx.val;
            float r32 = rm.cy.val;
            float r33 = rm.cz.val;

            float y = -(float)Math.Asin(Clamp(r13, -1.0f, 1.0f));
            float c = (float)Math.Cos(y);
            ry = y;
            if (Math.Abs(ry) >= Math.PI * 2.0)
            {
                ry = 0;
            }

            y *= (float)(180.0 / Math.PI);

            if (Math.Abs(c) > 0.0005f)
            {
                float invC = 1.0f / c;
                float rotx = r33 * invC;
                float roty = r23 * invC;
                rx = (float)Math.Atan2(roty, rotx);
                if (rx < 0)
                {
                    rx += (float)(Math.PI * 2.0);
                }

                rotx = r11 * invC;
                roty = r12 * invC;
                rz = (float)Math.Atan2(roty, rotx);
                if (rz < 0)
                {
                    rz += (float)(Math.PI * 2.0);
                }
            }
            else
            {
                rx = 0;
                rz = (float)Math.Atan2(-r21, r22);
                if (rz < 0)
                {
                    rz += (float)(Math.PI * 2.0);
                }
            }
        }

        /// <summary>
        /// Thread variable for irrlicht thread.
        /// </summary>
        private Thread irrThread;

        private IrrlichtDevice device;
        private VideoDriver driver;
        private SceneManager smgr;
        private GUIEnvironment gui;

        private IrrlichtLime.Scene.SceneNode worldNode;
        private IrrlichtLime.Scene.SceneNode lightNode;

        private string inputFilename;
        private string depot;
        private int meshId;
        private bool doAddNodes;

        public frmLevelScene(string filename, string depotPath)
        {
            this.inputFilename = filename;
            this.depot = depotPath;
            this.meshId = 1;
            this.doAddNodes = false;
            InitializeComponent();
        }

        private void AddLayer(string layerFileName, string layerName, ref int meshId)
        {
            float RADIANS_TO_DEGREES = (float)(180 / Math.PI);

            CR2WFile layer;
            using (var fs = new FileStream(layerFileName, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                layer = new CR2WFile();
                layer.Read(reader);
                fs.Close();
            }

            TreeNode layerNode = new TreeNode(layerName);

            foreach (var chunk in layer.chunks)
            {
                if (chunk.REDType == "CSectorData")
                {
                    CSectorData sd = (CSectorData)chunk.data;

                    // only add sector node if there are meshes
                    bool atLeastOneMesh = false;

                    foreach (var block in sd.BlockData)
                    {
                        if (block.packedObjectType == Enums.BlockDataObjectType.Mesh)
                        {
                            SVector3D position = block.position;
                            CMatrix3x3 rot = block.rotationMatrix;
                            float rx, ry, rz;
                            MatrixToEuler(rot, out rx, out ry, out rz); // radians

                            Vector3Df rotation = new Vector3Df(rx * RADIANS_TO_DEGREES, ry * RADIANS_TO_DEGREES, rz * RADIANS_TO_DEGREES);
                            Vector3Df translation = new Vector3Df(position.X.val, position.Y.val, position.Z.val);

                            // now get mesh to apply this to!
                            SBlockDataMeshObject mo = (SBlockDataMeshObject)block.packedObject;
                            ushort meshIndex = mo.meshIndex.val;
                            if (meshIndex > sd.Resources.Count)
                            {
                                continue;
                            }
                            string meshName = sd.Resources[meshIndex].pathHash.val;

                            if (string.IsNullOrEmpty(meshName))
                            {
                                continue;
                            }
                            string meshPath = depot + "\\" + meshName;

                            CR2WFile meshAssetFile;
                            using (var fs = new FileStream(meshPath, FileMode.Open, FileAccess.Read))
                            using (var reader = new BinaryReader(fs))
                            {
                                meshAssetFile = new CR2WFile();
                                meshAssetFile.FileName = meshPath; // needed for WKMesh loader!
                                meshAssetFile.Read(reader);
                                fs.Close();
                            }

                            CommonData cdata = new CommonData();
                            WKMesh renderMesh = new WKMesh(cdata);
                            renderMesh.LoadData(meshAssetFile, device);

                            Mesh m = renderMesh.GetMesh();
                            device.SceneManager.MeshManipulator.CreateMeshWithTangents(m);

                            RenderTreeNode meshNode = new RenderTreeNode(meshName, meshId++, m, translation, rotation);

                            sceneView.Invoke((MethodInvoker)delegate
                            {
                                if (!atLeastOneMesh)
                                {
                                    sceneView.Nodes.Add(layerNode);
                                    atLeastOneMesh = true;
                                }
                                layerNode.Nodes.Add(meshNode);
                            });
                        }
                    }
                }
            }
        }

        private void ParseScene()
        {
            if (Path.GetExtension(inputFilename) == ".w2w")
            {
                CR2WFile world;
                using (var fs = new FileStream(inputFilename, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(fs))
                {
                    world = new CR2WFile();
                    world.Read(reader);
                    fs.Close();
                }

                foreach (var worldChunk in world.chunks)
                {
                    if (worldChunk.REDType == "CLayerInfo")
                    {
                        CLayerInfo info = (CLayerInfo)worldChunk.data;
                        string layerFileName = depot + "\\" + info.DepotFilePath;

                        AddLayer(layerFileName, info.DepotFilePath.ToString(), ref meshId);
                    }
                }
            }
            else if(Path.GetExtension(inputFilename) == ".w2l")
            {
                AddLayer(inputFilename, inputFilename, ref meshId);
            }
        }

        /// <summary>
        /// Starts an irrlicht thread.
        /// </summary>
        private void StartIrrThread()
        {
            ThreadStart irrThreadStart = new ThreadStart(StartIrr);
            irrThread = new Thread(irrThreadStart);
            irrThread.IsBackground = true;
            irrThread.Start();
        }

        /// <summary>
        /// Restarts an irrlicht thread.
        /// </summary>
        private void RestartIrrThread()
        {
            irrThread.Abort();
            // restart an irrlicht thread
            StartIrrThread();
        }

        /// <summary>
        /// The irrlicht thread for rendering.
        /// </summary>
        private void StartIrr()
        {
            try
            {
                //Setup
                IrrlichtCreationParameters irrparam = new IrrlichtCreationParameters();
                if (irrlichtPanel.IsDisposed)
                    throw new Exception("Form closed!");
                if (irrlichtPanel.InvokeRequired)
                    irrlichtPanel.Invoke(new MethodInvoker(delegate { irrparam.WindowID = irrlichtPanel.Handle; }));
                irrparam.DriverType = DriverType.Direct3D9;
                irrparam.BitsPerPixel = 16;

                device = IrrlichtDevice.CreateDevice(irrparam);

                if (device == null) throw new NullReferenceException("Could not create device for engine!");

                driver = device.VideoDriver;
                smgr = device.SceneManager;
                gui = device.GUIEnvironment;

                driver.SetTextureCreationFlag(TextureCreationFlag.Always32Bit, true);

                lightNode = smgr.AddLightSceneNode(null, new Vector3Df(0, 0, 0), new Colorf(1.0f, 1.0f, 1.0f), 2000);
                smgr.AmbientLight = new Colorf(0.3f, 0.3f, 0.3f);
                worldNode = smgr.AddEmptySceneNode();
                worldNode.Rotation = new Vector3Df(-90, 0, 0);
                worldNode.Visible = true;

                ParseScene();

                smgr.AddCameraSceneNodeMaya();

                toolStrip.Invoke((MethodInvoker)delegate
                {
                    addMeshButton.Enabled = true;
                });

                while (device.Run())
                {
                    if(doAddNodes)
                    {
                        AddLayer(inputFilename, inputFilename, ref meshId);
                        doAddNodes = false;
                    }
                    driver.BeginScene(ClearBufferFlag.All, new IrrlichtLime.Video.Color(0, 0, 100));
                    smgr.DrawAll();
                    driver.EndScene();
                }

                device.Drop();
            }
            catch (ThreadAbortException) { }
            catch (NullReferenceException) { }
            catch (Exception ex)
            {
                if (!this.IsDisposed)
                {
                    MessageBox.Show(ex.Message);
                    //this.Invoke(new MethodInvoker(delegate { this.Close(); }));
                }
            }
        }

        private void frmLevelScene_Load(object sender, EventArgs e)
        {
            StartIrrThread();
        }

        private void irrlichtPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(device != null)
            {
                MouseEventType mev = MouseEventType.Move;
                uint buttonStates = 0;

                if (e.Button == MouseButtons.Left)
                {
                    buttonStates = 1;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    buttonStates = 2;
                }
                else if (e.Button == MouseButtons.Middle)
                {
                    buttonStates = 4;
                }

                float wheel = e.Delta;
                Event evt = new Event(mev, e.X, e.Y, wheel, buttonStates);
                if(device.PostEvent(evt))
                {
                    lightNode.Position = smgr.ActiveCamera.Position;
                }
            }
        }

        private void irrlichtPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void frmLevelScene_KeyDown(object sender, KeyEventArgs e)
        {
            var cam = smgr.ActiveCamera;
            float cameraspeed = 1f;
            switch (e.KeyCode)
            {
                case Keys.Escape:
                {
                    device.Close();
                    irrThread.Abort();
                    this.Close();
                    break;
                }
                case Keys.W:
                {
                    var vec = (cam.Target - cam.Position).Normalize() * cameraspeed;
                    cam.Position += vec;
                    cam.Target += vec;
                    break;
                }
                case Keys.S:
                {
                    var vec = (cam.Target - cam.Position).Normalize() * cameraspeed;
                    cam.Position -= vec;
                    cam.Target -= vec;
                    break;
                }
                case Keys.A:
                {
                    var vec = (cam.Target - cam.Position).Normalize().DotProduct(cam.Target.Normalize()) * cameraspeed;
                    cam.Position -= vec;
                    cam.Target -= vec;
                    break;
                }
                case Keys.D:
                {
                    var vec = (cam.Target - cam.Position).Normalize().DotProduct(cam.Target.Normalize()) *cameraspeed;
                    cam.Position += vec;
                    cam.Target += vec;
                    break;
                }
                case Keys.P:
                {
                    Console.WriteLine("--------- DEBUG ---------");
                    Console.WriteLine($"[DEBUG] Camera position - (X - {cam.Position.X}, Y - {cam.Position.Y}, Z - {cam.Position.Z})");
                    Console.WriteLine("--------- DEBUG ---------");
                    break;
                }
                case Keys.Q:
                {
                    break;
                }
            }
            lightNode.Position = cam.Position;
        }

        private void irrlichtPanel_Click(object sender, EventArgs e)
        {
        }

        private void Render(RenderTreeNode node)
        {
            if (node.MeshNode == null)
            {
                MeshSceneNode meshNode = smgr.AddMeshSceneNode(node.Mesh, worldNode, node.ID, node.Position, node.Rotation);
                meshNode.SetMaterialFlag(MaterialFlag.Lighting, false);
                meshNode.SetMaterialFlag(MaterialFlag.GouraudShading, true);

                foreach (MeshBuffer mb in node.Mesh.MeshBuffers)
                {
                    driver.RemoveTexture(mb.Material.GetTexture(0));
                    driver.RemoveTexture(mb.Material.GetTexture(1));

                    meshNode.SetMaterialTexture(0, mb.Material.GetTexture(0));
                    meshNode.SetMaterialTexture(1, mb.Material.GetTexture(1));
                }
                node.MeshNode = meshNode;
            }
            node.MeshNode.Visible = true;

            // otherwise the node is already in the scene so just put it in camera focus
            var camera = smgr.ActiveCamera;

            // for a Maya camera just set the target
            camera.Target = new Vector3Df(node.MeshNode.AbsolutePosition);
            lightNode.Position = camera.Position;
        }

        private void Hide(RenderTreeNode node)
        {
            node.MeshNode.Visible = false;
        }

        private void irrlichtPanel_Enter(object sender, EventArgs e)
        {
            if (device != null)
            {
                if (device.CursorControl != null)
                {
                    device.CursorControl.Visible = false;
                }
            }
        }

        private void irrlichtPanel_Leave(object sender, EventArgs e)
        {
            if (device != null)
            {
                if (device.CursorControl != null)
                {
                    device.CursorControl.Visible = true;
                }
            }
        }

        private void sceneView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Checked)
            {
                if (node.Nodes.Count > 0)
                {
                    foreach (RenderTreeNode n in node.Nodes)
                    {
                        n.Checked = true;
                        Render(n);
                    }
                }
                else
                {
                    Render((RenderTreeNode)node);
                }
            }
            else
            {
                if (node.Nodes.Count > 0)
                {
                    foreach (RenderTreeNode n in node.Nodes)
                    {
                        n.Checked = false;
                        Hide(n); 
                    }                    
                }
                else
                {
                    Hide((RenderTreeNode)node);
                }
            }
        }

        private void addMeshButton_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog() { Title = "Select W2L file" };
            dlg.Multiselect = false;
            dlg.Filters.Add(new CommonFileDialogFilter("W2L Files", ".w2l"));
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                inputFilename = dlg.FileName;
                doAddNodes = true;
            }
        }
    }
}