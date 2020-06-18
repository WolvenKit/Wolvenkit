using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SR4PlayerTargetingConsts : CVariable
	{
		[RED("softLockDistance")] 		public CFloat SoftLockDistance { get; set;}

		[RED("softLockFrameSize")] 		public CFloat SoftLockFrameSize { get; set;}

		public SR4PlayerTargetingConsts(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SR4PlayerTargetingConsts(cr2w);

	}
}