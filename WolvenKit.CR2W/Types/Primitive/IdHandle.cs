﻿﻿using System.Collections.Generic;
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
    public class IdHandle : CVariable
    {
        public CName handlename;
        public CHandle<CBehaviorVariable> handle;

        public IdHandle(CR2WFile cr2w) : base(cr2w)
        {
            handlename = new CName(cr2w) { REDName = "handlename" };
            handle = new CHandle<CBehaviorVariable>(cr2w) { REDName = "handle" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            handlename.Read(file, 2);
            handle.Read(file, 2);
        }

        public override void Write(BinaryWriter file)
        {
            handlename.Write(file);
            handle.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new IdHandle(cr2w);
        }

        public override string ToString()
        {
            return $"[{handlename.ToString()}]:{handle.ToString()}";
        }
    }
}