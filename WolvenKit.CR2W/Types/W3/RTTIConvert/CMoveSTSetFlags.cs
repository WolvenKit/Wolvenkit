using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTSetFlags : IMoveSteeringTask
	{
		[RED("movementFlags")] 		public CEnum<EMovementFlags> MovementFlags { get; set;}

		[RED("bitOperation")] 		public CEnum<EBitOperation> BitOperation { get; set;}

		public CMoveSTSetFlags(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CMoveSTSetFlags(cr2w);

	}
}