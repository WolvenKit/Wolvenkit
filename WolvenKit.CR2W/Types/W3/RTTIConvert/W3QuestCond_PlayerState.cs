using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_PlayerState : CQuestScriptedCondition
	{
		[RED("stateName")] 		public CName StateName { get; set;}

		[RED("playerState")] 		public CEnum<EQuestConditionPlayerState> PlayerState { get; set;}

		[RED("inverted")] 		public CBool Inverted { get; set;}

		public W3QuestCond_PlayerState(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3QuestCond_PlayerState(cr2w);

	}
}