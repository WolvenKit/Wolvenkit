using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingDashLocked : CExplorationInterceptorStateAbstract
	{
		[RED("targetMaxAngle")] 		public CFloat TargetMaxAngle { get; set;}

		[RED("targetMaxAngleFlow")] 		public CFloat TargetMaxAngleFlow { get; set;}

		[RED("reachSideDistance")] 		public CFloat ReachSideDistance { get; set;}

		[RED("targetSideDistance")] 		public CFloat TargetSideDistance { get; set;}

		[RED("inputAngleInfluence")] 		public CFloat InputAngleInfluence { get; set;}

		[RED("aimSpeed")] 		public CFloat AimSpeed { get; set;}

		[RED("adjustorTicket")] 		public SMovementAdjustmentRequestTicket AdjustorTicket { get; set;}

		[RED("attackDistGap")] 		public CFloat AttackDistGap { get; set;}

		[RED("attackDistGapPerfect")] 		public CFloat AttackDistGapPerfect { get; set;}

		[RED("timeTotalMax")] 		public CFloat TimeTotalMax { get; set;}

		[RED("timeTotalMaxFlow")] 		public CFloat TimeTotalMaxFlow { get; set;}

		[RED("timeToChainMin")] 		public CFloat TimeToChainMin { get; set;}

		[RED("useTimeScale")] 		public CBool UseTimeScale { get; set;}

		[RED("timeScaleSpeed")] 		public CFloat TimeScaleSpeed { get; set;}

		[RED("afterAttackTime")] 		public CFloat AfterAttackTime { get; set;}

		[RED("behParamAttackName")] 		public CName BehParamAttackName { get; set;}

		[RED("afterAttackImpulse")] 		public CFloat AfterAttackImpulse { get; set;}

		[RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		public CExplorationStateSkatingDashLocked(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationStateSkatingDashLocked(cr2w);

	}
}