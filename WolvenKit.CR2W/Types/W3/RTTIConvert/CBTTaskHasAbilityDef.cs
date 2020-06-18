using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskHasAbilityDef : IBehTreeTaskDefinition
	{
		[RED("abilityName")] 		public CName AbilityName { get; set;}

		[RED("behVariableName")] 		public CName BehVariableName { get; set;}

		[RED("behVariableActivateValue")] 		public CFloat BehVariableActivateValue { get; set;}

		[RED("behVariableDeactivateValue")] 		public CFloat BehVariableDeactivateValue { get; set;}

		[RED("failAnim")] 		public CBool FailAnim { get; set;}

		public CBTTaskHasAbilityDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskHasAbilityDef(cr2w);

	}
}