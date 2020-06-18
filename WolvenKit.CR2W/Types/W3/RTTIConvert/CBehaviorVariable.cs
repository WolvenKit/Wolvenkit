using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorVariable : CBaseBehaviorVariable
	{
		[RED("value")] 		public CFloat Value { get; set;}

		[RED("defaultValue")] 		public CFloat DefaultValue { get; set;}

		[RED("minValue")] 		public CFloat MinValue { get; set;}

		[RED("maxValue")] 		public CFloat MaxValue { get; set;}

		[RED("isModifiableByEffect")] 		public CBool IsModifiableByEffect { get; set;}

		[RED("shouldBeSyncedBetweenGraphs")] 		public CBool ShouldBeSyncedBetweenGraphs { get; set;}

		public CBehaviorVariable(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorVariable(cr2w);

	}
}