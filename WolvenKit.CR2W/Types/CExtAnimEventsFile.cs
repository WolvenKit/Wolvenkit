﻿using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;

namespace WolvenKit.CR2W.Types
{
    public class CExtAnimEventsFile : CVector
    {
        public CUInt32 unk1;
            
        public CExtAnimEventsFile(CR2WFile cr2w) :
            base(cr2w)
        {
            unk1 = new CUInt32(cr2w)
            {
                Name = "unk1"
            };
            
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            unk1.Read(file, 0);
            
            //dbg
            if (unk1.val > 0)
            {
                Debugger.Break();
                throw new NotImplementedException();
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            unk1.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CExtAnimEventsFile(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CExtAnimEventsFile) base.Copy(context);

            var.unk1 = (CUInt32) unk1.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                unk1
            };
        }
    }
}