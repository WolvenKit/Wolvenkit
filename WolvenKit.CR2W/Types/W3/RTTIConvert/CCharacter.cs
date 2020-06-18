using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCharacter : CObject
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("guid")] 		public CGUID Guid { get; set;}

		[RED("parentCharacter")] 		public CPtr<CCharacter> ParentCharacter { get; set;}

		[RED("i_voiceTag")] 		public CName I_voiceTag { get; set;}

		[RED("tags")] 		public TagList Tags { get; set;}

		[RED("entityTemplate")] 		public CSoft<CEntityTemplate> EntityTemplate { get; set;}

		public CCharacter(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCharacter(cr2w);

	}
}