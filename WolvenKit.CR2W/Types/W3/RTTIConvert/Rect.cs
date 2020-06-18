using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class Rect : CVariable
	{
		[RED("m_left")] 		public CInt32 M_left { get; set;}

		[RED("m_top")] 		public CInt32 M_top { get; set;}

		[RED("m_right")] 		public CInt32 M_right { get; set;}

		[RED("m_bottom")] 		public CInt32 M_bottom { get; set;}

		public Rect(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new Rect(cr2w);

	}
}