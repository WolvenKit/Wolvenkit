using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTRuberBand : IMoveSteeringTask
	{
		[RED("halfRange")] 		public CFloat HalfRange { get; set;}

		[RED("tensionCurve")] 		public SSimpleCurve TensionCurve { get; set;}

		[RED("minAllowedSpeed")] 		public CFloat MinAllowedSpeed { get; set;}

		public CMoveSTRuberBand(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CMoveSTRuberBand(cr2w);

	}
}