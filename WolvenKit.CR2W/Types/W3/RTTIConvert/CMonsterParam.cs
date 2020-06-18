using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMonsterParam : CGameplayEntityParam
	{
		[RED("isTeleporting")] 		public CBool IsTeleporting { get; set;}

		[RED("canBeTargeted")] 		public CBool CanBeTargeted { get; set;}

		[RED("canBeHitByFists")] 		public CBool CanBeHitByFists { get; set;}

		[RED("canBeStrafed")] 		public CBool CanBeStrafed { get; set;}

		[RED("monsterCategory")] 		public CInt32 MonsterCategory { get; set;}

		[RED("soundMonsterName")] 		public CName SoundMonsterName { get; set;}

		public CMonsterParam(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CMonsterParam(cr2w);

	}
}