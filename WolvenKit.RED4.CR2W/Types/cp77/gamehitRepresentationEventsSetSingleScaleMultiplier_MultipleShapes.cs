using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsSetSingleScaleMultiplier_MultipleShapes : gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes
	{
		private CArray<CName> _shapeNames;

		[Ordinal(1)] 
		[RED("shapeNames")] 
		public CArray<CName> ShapeNames
		{
			get => GetProperty(ref _shapeNames);
			set => SetProperty(ref _shapeNames, value);
		}

		public gamehitRepresentationEventsSetSingleScaleMultiplier_MultipleShapes(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
