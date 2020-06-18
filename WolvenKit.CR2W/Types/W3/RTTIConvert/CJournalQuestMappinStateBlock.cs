using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalQuestMappinStateBlock : CQuestGraphBlock
	{
		[RED("mappinEntry")] 		public CHandle<CJournalPath> MappinEntry { get; set;}

		[RED("enableOnlyIfLatest")] 		public CBool EnableOnlyIfLatest { get; set;}

		[RED("disableAllOtherMapPins")] 		public CBool DisableAllOtherMapPins { get; set;}

		public CJournalQuestMappinStateBlock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CJournalQuestMappinStateBlock(cr2w);

	}
}