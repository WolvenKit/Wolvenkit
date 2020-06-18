using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphEnumComparatorNode : CBehaviorGraphValueNode
	{
		[RED("enumValue")] 		public CVariant EnumValue { get; set;}

		[RED("operation")] 		public CEnum<ECompareFunc> Operation { get; set;}

		[RED("cachedFirstInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedFirstInputNode { get; set;}

		public CBehaviorGraphEnumComparatorNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphEnumComparatorNode(cr2w);

	}
}