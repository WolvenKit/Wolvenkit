using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphEventWatchdogNode : CBehaviorGraphValueNode
	{
		[RED("eventName")] 		public CName EventName { get; set;}

		[RED("trueValue")] 		public CFloat TrueValue { get; set;}

		[RED("falseValue")] 		public CFloat FalseValue { get; set;}

		[RED("maxTime")] 		public CFloat MaxTime { get; set;}

		[RED("timeOut")] 		public CFloat TimeOut { get; set;}

		[RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		public CBehaviorGraphEventWatchdogNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphEventWatchdogNode(cr2w);

	}
}