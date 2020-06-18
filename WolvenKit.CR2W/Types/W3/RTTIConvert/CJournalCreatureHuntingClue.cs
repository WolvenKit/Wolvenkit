using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalCreatureHuntingClue : CJournalContainerEntry
	{
		[RED("category")] 		public CName Category { get; set;}

		[RED("clue")] 		public CInt32 Clue { get; set;}

		[RED("active")] 		public CBool Active { get; set;}

		public CJournalCreatureHuntingClue(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CJournalCreatureHuntingClue(cr2w);

	}
}