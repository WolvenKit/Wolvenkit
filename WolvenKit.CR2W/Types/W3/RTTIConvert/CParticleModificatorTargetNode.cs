using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleModificatorTargetNode : IParticleModificator
	{
		[RED("forceScale")] 		public CPtr<IEvaluatorFloat> ForceScale { get; set;}

		[RED("killRadius")] 		public CPtr<IEvaluatorFloat> KillRadius { get; set;}

		[RED("maxForce")] 		public CFloat MaxForce { get; set;}

		public CParticleModificatorTargetNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CParticleModificatorTargetNode(cr2w);

	}
}