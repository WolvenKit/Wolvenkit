using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalPlace : CJournalContainer
	{
		[RED("name")] 		public LocalizedString Name { get; set;}

		[RED("image")] 		public CString Image { get; set;}

		[RED("active")] 		public CBool Active { get; set;}

		public CJournalPlace(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CJournalPlace(cr2w);

	}
}