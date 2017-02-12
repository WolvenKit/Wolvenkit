﻿using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace W3Edit
{
    partial class frmModExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModExplorer));
            this.modFileList = new System.Windows.Forms.TreeView();
            this.treeImages = new System.Windows.Forms.ImageList(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchstrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.resetfilesButton = new System.Windows.Forms.ToolStripButton();
            this.showhideButton = new System.Windows.Forms.ToolStripButton();
            this.modexplorerSlave = new System.IO.FileSystemWatcher();
            this.contextMenu.SuspendLayout();
            this.searchstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modexplorerSlave)).BeginInit();
            this.SuspendLayout();
            // 
            // modFileList
            // 
            this.modFileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modFileList.ImageIndex = 0;
            this.modFileList.ImageList = this.treeImages;
            this.modFileList.Location = new System.Drawing.Point(0, 25);
            this.modFileList.Name = "modFileList";
            this.modFileList.SelectedImageIndex = 0;
            this.modFileList.Size = new System.Drawing.Size(484, 380);
            this.modFileList.TabIndex = 0;
            this.modFileList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.modFileList_NodeMouseClick);
            this.modFileList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.modFileList_NodeMouseDoubleClick);
            this.modFileList.DoubleClick += new System.EventHandler(this.modFileList_DoubleClick);
            this.modFileList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modFileList_KeyDown);
            // 
            // treeImages
            // 
            this.treeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImages.ImageStream")));
            this.treeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImages.Images.SetKeyName(0, "genericFile");
            this.treeImages.Images.SetKeyName(1, "normalFolder");
            this.treeImages.Images.SetKeyName(2, "openFolder");
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.removeFileToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(122, 134);
            this.contextMenu.Opened += new System.EventHandler(this.contextMenu_Opened);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Image = global::W3Edit.Properties.Resources.AddNodefromFile_354;
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.addFileToolStripMenuItem.Text = "Add File";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // removeFileToolStripMenuItem
            // 
            this.removeFileToolStripMenuItem.Name = "removeFileToolStripMenuItem";
            this.removeFileToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.removeFileToolStripMenuItem.Text = "Delete";
            this.removeFileToolStripMenuItem.Click += new System.EventHandler(this.removeFileToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // searchstrip
            // 
            this.searchstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.searchBox,
            this.resetfilesButton,
            this.showhideButton});
            this.searchstrip.Location = new System.Drawing.Point(0, 0);
            this.searchstrip.Name = "searchstrip";
            this.searchstrip.Size = new System.Drawing.Size(484, 25);
            this.searchstrip.TabIndex = 1;
            this.searchstrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Search:";
            // 
            // searchBox
            // 
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 25);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            this.searchBox.Validating += new System.ComponentModel.CancelEventHandler(this.searchBox_Validating);
            // 
            // resetfilesButton
            // 
            this.resetfilesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetfilesButton.Image = global::W3Edit.Properties.Resources.ExitIcon;
            this.resetfilesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetfilesButton.Name = "resetfilesButton";
            this.resetfilesButton.Size = new System.Drawing.Size(23, 22);
            this.resetfilesButton.Text = "Reset filelist";
            this.resetfilesButton.Click += new System.EventHandler(this.UpdatefilelistButtonClick);
            // 
            // showhideButton
            // 
            this.showhideButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showhideButton.Image = global::W3Edit.Properties.Resources.LayerGroupVisibled;
            this.showhideButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showhideButton.Name = "showhideButton";
            this.showhideButton.Size = new System.Drawing.Size(23, 22);
            this.showhideButton.Text = "Show/Hide folders";
            this.showhideButton.ToolTipText = "Show/Hide folders";
            this.showhideButton.Click += new System.EventHandler(this.showhideButton_Click);
            // 
            // modexplorerSlave
            // 
            this.modexplorerSlave.EnableRaisingEvents = true;
            this.modexplorerSlave.IncludeSubdirectories = true;
            this.modexplorerSlave.SynchronizingObject = this;
            this.modexplorerSlave.Created += new System.IO.FileSystemEventHandler(this.FileChanges_Detected);
            this.modexplorerSlave.Deleted += new System.IO.FileSystemEventHandler(this.FileChanges_Detected);
            this.modexplorerSlave.Renamed += new System.IO.RenamedEventHandler(this.FileChanges_Detected);
            // 
            // frmModExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 405);
            this.Controls.Add(this.modFileList);
            this.Controls.Add(this.searchstrip);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModExplorer";
            this.Text = "Mod Explorer";
            this.Shown += new System.EventHandler(this.frmModExplorer_Shown);
            this.contextMenu.ResumeLayout(false);
            this.searchstrip.ResumeLayout(false);
            this.searchstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modexplorerSlave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView modFileList;
        private ImageList treeImages;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem removeFileToolStripMenuItem;
        private ToolStripMenuItem addFileToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStrip searchstrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox searchBox;
        private ToolStripButton showhideButton;
        private ToolStripButton resetfilesButton;
        private FileSystemWatcher modexplorerSlave;
    }
}