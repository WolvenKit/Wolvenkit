using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SettlementTrigger : CR4JournalPlaceEntity
	{
		[RED("settlementName")] 		public CName SettlementName { get; set;}

		[RED("hubNameOverride")] 		public CName HubNameOverride { get; set;}

		[RED("lockReenterDisplayTime")] 		public CFloat LockReenterDisplayTime { get; set;}

		[RED("blockHorseTopSpeed")] 		public CBool BlockHorseTopSpeed { get; set;}

		public W3SettlementTrigger(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3SettlementTrigger(cr2w);

	}
}