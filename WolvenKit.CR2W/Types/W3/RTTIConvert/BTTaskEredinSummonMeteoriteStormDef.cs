using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskEredinSummonMeteoriteStormDef : IBehTreeTaskDefinition
	{
		[RED("resourceName")] 		public CName ResourceName { get; set;}

		[RED("eventName")] 		public CName EventName { get; set;}

		public BTTaskEredinSummonMeteoriteStormDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskEredinSummonMeteoriteStormDef(cr2w);

	}
}