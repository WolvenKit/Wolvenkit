using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawner : CEntity
	{
		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("count")] 		public CInt32 Count { get; set;}

		[RED("immortalityMode")] 		public CEnum<EActorImmortalityMode> ImmortalityMode { get; set;}

		[RED("attitudeOverride")] 		public CBool AttitudeOverride { get; set;}

		[RED("attitudeToPlayer")] 		public CEnum<EAIAttitude> AttitudeToPlayer { get; set;}

		[RED("hostileSpawnerTag")] 		public CName HostileSpawnerTag { get; set;}

		[RED("spawnTags", 2,0)] 		public CArray<CName> SpawnTags { get; set;}

		[RED("respawn")] 		public CBool Respawn { get; set;}

		[RED("respawnDelay")] 		public CFloat RespawnDelay { get; set;}

		[RED("initialHealth")] 		public CInt32 InitialHealth { get; set;}

		[RED("spawnAnimation")] 		public CEnum<EExplorationMode> SpawnAnimation { get; set;}

		public CSpawner(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSpawner(cr2w);

	}
}