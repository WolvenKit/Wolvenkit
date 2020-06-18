using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskGameplayEventListenerDef : IBehTreeTaskDefinition
	{
		[RED("gameplayEventName")] 		public CBehTreeValCName GameplayEventName { get; set;}

		[RED("validFor")] 		public CFloat ValidFor { get; set;}

		[RED("activeFor")] 		public CFloat ActiveFor { get; set;}

		[RED("clearOnEvent")] 		public CName ClearOnEvent { get; set;}

		public BTTaskGameplayEventListenerDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskGameplayEventListenerDef(cr2w);

	}
}