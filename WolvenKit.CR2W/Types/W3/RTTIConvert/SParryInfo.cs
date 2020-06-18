using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SParryInfo : CVariable
	{
		[RED("attacker")] 		public CHandle<CActor> Attacker { get; set;}

		[RED("target")] 		public CHandle<CActor> Target { get; set;}

		[RED("targetToAttackerAngleAbs")] 		public CFloat TargetToAttackerAngleAbs { get; set;}

		[RED("targetToAttackerDist")] 		public CFloat TargetToAttackerDist { get; set;}

		[RED("attackSwingType")] 		public CEnum<EAttackSwingType> AttackSwingType { get; set;}

		[RED("attackSwingDir")] 		public CEnum<EAttackSwingDirection> AttackSwingDir { get; set;}

		[RED("attackActionName")] 		public CName AttackActionName { get; set;}

		[RED("attackerWeaponId")] 		public SItemUniqueId AttackerWeaponId { get; set;}

		[RED("canBeParried")] 		public CBool CanBeParried { get; set;}

		public SParryInfo(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SParryInfo(cr2w);

	}
}