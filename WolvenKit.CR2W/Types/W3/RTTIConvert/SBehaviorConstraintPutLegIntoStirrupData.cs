using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorConstraintPutLegIntoStirrupData : CVariable
	{
		[RED("footStoreName")] 		public CName FootStoreName { get; set;}

		[RED("stirrupStoreName")] 		public CName StirrupStoreName { get; set;}

		[RED("stirrupFinalStoreName")] 		public CName StirrupFinalStoreName { get; set;}

		[RED("ik")] 		public STwoBonesIKSolverData Ik { get; set;}

		[RED("additionalSideDirForIKMS")] 		public Vector AdditionalSideDirForIKMS { get; set;}

		public SBehaviorConstraintPutLegIntoStirrupData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SBehaviorConstraintPutLegIntoStirrupData(cr2w);

	}
}