﻿using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Linq;
using WolvenKit.CR2W.Types.Utils;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    public partial class CEntity : CNode
    {

        [REDBuffer(true)] public CCompressedBuffer<SEntityBufferType1> buffer_v1 { get; set; }
        [REDBuffer(true)] public CBufferUInt32<SEntityBufferType2> buffer_v2 { get; set; }

        private bool isCreatedFromTemplate;
            
        public CEntity(CR2WFile cr2w) : base(cr2w)
        {
            buffer_v1 = new CCompressedBuffer<SEntityBufferType1>(cr2w, _ => new SEntityBufferType1(_));
            buffer_v2 = new CBufferUInt32<SEntityBufferType2>(cr2w, _ => new SEntityBufferType2(_));
        }

        public override void Read(BinaryReader file, uint size)
        {
            var startPos = file.BaseStream.Position;

            base.Read(file, size);

            // check if created from template
            isCreatedFromTemplate = this.Template != null;

            // Read Component Array (should only be present if NOT created from template)
            #region Componentsarray
            if (Components == null)
                Components = new CArray<CPtr<CComponent>>(cr2w) { REDName = nameof(Components), Parent = this };

            var endPos = file.BaseStream.Position;
            var bytesleft = size - (endPos - startPos);
            if (!isCreatedFromTemplate)
            {
                if (bytesleft > 0)
                {
                    var elementcount = file.ReadBit6();
                    for (var i = 0; i < elementcount; i++)
                    {
                        var ptr = new CPtr<CComponent>(cr2w) { REDName = i.ToString(), Parent = Components };
                        ptr.Read(file, 0);
                        Components.AddVariable(ptr);
                    }
                }
                else
                {
                    throw new EndOfStreamException("unknown CEntity Fileformat.");
                }
            }
            #endregion


            // Read Buffer 1 (always)
            #region Buffer 1
            endPos = file.BaseStream.Position;
            bytesleft = size - (endPos - startPos);
            if (bytesleft > 0)
            {
                int idx = 0;
                bool canRead;
                do
                {
                    var t_buffer = new SEntityBufferType1(cr2w)
                    {
                        REDName = idx.ToString(),
                    };
                    canRead = t_buffer.CanRead(file);
                    if (canRead)
                        t_buffer.Read(file, 0);
                    
                    buffer_v1.AddVariable(t_buffer);
                    idx++;
                } while (canRead);
            }
            else
            {
                throw new EndOfStreamException("unknown CEntity Fileformat.");
            }
            #endregion

            // Read Buffer 2 (should only be present if created from template)
            #region Buffer 2
            endPos = file.BaseStream.Position;
            bytesleft = size - (endPos - startPos);
            if (isCreatedFromTemplate)
            {
                if (bytesleft > 0)
                {
                    buffer_v2.Read(file, 0);
                }
                else
                {
                    throw new EndOfStreamException("unknown CEntity Fileformat.");
                }
            }
            #endregion

        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            // check if created from template
            isCreatedFromTemplate = this.Template != null;

            // Write componentsarray (if not created from template)
            if (!isCreatedFromTemplate)
            {
                file.WriteBit6(Components.Count);
                for (var i = 0; i < Components.Count; i++)
                {
                    Components[i].Write(file);
                }
            }

            // Write Buffer 1 (always)
            if (buffer_v1.Count > 0)
            {
                foreach (var buf in buffer_v1)
                {
                    buf.Write(file);
                }
            }
            else
            {
                file.Write((ushort)0x0); //2 null bytes
            }

            // Write Buffer 2 (if created from template)
            if (isCreatedFromTemplate)
                buffer_v2.Write(file);

        }
    }
}