using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEntityTemplateOverride : CVariable
	{
		[RED("componentName")] 		public CName ComponentName { get; set;}

		[RED("className")] 		public CName ClassName { get; set;}

		[RED("overriddenProperties", 2,0)] 		public CArray<CName> OverriddenProperties { get; set;}

		public SEntityTemplateOverride(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SEntityTemplateOverride(cr2w);

	}
}