using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    public class AdditionalContent
    {
        #region Properties

        [CName("count")]
        public uint Count { get; set; }

        public string[] Items { get; set; }

        #endregion Properties
    }
}
