using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IsPlayerReachablePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("invert")] public CBool Invert { get; set; }
		[Ordinal(1)] [RED("checkRMA")] public CBool CheckRMA { get; set; }

		public IsPlayerReachablePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
