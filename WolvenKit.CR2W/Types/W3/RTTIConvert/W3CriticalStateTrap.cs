using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CriticalStateTrap : CInteractiveEntity
	{
		[RED("effectOnSpawn")] 		public CName EffectOnSpawn { get; set;}

		[RED("effectToPlayOnActivation")] 		public CName EffectToPlayOnActivation { get; set;}

		[RED("durationFrom")] 		public CInt32 DurationFrom { get; set;}

		[RED("durationTo")] 		public CInt32 DurationTo { get; set;}

		public W3CriticalStateTrap(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3CriticalStateTrap(cr2w);

	}
}