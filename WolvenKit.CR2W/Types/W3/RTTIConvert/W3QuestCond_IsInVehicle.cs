using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_IsInVehicle : CQCActorScriptedCondition
	{
		[RED("vehicleType")] 		public CEnum<EVehicleType> VehicleType { get; set;}

		[RED("vehicleTag")] 		public CName VehicleTag { get; set;}

		[RED("anyVehicle")] 		public CBool AnyVehicle { get; set;}

		public W3QuestCond_IsInVehicle(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3QuestCond_IsInVehicle(cr2w);

	}
}