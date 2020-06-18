using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPlaneMovementParameters : CVariable
	{
		[RED("m_SpeedMaxF")] 		public CFloat M_SpeedMaxF { get; set;}

		[RED("m_AccelF")] 		public CFloat M_AccelF { get; set;}

		[RED("m_DecelF")] 		public CFloat M_DecelF { get; set;}

		[RED("m_BrakeF")] 		public CFloat M_BrakeF { get; set;}

		[RED("m_BrakeDotF")] 		public CFloat M_BrakeDotF { get; set;}

		public SPlaneMovementParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SPlaneMovementParameters(cr2w);

	}
}