using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeInitializerGuardArea : ISpawnTreeInitializerGuardAreaBase
	{
		[RED("guardAreaTag")] 		public CName GuardAreaTag { get; set;}

		[RED("pursuitAreaTag")] 		public CName PursuitAreaTag { get; set;}

		[RED("findAreasInEncounter")] 		public CBool FindAreasInEncounter { get; set;}

		public CSpawnTreeInitializerGuardArea(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSpawnTreeInitializerGuardArea(cr2w);

	}
}