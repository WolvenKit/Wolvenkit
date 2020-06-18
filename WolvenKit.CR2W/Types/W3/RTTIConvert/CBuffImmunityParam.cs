using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBuffImmunityParam : CGameplayEntityParam
	{
		[RED("immunityTo", 2,0)] 		public CArray<CInt32> ImmunityTo { get; set;}

		[RED("flags")] 		public CEnum<EImmunityFlags> Flags { get; set;}

		public CBuffImmunityParam(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBuffImmunityParam(cr2w);

	}
}