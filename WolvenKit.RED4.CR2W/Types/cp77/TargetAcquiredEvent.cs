using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetAcquiredEvent : redEvent
	{
		private wCHandle<ScriptedPuppet> _target;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<ScriptedPuppet> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		public TargetAcquiredEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
