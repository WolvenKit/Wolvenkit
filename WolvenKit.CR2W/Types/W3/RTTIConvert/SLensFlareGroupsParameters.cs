using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLensFlareGroupsParameters : CVariable
	{
		[RED("default")] 		public SLensFlareParameters Default { get; set;}

		[RED("sun")] 		public SLensFlareParameters Sun { get; set;}

		[RED("moon")] 		public SLensFlareParameters Moon { get; set;}

		[RED("custom0")] 		public SLensFlareParameters Custom0 { get; set;}

		[RED("custom1")] 		public SLensFlareParameters Custom1 { get; set;}

		[RED("custom2")] 		public SLensFlareParameters Custom2 { get; set;}

		[RED("custom3")] 		public SLensFlareParameters Custom3 { get; set;}

		[RED("custom4")] 		public SLensFlareParameters Custom4 { get; set;}

		[RED("custom5")] 		public SLensFlareParameters Custom5 { get; set;}

		public SLensFlareGroupsParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SLensFlareGroupsParameters(cr2w);

	}
}