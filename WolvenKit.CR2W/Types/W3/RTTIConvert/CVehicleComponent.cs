using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CVehicleComponent : CComponent
	{
		[RED("user")] 		public CHandle<CActor> User { get; set;}

		[RED("slots", 2,0)] 		public CArray<Vector> Slots { get; set;}

		[RED("mainStateName")] 		public CName MainStateName { get; set;}

		[RED("passengerStateName")] 		public CName PassengerStateName { get; set;}

		public CVehicleComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CVehicleComponent(cr2w);

	}
}