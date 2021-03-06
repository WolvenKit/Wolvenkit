using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitDamageOverTimePrereq : GenericHitPrereq
	{
		private CEnum<gamedataStatusEffectType> _dotType;

		[Ordinal(5)] 
		[RED("dotType")] 
		public CEnum<gamedataStatusEffectType> DotType
		{
			get => GetProperty(ref _dotType);
			set => SetProperty(ref _dotType, value);
		}

		public HitDamageOverTimePrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
