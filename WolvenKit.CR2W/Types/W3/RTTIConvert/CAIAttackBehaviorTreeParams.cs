using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAttackBehaviorTreeParams : CAICombatActionParameters
	{
		[RED("chargeAction")] 		public CBool ChargeAction { get; set;}

		[RED("approachAction")] 		public CBool ApproachAction { get; set;}

		[RED("throwBomb")] 		public CBool ThrowBomb { get; set;}

		[RED("teleportAction")] 		public CBool TeleportAction { get; set;}

		[RED("attackAction")] 		public CHandle<CAIAttackActionTree> AttackAction { get; set;}

		[RED("attackActionRange")] 		public CName AttackActionRange { get; set;}

		[RED("farAttackAction")] 		public CHandle<CAIAttackActionTree> FarAttackAction { get; set;}

		[RED("farAttackActionRange")] 		public CName FarAttackActionRange { get; set;}

		public CAIAttackBehaviorTreeParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIAttackBehaviorTreeParams(cr2w);

	}
}