﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Catel.IoC;
using WolvenKit.Common.Services;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;

namespace CP77.CR2W.Archive
{
    public class ArchiveItem : IGameFile
    {
        public ulong NameHash64 { get; set; }
        public DateTime DateTime { get; set; }
        public uint FileFlags { get; set; }
        public uint FirstOffsetTableIdx { get; set; }
        public uint LastOffsetTableIdx { get; set; }
        public uint FirstImportTableIdx { get; set; }
        public uint LastImportTableIdx { get; set; }
        public byte[] SHA1Hash { get; set; }

        public string bytesAsString => BitConverter.ToString(SHA1Hash);

        private string _nameStr;
        public string NameOrHash => string.IsNullOrEmpty(_nameStr) ? $"{NameHash64}" : _nameStr;
        public string FileName => string.IsNullOrEmpty(_nameStr) ? $"{NameHash64}.bin" : _nameStr;
        public string Extension => Path.GetExtension(FileName);

        public IGameArchive Bundle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public uint Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public uint ZSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long PageOffset { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string CompressionType => throw new NotImplementedException();

        private Archive _parentArchive;

        public ArchiveItem(BinaryReader br, Archive parent)
        {
            _parentArchive = parent;
            var mainController = ServiceLocator.Default.ResolveType<IHashService>();

            Read(br, mainController);
        }

        public ArchiveItem(ulong hash, DateTime datetime, uint flags
            , uint firstOffsetTableIdx, uint lastOffsetTableIdx, uint firstImportTableIdx, uint lastImportTableIdx, byte[] sha1hash)
        {
            NameHash64 = hash;
            DateTime = datetime;
            FileFlags = flags;
            FirstImportTableIdx = firstImportTableIdx;
            LastImportTableIdx = lastImportTableIdx;
            FirstOffsetTableIdx = firstOffsetTableIdx;
            LastOffsetTableIdx = lastOffsetTableIdx;
            SHA1Hash = sha1hash;
        }

        private void Read(BinaryReader br, IHashService mainController)
        {
            NameHash64 = br.ReadUInt64();

            if (mainController != null && mainController.Hashdict.ContainsKey(NameHash64))
                _nameStr = mainController.Hashdict[NameHash64];
            
            // x-platform support
            if (System.Runtime.InteropServices.RuntimeInformation
                .IsOSPlatform(System.Runtime.InteropServices.OSPlatform.OSX))
            {
                if (!string.IsNullOrEmpty(_nameStr) && _nameStr.Contains('\\'))
                    _nameStr = _nameStr.Replace('\\', Path.DirectorySeparatorChar);
            }

            DateTime = DateTime.FromFileTime(br.ReadInt64());


            FileFlags = br.ReadUInt32();
            FirstOffsetTableIdx = br.ReadUInt32();
            LastOffsetTableIdx = br.ReadUInt32();
            FirstImportTableIdx = br.ReadUInt32();
            LastImportTableIdx = br.ReadUInt32();

            SHA1Hash = br.ReadBytes(20);
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(NameHash64);
            bw.Write(DateTime.ToFileTime());
            bw.Write(FileFlags);
            bw.Write(FirstOffsetTableIdx);
            bw.Write(LastOffsetTableIdx);
            bw.Write(FirstImportTableIdx);
            bw.Write(LastImportTableIdx);
            bw.Write(SHA1Hash);
        }

        public void Extract(Stream output)
        {
            throw new NotImplementedException();
        }

        public string Extract(BundleFileExtractArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
