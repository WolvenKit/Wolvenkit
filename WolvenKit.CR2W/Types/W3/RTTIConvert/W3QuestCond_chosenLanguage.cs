using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_chosenLanguage : CQuestScriptedCondition
	{
		[RED("ChoosenTextLanguage")] 		public CEnum<ECheckedLanguage> ChoosenTextLanguage { get; set;}

		[RED("ChoosenSpeechLanguage")] 		public CEnum<ECheckedLanguage> ChoosenSpeechLanguage { get; set;}

		[RED("checkFor")] 		public CEnum<ELanguageCheckType> CheckFor { get; set;}

		public W3QuestCond_chosenLanguage(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3QuestCond_chosenLanguage(cr2w);

	}
}