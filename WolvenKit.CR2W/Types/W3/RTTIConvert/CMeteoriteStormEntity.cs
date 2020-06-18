using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMeteoriteStormEntity : CGameplayEntity
	{
		[RED("resourceName")] 		public CName ResourceName { get; set;}

		[RED("timeBetweenSpawn")] 		public CFloat TimeBetweenSpawn { get; set;}

		[RED("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[RED("minDistFromEachOther")] 		public CFloat MinDistFromEachOther { get; set;}

		public CMeteoriteStormEntity(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CMeteoriteStormEntity(cr2w);

	}
}