using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3IllusionaryObstacle : CGameplayEntity
	{
		[RED("focusAreaIntensity")] 		public CFloat FocusAreaIntensity { get; set;}

		[RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[RED("m_disappearanceEffectDuration")] 		public CFloat M_disappearanceEffectDuration { get; set;}

		[RED("m_addFactOnDispel")] 		public CString M_addFactOnDispel { get; set;}

		[RED("m_addFactOnDiscovery")] 		public CString M_addFactOnDiscovery { get; set;}

		[RED("discoveryOnelinerTag")] 		public CString DiscoveryOnelinerTag { get; set;}

		[RED("focusModeHighlight")] 		public CEnum<EFocusModeVisibility> FocusModeHighlight { get; set;}

		public W3IllusionaryObstacle(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3IllusionaryObstacle(cr2w);

	}
}