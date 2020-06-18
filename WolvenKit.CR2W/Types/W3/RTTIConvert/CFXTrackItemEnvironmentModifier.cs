using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemEnvironmentModifier : CFXTrackItem
	{
		[RED("lightDirection")] 		public Vector LightDirection { get; set;}

		[RED("sunLightDiffuse")] 		public CColor SunLightDiffuse { get; set;}

		[RED("sunLightBrightness")] 		public CFloat SunLightBrightness { get; set;}

		[RED("ambientOverride")] 		public CColor AmbientOverride { get; set;}

		[RED("ambientOverrideBrightness")] 		public CFloat AmbientOverrideBrightness { get; set;}

		[RED("overrideBalancing")] 		public CBool OverrideBalancing { get; set;}

		[RED("parametricBalanceLow")] 		public CColor ParametricBalanceLow { get; set;}

		[RED("parametricBalanceLowScale")] 		public CFloat ParametricBalanceLowScale { get; set;}

		[RED("parametricBalanceMid")] 		public CColor ParametricBalanceMid { get; set;}

		[RED("parametricBalanceMidScale")] 		public CFloat ParametricBalanceMidScale { get; set;}

		[RED("parametricBalanceHigh")] 		public CColor ParametricBalanceHigh { get; set;}

		[RED("parametricBalanceHighScale")] 		public CFloat ParametricBalanceHighScale { get; set;}

		public CFXTrackItemEnvironmentModifier(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CFXTrackItemEnvironmentModifier(cr2w);

	}
}