using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWanderDef : IBehTreeTaskDefinition
	{
		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[RED("minSpeed")] 		public CFloat MinSpeed { get; set;}

		[RED("maxSpeed")] 		public CFloat MaxSpeed { get; set;}

		public CBTTaskWanderDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskWanderDef(cr2w);

	}
}