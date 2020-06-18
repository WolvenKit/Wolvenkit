using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCustomCameraDefaultPRC : ICustomCameraPivotRotationController
	{
		[RED("dampYawFactor")] 		public CFloat DampYawFactor { get; set;}

		[RED("dampPitchFactor")] 		public CFloat DampPitchFactor { get; set;}

		[RED("yawMaxVelocity")] 		public CFloat YawMaxVelocity { get; set;}

		[RED("yawAcceleration")] 		public CFloat YawAcceleration { get; set;}

		[RED("pitchAcceleration")] 		public CFloat PitchAcceleration { get; set;}

		[RED("pitchMaxVelocity")] 		public CFloat PitchMaxVelocity { get; set;}

		public CCustomCameraDefaultPRC(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCustomCameraDefaultPRC(cr2w);

	}
}