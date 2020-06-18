using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTriggerAreaComponent : CAreaComponent
	{
		[RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[RED("includedChannels")] 		public ETriggerChannel IncludedChannels { get; set;}

		[RED("excludedChannels")] 		public ETriggerChannel ExcludedChannels { get; set;}

		[RED("triggerPriority")] 		public CUInt32 TriggerPriority { get; set;}

		[RED("enableCCD")] 		public CBool EnableCCD { get; set;}

		public CTriggerAreaComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CTriggerAreaComponent(cr2w);

	}
}