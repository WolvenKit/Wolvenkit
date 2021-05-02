using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageDestructionResource : CResource
	{
		private CArray<CHandle<worldFoliageDestructionMapping>> _mappings;

		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<CHandle<worldFoliageDestructionMapping>> Mappings
		{
			get => GetProperty(ref _mappings);
			set => SetProperty(ref _mappings, value);
		}

		public worldFoliageDestructionResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
