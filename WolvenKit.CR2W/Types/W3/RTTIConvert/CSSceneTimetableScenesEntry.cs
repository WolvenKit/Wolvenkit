using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSSceneTimetableScenesEntry : CVariable
	{
		[RED("storyScene")] 		public CHandle<CStoryScene> StoryScene { get; set;}

		[RED("sceneInputSection")] 		public CString SceneInputSection { get; set;}

		[RED("cooldownTime")] 		public CFloat CooldownTime { get; set;}

		[RED("weight")] 		public CFloat Weight { get; set;}

		[RED("priority")] 		public CEnum<EArbitratorPriorities> Priority { get; set;}

		[RED("forceMode")] 		public CEnum<EStorySceneForcingMode> ForceMode { get; set;}

		public CSSceneTimetableScenesEntry(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSSceneTimetableScenesEntry(cr2w);

	}
}