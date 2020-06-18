using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGrassCellMask : CVariable
	{
		[RED("srtFileName")] 		public CString SrtFileName { get; set;}

		[RED("firstRow")] 		public CInt32 FirstRow { get; set;}

		[RED("lastRow")] 		public CInt32 LastRow { get; set;}

		[RED("firstCol")] 		public CInt32 FirstCol { get; set;}

		[RED("lastCol")] 		public CInt32 LastCol { get; set;}

		[RED("cellSize")] 		public CFloat CellSize { get; set;}

		[RED("bitmap")] 		public LongBitField Bitmap { get; set;}

		public CGrassCellMask(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CGrassCellMask(cr2w);

	}
}