using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneOverridePlacementBlend : CStorySceneEventCurveBlend
	{
		[RED("actorName")] 		public CName ActorName { get; set;}

		[RED("animationStartName")] 		public CName AnimationStartName { get; set;}

		[RED("animationLoopName")] 		public CName AnimationLoopName { get; set;}

		[RED("animationStopName")] 		public CName AnimationStopName { get; set;}

		public CStorySceneOverridePlacementBlend(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneOverridePlacementBlend(cr2w);

	}
}