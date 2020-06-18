using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAreaMapPinInfo : CVariable
	{
		[RED("areaType")] 		public CInt32 AreaType { get; set;}

		[RED("position")] 		public Vector Position { get; set;}

		[RED("worldPath")] 		public CString WorldPath { get; set;}

		[RED("requiredChunk")] 		public CName RequiredChunk { get; set;}

		[RED("localisationName")] 		public CName LocalisationName { get; set;}

		[RED("localisationDescription")] 		public CName LocalisationDescription { get; set;}

		public SAreaMapPinInfo(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SAreaMapPinInfo(cr2w);

	}
}