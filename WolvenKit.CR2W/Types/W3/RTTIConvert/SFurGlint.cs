using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurGlint : CVariable
	{
		[RED("glintStrength")] 		public CFloat GlintStrength { get; set;}

		[RED("glintCount")] 		public CFloat GlintCount { get; set;}

		[RED("glintExponent")] 		public CFloat GlintExponent { get; set;}

		public SFurGlint(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFurGlint(cr2w);

	}
}