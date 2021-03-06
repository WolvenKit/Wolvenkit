using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResolveSensorDeviceBehaviour : redEvent
	{
		private CInt32 _iteration;

		[Ordinal(0)] 
		[RED("iteration")] 
		public CInt32 Iteration
		{
			get => GetProperty(ref _iteration);
			set => SetProperty(ref _iteration, value);
		}

		public ResolveSensorDeviceBehaviour(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
