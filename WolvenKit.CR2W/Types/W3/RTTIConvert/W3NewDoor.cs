using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3NewDoor : W3LockableEntity
	{
		[RED("openAngle")] 		public CFloat OpenAngle { get; set;}

		[RED("initiallyOpened")] 		public CBool InitiallyOpened { get; set;}

		[RED("factOnPlayerDoorOpen")] 		public CName FactOnPlayerDoorOpen { get; set;}

		[RED("openedByHorse")] 		public CBool OpenedByHorse { get; set;}

		public W3NewDoor(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3NewDoor(cr2w);

	}
}