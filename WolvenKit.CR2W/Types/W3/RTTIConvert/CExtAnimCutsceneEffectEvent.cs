using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimCutsceneEffectEvent : CExtAnimDurationEvent
	{
		[RED("effect")] 		public CName Effect { get; set;}

		[RED("tag")] 		public TagList Tag { get; set;}

		[RED("template")] 		public CSoft<CEntityTemplate> Template { get; set;}

		[RED("spawnPosMS")] 		public Vector SpawnPosMS { get; set;}

		[RED("spawnRotMS")] 		public EulerAngles SpawnRotMS { get; set;}

		public CExtAnimCutsceneEffectEvent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExtAnimCutsceneEffectEvent(cr2w);

	}
}