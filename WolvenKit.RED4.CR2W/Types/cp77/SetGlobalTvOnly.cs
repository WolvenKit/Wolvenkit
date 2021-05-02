using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetGlobalTvOnly : redEvent
	{
		private CBool _isGlobalTvOnly;

		[Ordinal(0)] 
		[RED("isGlobalTvOnly")] 
		public CBool IsGlobalTvOnly
		{
			get => GetProperty(ref _isGlobalTvOnly);
			set => SetProperty(ref _isGlobalTvOnly, value);
		}

		public SetGlobalTvOnly(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
