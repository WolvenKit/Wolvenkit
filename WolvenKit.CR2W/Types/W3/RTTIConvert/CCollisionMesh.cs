using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCollisionMesh : CResource
	{
		[RED("shapes", 2,0)] 		public CArray<CPtr<ICollisionShape>> Shapes { get; set;}

		[RED("occlusionAttenuation")] 		public CFloat OcclusionAttenuation { get; set;}

		[RED("occlusionDiagonalLimit")] 		public CFloat OcclusionDiagonalLimit { get; set;}

		[RED("swimmingRotationAxis")] 		public CInt32 SwimmingRotationAxis { get; set;}

		public CCollisionMesh(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCollisionMesh(cr2w);

	}
}