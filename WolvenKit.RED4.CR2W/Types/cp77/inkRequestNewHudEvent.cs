using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkRequestNewHudEvent : redEvent
	{
		private rRef<inkHudEntriesResource> _entriesResource;

		[Ordinal(0)] 
		[RED("entriesResource")] 
		public rRef<inkHudEntriesResource> EntriesResource
		{
			get => GetProperty(ref _entriesResource);
			set => SetProperty(ref _entriesResource, value);
		}

		public inkRequestNewHudEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
