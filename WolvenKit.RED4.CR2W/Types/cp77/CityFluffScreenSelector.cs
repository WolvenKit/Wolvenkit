using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CityFluffScreenSelector : LCDScreenSelector
	{
		private TweakDBID _recordID;

		[Ordinal(4)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		public CityFluffScreenSelector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
