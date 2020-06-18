using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWorldMapImageInfo : CVariable
	{
		[RED("cropRect")] 		public Rect CropRect { get; set;}

		[RED("baseFileName")] 		public CString BaseFileName { get; set;}

		[RED("height")] 		public CInt32 Height { get; set;}

		[RED("width")] 		public CInt32 Width { get; set;}

		public SWorldMapImageInfo(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SWorldMapImageInfo(cr2w);

	}
}