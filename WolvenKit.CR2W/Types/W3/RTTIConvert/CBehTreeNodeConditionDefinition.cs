using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeConditionDefinition : IBehTreeNodeDecoratorDefinition
	{
		[RED("forwardAvailability")] 		public CBool ForwardAvailability { get; set;}

		[RED("forwardTestIfNotAvailable")] 		public CBool ForwardTestIfNotAvailable { get; set;}

		[RED("invertAvailability")] 		public CBool InvertAvailability { get; set;}

		[RED("skipIfActive")] 		public CBool SkipIfActive { get; set;}

		public CBehTreeNodeConditionDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeConditionDefinition(cr2w);

	}
}