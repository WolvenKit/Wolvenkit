﻿using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SMipData : CVariable
    {
        [RED] public CUInt32 Width { get; set; }
        [RED] public CUInt32 Height { get; set; }
        [RED] public CUInt32 Blocksize { get; set; }

        public SMipData(CR2WFile cr2w) :
            base(cr2w)
        {

            
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SMipData(cr2w);
        }
    }
}