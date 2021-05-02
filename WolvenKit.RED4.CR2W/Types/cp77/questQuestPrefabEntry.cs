using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questQuestPrefabEntry : CVariable
	{
		private NodeRef _prefabNodeRef;

		[Ordinal(0)] 
		[RED("prefabNodeRef")] 
		public NodeRef PrefabNodeRef
		{
			get => GetProperty(ref _prefabNodeRef);
			set => SetProperty(ref _prefabNodeRef, value);
		}

		public questQuestPrefabEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
