using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidResourceHandler : CVariable
	{
		private scnRidResourceId _id;
		private rRef<scnRidResource> _ridResource;

		[Ordinal(0)] 
		[RED("id")] 
		public scnRidResourceId Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("ridResource")] 
		public rRef<scnRidResource> RidResource
		{
			get => GetProperty(ref _ridResource);
			set => SetProperty(ref _ridResource, value);
		}

		public scnRidResourceHandler(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
