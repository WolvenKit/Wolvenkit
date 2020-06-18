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
    public class STerrainTileData : CVariable
    {
        [RED] public CInt16 Lod1 { get; set; }
        [RED] public CInt16 Lod2 { get; set; }
        [RED] public CInt16 Lod3 { get; set; }
        [RED] public CInt32 Resolution { get; set; }

        public STerrainTileData(CR2WFile cr2w) :
            base(cr2w)
        {
        }

        public override CVariable Create(CR2WFile cr2w) => new STerrainTileData(cr2w);
    }
}