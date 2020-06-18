using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationClimbOracle : CObject
	{
		[RED("distForwardToCheck")] 		public CFloat DistForwardToCheck { get; set;}

		[RED("characterRadius")] 		public CFloat CharacterRadius { get; set;}

		[RED("characterHeight")] 		public CFloat CharacterHeight { get; set;}

		[RED("radiusToCheck")] 		public CFloat RadiusToCheck { get; set;}

		[RED("bottomCheckAllowed")] 		public CBool BottomCheckAllowed { get; set;}

		public CExplorationClimbOracle(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationClimbOracle(cr2w);

	}
}