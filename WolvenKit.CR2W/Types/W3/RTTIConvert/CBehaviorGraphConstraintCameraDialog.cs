using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintCameraDialog : CBehaviorGraphBaseNode
	{
		[RED("cameraBone")] 		public CString CameraBone { get; set;}

		[RED("referenceZ")] 		public CFloat ReferenceZ { get; set;}

		[RED("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		[RED("cachedSourceTargetValueNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedSourceTargetValueNode { get; set;}

		[RED("cachedDestTargetValueNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedDestTargetValueNode { get; set;}

		public CBehaviorGraphConstraintCameraDialog(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphConstraintCameraDialog(cr2w);

	}
}