using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskEnableLookAtDef : IBehTreeTaskDefinition
	{
		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("useReactionTarget")] 		public CBool UseReactionTarget { get; set;}

		[RED("useActionTarget")] 		public CBool UseActionTarget { get; set;}

		[RED("useAsDecorator")] 		public CBool UseAsDecorator { get; set;}

		public CBTTaskEnableLookAtDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskEnableLookAtDef(cr2w);

	}
}