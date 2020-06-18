using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescProdIdlePose : CVariable
	{
		[RED("prodPoseId")] 		public CString ProdPoseId { get; set;}

		[RED("prodActorId")] 		public CString ProdActorId { get; set;}

		[RED("repoPoseId")] 		public CString RepoPoseId { get; set;}

		public SSbDescProdIdlePose(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SSbDescProdIdlePose(cr2w);

	}
}