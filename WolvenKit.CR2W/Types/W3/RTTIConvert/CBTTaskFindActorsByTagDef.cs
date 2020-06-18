using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFindActorsByTagDef : IBehTreeConditionalTaskDefinition
	{
		[RED("tag")] 		public CName Tag { get; set;}

		[RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[RED("numberOfActors")] 		public CInt32 NumberOfActors { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		[RED("onlyLiveActors")] 		public CBool OnlyLiveActors { get; set;}

		public CBTTaskFindActorsByTagDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskFindActorsByTagDef(cr2w);

	}
}