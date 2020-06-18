using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCraftAttribute : CVariable
	{
		[RED("attributeName")] 		public CName AttributeName { get; set;}

		[RED("valAdditive")] 		public CFloat ValAdditive { get; set;}

		[RED("valMultiplicative")] 		public CFloat ValMultiplicative { get; set;}

		[RED("displayPercMul")] 		public CBool DisplayPercMul { get; set;}

		[RED("displayPercAdd")] 		public CBool DisplayPercAdd { get; set;}

		public SCraftAttribute(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SCraftAttribute(cr2w);

	}
}