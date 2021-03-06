using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseAnim : animAnimNode_SkAnim
	{
		[Ordinal(30)] [RED("phase")] public CName Phase { get; set; }

		public animAnimNode_SkPhaseAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
