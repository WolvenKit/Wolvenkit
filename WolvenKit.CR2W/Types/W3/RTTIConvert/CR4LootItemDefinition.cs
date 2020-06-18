using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4LootItemDefinition : CR4LootDefinitionBase
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("chance")] 		public CFloat Chance { get; set;}

		public CR4LootItemDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CR4LootItemDefinition(cr2w);

	}
}