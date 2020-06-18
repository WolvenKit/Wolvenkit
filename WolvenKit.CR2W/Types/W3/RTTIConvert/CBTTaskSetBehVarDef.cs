using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetBehVarDef : IBehTreeTaskDefinition
	{
		[RED("behVarName")] 		public CBehTreeValCName BehVarName { get; set;}

		[RED("behVarValue")] 		public CBehTreeValFloat BehVarValue { get; set;}

		[RED("inAllBehGraphs")] 		public CBool InAllBehGraphs { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("onSuccess")] 		public CBool OnSuccess { get; set;}

		public CBTTaskSetBehVarDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskSetBehVarDef(cr2w);

	}
}