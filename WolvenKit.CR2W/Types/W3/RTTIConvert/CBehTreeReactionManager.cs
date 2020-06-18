using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeReactionManager : CObject
	{
		[RED("reactionScens", 2,0)] 		public CArray<CHandle<CReactionScene>> ReactionScens { get; set;}

		[RED("reactionEvents", 2,0)] 		public CArray<CPtr<CBehTreeReactionEventData>> ReactionEvents { get; set;}

		public CBehTreeReactionManager(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeReactionManager(cr2w);

	}
}