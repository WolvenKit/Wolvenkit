using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeDecoratorLeadFormationDefinition : CBehTreeDecoratorSteeringGraphDefinition
	{
		[RED("formation")] 		public CBehTreeValFormation Formation { get; set;}

		[RED("reshapeOnMoveAction")] 		public CBehTreeValBool ReshapeOnMoveAction { get; set;}

		public CBehTreeNodeDecoratorLeadFormationDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeDecoratorLeadFormationDefinition(cr2w);

	}
}