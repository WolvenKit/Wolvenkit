using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapTripwire : W3Trap
	{
		[RED("eventOnTripped", 2,0)] 		public CArray<CHandle<IPerformableAction>> EventOnTripped { get; set;}

		[RED("maxUseCount")] 		public CInt32 MaxUseCount { get; set;}

		[RED("excludedActorsTags", 2,0)] 		public CArray<CName> ExcludedActorsTags { get; set;}

		public W3TrapTripwire(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3TrapTripwire(cr2w);

	}
}