using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCachedCombatMessage : CVariable
	{
		[RED("finalIncomingDamage")] 		public CFloat FinalIncomingDamage { get; set;}

		[RED("resistPoints")] 		public CFloat ResistPoints { get; set;}

		[RED("resistPercents")] 		public CFloat ResistPercents { get; set;}

		[RED("finalDamage")] 		public CFloat FinalDamage { get; set;}

		[RED("attacker")] 		public CHandle<CGameplayEntity> Attacker { get; set;}

		[RED("victim")] 		public CHandle<CGameplayEntity> Victim { get; set;}

		public SCachedCombatMessage(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SCachedCombatMessage(cr2w);

	}
}