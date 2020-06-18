using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalInitialEntriesResource : CResource
	{
		[RED("entries", 2,0)] 		public CArray<CHandle<CJournalPath>> Entries { get; set;}

		[RED("regularQuestCount")] 		public CUInt32 RegularQuestCount { get; set;}

		[RED("monsterHuntQuestCount")] 		public CUInt32 MonsterHuntQuestCount { get; set;}

		[RED("treasureHuntQuestCount")] 		public CUInt32 TreasureHuntQuestCount { get; set;}

		public CJournalInitialEntriesResource(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CJournalInitialEntriesResource(cr2w);

	}
}