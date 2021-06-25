using System.Collections.Generic;
using System.IO;
using ReactiveUI;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.Common.Model
{
    public enum EntryType
    {
        Directory,
        File,
        MoveUP
    }

    public class FileEntryViewModel
    {
        private readonly IGameFile _fileEntry;

        public FileEntryViewModel(IGameFile fileEntry)
        {
            _fileEntry = fileEntry;
        }

        public string Name => Path.GetFileName(_fileEntry.Name);
        public string Extension => _fileEntry.Extension.TrimStart('.');
        public string FullName => _fileEntry.Name;
        public string Archive => _fileEntry.Archive.Name;
        public ulong Key => _fileEntry.Key;
        public uint Size => _fileEntry.Size;


        public IGameFile GetGameFile() => _fileEntry;

    }
}
