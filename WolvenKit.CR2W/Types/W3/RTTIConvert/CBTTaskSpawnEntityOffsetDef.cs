using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnEntityOffsetDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[RED("resourceName")] 		public CBehTreeValCName ResourceName { get; set;}

		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("positionOffset")] 		public Vector PositionOffset { get; set;}

		[RED("completeAfterSpawn")] 		public CBool CompleteAfterSpawn { get; set;}

		[RED("spawnEntityOnAnimEvent")] 		public CBool SpawnEntityOnAnimEvent { get; set;}

		[RED("spawnAnimEventName")] 		public CName SpawnAnimEventName { get; set;}

		[RED("addEntityToSummonerComponent")] 		public CBool AddEntityToSummonerComponent { get; set;}

		[RED("addTagToEntity")] 		public CBool AddTagToEntity { get; set;}

		[RED("tagToAdd")] 		public CName TagToAdd { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("destroyTaggedEntitiesOnDeactivate")] 		public CBool DestroyTaggedEntitiesOnDeactivate { get; set;}

		[RED("destroyEntityAfter")] 		public CFloat DestroyEntityAfter { get; set;}

		[RED("spawnEntityAtNode")] 		public CBool SpawnEntityAtNode { get; set;}

		[RED("tagToFindNode")] 		public CName TagToFindNode { get; set;}

		public CBTTaskSpawnEntityOffsetDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskSpawnEntityOffsetDef(cr2w);

	}
}