using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemParameterFloat : CFXTrackItemCurveBase
	{
		[RED("parameterName")] 		public CName ParameterName { get; set;}

		[RED("restoreAtEnd")] 		public CBool RestoreAtEnd { get; set;}

		[RED("allComponents")] 		public CBool AllComponents { get; set;}

		public CFXTrackItemParameterFloat(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CFXTrackItemParameterFloat(cr2w);

	}
}