﻿using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class EntityHandle : CVariable
    {
        public CUInt16 id;
        public CGUID guid;
        public CBytes unk1;

        public EntityHandle(CR2WFile cr2w) : base(cr2w)
        {
            id = new CUInt16(cr2w) { REDName = "id" };
            guid = new CGUID(cr2w) { REDName = "guid" };
            unk1 = new CBytes(cr2w) { REDName = "unk1", Bytes = Array.Empty<byte>() };
        }

        public override void Read(BinaryReader file, uint size)
        {
            id.Read(file, 2);
            guid.Read(file, 16);
            if (size - 18 > 0)
            {
                unk1.Read(file, size - 18);
            }
                
        }

        public override void Write(BinaryWriter file)
        {
            id.Write(file);
            guid.Write(file);
            unk1.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new EntityHandle(cr2w);
        }

        public override string ToString()
        {
            return $"[{id.ToString()}]:{guid.ToString()}";
        }
    }
}