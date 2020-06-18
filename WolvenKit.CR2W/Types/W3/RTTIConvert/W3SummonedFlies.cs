using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SummonedFlies : CGameplayEntity
	{
		[RED("fleeDuration")] 		public CFloat FleeDuration { get; set;}

		[RED("lookForTarget")] 		public CBool LookForTarget { get; set;}

		[RED("detectionDistance")] 		public CFloat DetectionDistance { get; set;}

		[RED("pursueDistance")] 		public CFloat PursueDistance { get; set;}

		[RED("ignoreTag")] 		public CName IgnoreTag { get; set;}

		public W3SummonedFlies(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3SummonedFlies(cr2w);

	}
}