using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class JournalDescriptionText : CVariable
	{
		[RED("order")] 		public CInt32 Order { get; set;}

		[RED("groupOrder")] 		public CInt32 GroupOrder { get; set;}

		[RED("stringKey")] 		public CInt32 StringKey { get; set;}

		[RED("currentEntry")] 		public CHandle<CJournalQuestDescriptionEntry> CurrentEntry { get; set;}

		public JournalDescriptionText(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new JournalDescriptionText(cr2w);

	}
}