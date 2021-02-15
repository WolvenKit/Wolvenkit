using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameVehicleCurvesLibrary : entEntity
	{
		[Ordinal(2)] [RED("curves")] public CArray<rRef<gameVehicleCurveSet>> Curves { get; set; }
		[Ordinal(3)] [RED("commonCurves")] public CArray<rRef<gameVehicleCommonCurveSet>> CommonCurves { get; set; }
		[Ordinal(4)] [RED("bikeCurves")] public CArray<rRef<vehicleBikeCurveSet>> BikeCurves { get; set; }

		public gameVehicleCurvesLibrary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
