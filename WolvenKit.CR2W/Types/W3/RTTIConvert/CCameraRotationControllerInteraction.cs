using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraRotationControllerInteraction : ICustomCameraScriptedPivotRotationController
	{
		[RED("pitchMaxSpeed")] 		public CFloat PitchMaxSpeed { get; set;}

		[RED("blendTodesiredPitch")] 		public CBool BlendTodesiredPitch { get; set;}

		[RED("desiredPitch")] 		public CFloat DesiredPitch { get; set;}

		[RED("desiredPitchSpeed")] 		public CFloat DesiredPitchSpeed { get; set;}

		[RED("yawMaxSpeed")] 		public CFloat YawMaxSpeed { get; set;}

		public CCameraRotationControllerInteraction(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCameraRotationControllerInteraction(cr2w);

	}
}