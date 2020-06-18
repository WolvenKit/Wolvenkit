using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAnimationSwitchNode : CBehaviorGraphNode
	{
		[RED("inputNum")] 		public CUInt32 InputNum { get; set;}

		[RED("cachedInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

		[RED("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		[RED("cachedBlendTimeValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedBlendTimeValueNode { get; set;}

		[RED("blendTime")] 		public CFloat BlendTime { get; set;}

		[RED("interpolation")] 		public CEnum<EInterpolationType> Interpolation { get; set;}

		[RED("synchronizeOnSwitch")] 		public CBool SynchronizeOnSwitch { get; set;}

		[RED("syncOnSwitchMethod")] 		public CPtr<IBehaviorSyncMethod> SyncOnSwitchMethod { get; set;}

		public CBehaviorGraphAnimationSwitchNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphAnimationSwitchNode(cr2w);

	}
}