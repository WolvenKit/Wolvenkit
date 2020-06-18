using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskShootDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[RED("attackRange")] 		public CBehTreeValFloat AttackRange { get; set;}

		[RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[RED("setArrowOnFire")] 		public CBehTreeValBool SetArrowOnFire { get; set;}

		public CBTTaskShootDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskShootDef(cr2w);

	}
}