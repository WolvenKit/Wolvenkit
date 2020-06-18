using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeAtomicSailorMoveToPathDefinition : CBehTreeNodeAtomicActionDefinition
	{
		[RED("boatTag")] 		public CBehTreeValCName BoatTag { get; set;}

		[RED("pathTag")] 		public CBehTreeValCName PathTag { get; set;}

		[RED("upThePath")] 		public CBehTreeValBool UpThePath { get; set;}

		[RED("startFromBeginning")] 		public CBehTreeValBool StartFromBeginning { get; set;}

		public CBehTreeNodeAtomicSailorMoveToPathDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeAtomicSailorMoveToPathDefinition(cr2w);

	}
}