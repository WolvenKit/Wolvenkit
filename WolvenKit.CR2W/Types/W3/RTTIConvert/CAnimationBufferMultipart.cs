using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimationBufferMultipart : IAnimationBuffer
	{
		[RED("numFrames")] 		public CUInt32 NumFrames { get; set;}

		[RED("numBones")] 		public CUInt32 NumBones { get; set;}

		[RED("numTracks")] 		public CUInt32 NumTracks { get; set;}

		[RED("firstFrames", 2,0)] 		public CArray<CUInt32> FirstFrames { get; set;}

		[RED("parts", 2,0)] 		public CArray<CPtr<IAnimationBuffer>> Parts { get; set;}

		public CAnimationBufferMultipart(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAnimationBufferMultipart(cr2w);

	}
}