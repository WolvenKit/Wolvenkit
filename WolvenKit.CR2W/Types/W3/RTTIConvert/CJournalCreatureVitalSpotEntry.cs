using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalCreatureVitalSpotEntry : CJournalContainerEntry
	{
		[RED("title")] 		public LocalizedString Title { get; set;}

		[RED("description")] 		public LocalizedString Description { get; set;}

		[RED("active")] 		public CBool Active { get; set;}

		public CJournalCreatureVitalSpotEntry(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CJournalCreatureVitalSpotEntry(cr2w);

	}
}