using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIVehicleTaskAbstract : AIbehaviortaskScript
	{

		public AIVehicleTaskAbstract(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
