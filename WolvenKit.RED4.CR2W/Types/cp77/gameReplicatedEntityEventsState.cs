using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedEntityEventsState : CVariable
	{
		private CArray<gameReplicatedEntityEvent> _items;
		private netTime _lastAppliedActionsTime;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<gameReplicatedEntityEvent> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		[Ordinal(1)] 
		[RED("lastAppliedActionsTime")] 
		public netTime LastAppliedActionsTime
		{
			get => GetProperty(ref _lastAppliedActionsTime);
			set => SetProperty(ref _lastAppliedActionsTime, value);
		}

		public gameReplicatedEntityEventsState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
