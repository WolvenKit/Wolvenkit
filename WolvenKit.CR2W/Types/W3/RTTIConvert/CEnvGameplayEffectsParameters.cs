using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvGameplayEffectsParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("catEffectBrightnessMultiply")] 		public SSimpleCurve CatEffectBrightnessMultiply { get; set;}

		[RED("behaviorAnimationMultiplier")] 		public SSimpleCurve BehaviorAnimationMultiplier { get; set;}

		[RED("specularityMultiplier")] 		public SSimpleCurve SpecularityMultiplier { get; set;}

		[RED("glossinessMultiplier")] 		public SSimpleCurve GlossinessMultiplier { get; set;}

		public CEnvGameplayEffectsParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEnvGameplayEffectsParameters(cr2w);

	}
}