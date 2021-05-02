using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Root : animAnimNode_Container
	{
		private animPoseLink _outputNode;

		[Ordinal(12)] 
		[RED("outputNode")] 
		public animPoseLink OutputNode
		{
			get => GetProperty(ref _outputNode);
			set => SetProperty(ref _outputNode, value);
		}

		public animAnimNode_Root(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
