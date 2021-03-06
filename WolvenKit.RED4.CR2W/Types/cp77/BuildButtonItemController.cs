using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BuildButtonItemController : inkButtonDpadSupportedController
	{
		private CEnum<gamedataBuildType> _associatedBuild;

		[Ordinal(26)] 
		[RED("associatedBuild")] 
		public CEnum<gamedataBuildType> AssociatedBuild
		{
			get => GetProperty(ref _associatedBuild);
			set => SetProperty(ref _associatedBuild, value);
		}

		public BuildButtonItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
