using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PostFXOnGroundComponent : CSelfUpdatingComponent
	{
		[RED("fadeInTime")] 		public CFloat FadeInTime { get; set;}

		[RED("activeTime")] 		public CFloat ActiveTime { get; set;}

		[RED("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		[RED("type")] 		public CInt32 Type { get; set;}

		[RED("updateDelay")] 		public CFloat UpdateDelay { get; set;}

		[RED("stopAtDeath")] 		public CBool StopAtDeath { get; set;}

		public W3PostFXOnGroundComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3PostFXOnGroundComponent(cr2w);

	}
}