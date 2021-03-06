using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDefaultLoadingScreenLogicController : inkILoadingLogicController
	{
		private inkWidgetReference _progressBarRoot;
		private wCHandle<LoadingScreenProgressBarController> _progressBarController;

		[Ordinal(1)] 
		[RED("progressBarRoot")] 
		public inkWidgetReference ProgressBarRoot
		{
			get => GetProperty(ref _progressBarRoot);
			set => SetProperty(ref _progressBarRoot, value);
		}

		[Ordinal(2)] 
		[RED("progressBarController")] 
		public wCHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get => GetProperty(ref _progressBarController);
			set => SetProperty(ref _progressBarController, value);
		}

		public inkDefaultLoadingScreenLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
