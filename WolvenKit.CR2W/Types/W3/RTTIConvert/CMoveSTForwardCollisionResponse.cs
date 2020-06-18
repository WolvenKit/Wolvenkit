using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTForwardCollisionResponse : CMoveSTCollisionResponse
	{
		[RED("probeDistanceInTime")] 		public CFloat ProbeDistanceInTime { get; set;}

		[RED("crowdThroughVar")] 		public CName CrowdThroughVar { get; set;}

		public CMoveSTForwardCollisionResponse(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CMoveSTForwardCollisionResponse(cr2w);

	}
}