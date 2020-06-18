using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTree : CResource
	{
		[RED("rootNode")] 		public CPtr<ISpawnTreeBaseNode> RootNode { get; set;}

		[RED("creatureDefinition", 2,0)] 		public CArray<CPtr<CEncounterCreatureDefinition>> CreatureDefinition { get; set;}

		[RED("spawnTreeType")] 		public CEnum<ESpawnTreeType> SpawnTreeType { get; set;}

		public CSpawnTree(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSpawnTree(cr2w);

	}
}