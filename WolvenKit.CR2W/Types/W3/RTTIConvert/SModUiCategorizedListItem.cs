using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SModUiCategorizedListItem : CVariable
	{
		[RED("id")] 		public CString Id { get; set;}

		[RED("caption")] 		public CString Caption { get; set;}

		[RED("cat1")] 		public CString Cat1 { get; set;}

		[RED("cat2")] 		public CString Cat2 { get; set;}

		[RED("cat3")] 		public CString Cat3 { get; set;}

		[RED("isWildcardMiss")] 		public CBool IsWildcardMiss { get; set;}

		public SModUiCategorizedListItem(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SModUiCategorizedListItem(cr2w);

	}
}