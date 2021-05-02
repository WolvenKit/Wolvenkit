using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerDeathAnimation : animAnimFeature
	{
		private CInt32 _animation;

		[Ordinal(0)] 
		[RED("animation")] 
		public CInt32 Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		public AnimFeature_PlayerDeathAnimation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
