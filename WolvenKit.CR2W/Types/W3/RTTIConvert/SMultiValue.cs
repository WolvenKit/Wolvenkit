using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMultiValue : CVariable
	{
		[RED("floats", 2,0)] 		public CArray<CFloat> Floats { get; set;}

		[RED("bools", 2,0)] 		public CArray<CBool> Bools { get; set;}

		[RED("enums", 2,0)] 		public CArray<SEnumVariant> Enums { get; set;}

		[RED("names", 2,0)] 		public CArray<CName> Names { get; set;}

		public SMultiValue(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SMultiValue(cr2w);

	}
}