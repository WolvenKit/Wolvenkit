using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAnimalQuestDefaults : CAIDefaults
	{
		[RED("combatTree")] 		public CHandle<CAICombatTree> CombatTree { get; set;}

		[RED("idleTree")] 		public CHandle<CAIIdleTree> IdleTree { get; set;}

		[RED("deathTree")] 		public CHandle<CAIDeathTree> DeathTree { get; set;}

		public CAIAnimalQuestDefaults(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIAnimalQuestDefaults(cr2w);

	}
}