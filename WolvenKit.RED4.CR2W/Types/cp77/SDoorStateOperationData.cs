using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDoorStateOperationData : CVariable
	{
		private CEnum<EDoorStatus> _state;
		private SBaseDeviceOperationData _operation;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<EDoorStatus> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		public SDoorStateOperationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
