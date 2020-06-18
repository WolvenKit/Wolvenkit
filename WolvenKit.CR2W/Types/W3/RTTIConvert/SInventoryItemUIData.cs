using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SInventoryItemUIData : CVariable
	{
		[RED("gridPosition")] 		public CInt32 GridPosition { get; set;}

		[RED("gridSize")] 		public CInt32 GridSize { get; set;}

		[RED("isNew")] 		public CBool IsNew { get; set;}

		public SInventoryItemUIData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SInventoryItemUIData(cr2w);

	}
}