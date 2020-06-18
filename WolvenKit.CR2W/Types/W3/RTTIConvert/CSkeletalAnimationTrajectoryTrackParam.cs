using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSkeletalAnimationTrajectoryTrackParam : ISkeletalAnimationSetEntryParam
	{
		[RED("editorOnly")] 		public CBool EditorOnly { get; set;}

		[RED("names", 2,0)] 		public CArray<CName> Names { get; set;}

		[RED("datas", 2,0)] 		public CArray<CArray<Vector>> Datas { get; set;}

		public CSkeletalAnimationTrajectoryTrackParam(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSkeletalAnimationTrajectoryTrackParam(cr2w);

	}
}