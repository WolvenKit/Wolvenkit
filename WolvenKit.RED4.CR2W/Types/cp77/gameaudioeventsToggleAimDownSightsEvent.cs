using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsToggleAimDownSightsEvent : redEvent
	{
		private CBool _toggleOn;

		[Ordinal(0)] 
		[RED("toggleOn")] 
		public CBool ToggleOn
		{
			get => GetProperty(ref _toggleOn);
			set => SetProperty(ref _toggleOn, value);
		}

		public gameaudioeventsToggleAimDownSightsEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
