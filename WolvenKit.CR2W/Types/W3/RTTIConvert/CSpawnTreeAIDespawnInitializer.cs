using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeAIDespawnInitializer : CSpawnTreeDespawnInitializer
	{
		[RED("aiDespawnConfiguration")] 		public SSpawnTreeAIDespawnConfiguration AiDespawnConfiguration { get; set;}

		[RED("ai")] 		public CHandle<CAIDespawnTree> Ai { get; set;}

		[RED("aiPriority")] 		public CEnum<ETopLevelAIPriorities> AiPriority { get; set;}

		public CSpawnTreeAIDespawnInitializer(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSpawnTreeAIDespawnInitializer(cr2w);

	}
}