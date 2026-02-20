
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1>(Entity entity, in T0? t0Component, in T1? t1Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1>(int entityId, in T0? t0Component, in T1? t1Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(entityReference.Slot.Index) = t12Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(entityReference.Slot.Index) = t12Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(entityReference.Slot.Index) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) chunk.Write<T13>(entityReference.Slot.Index) = t13Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(entityReference.Slot.Index) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) chunk.Write<T13>(entityReference.Slot.Index) = t13Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(entityReference.Slot.Index) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) chunk.Write<T13>(entityReference.Slot.Index) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) chunk.Write<T14>(entityReference.Slot.Index) = t14Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(entityReference.Slot.Index) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) chunk.Write<T13>(entityReference.Slot.Index) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) chunk.Write<T14>(entityReference.Slot.Index) = t14Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(Entity, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(entityReference.Slot.Index) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) chunk.Write<T13>(entityReference.Slot.Index) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) chunk.Write<T14>(entityReference.Slot.Index) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) chunk.Write<T15>(entityReference.Slot.Index) = t15Component;
	}
	/// <inheritdoc cref="AddAndRemove{T0}(int, in T0, in Signature)"/>
	[StructuralChange]
	[ChunkChange]
	public void AddAndRemove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId, in T0? t0Component, in T1? t1Component, in T2? t2Component, in T3? t3Component, in T4? t4Component, in T5? t5Component, in T6? t6Component, in T7? t7Component, in T8? t8Component, in T9? t9Component, in T10? t10Component, in T11? t11Component, in T12? t12Component, in T13? t13Component, in T14? t14Component, in T15? t15Component, in Signature removedSignature)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature).Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
        if (!ComponentMeta<T3>.IsZeroSize) chunk.Write<T3>(entityReference.Slot.Index) = t3Component;
        if (!ComponentMeta<T4>.IsZeroSize) chunk.Write<T4>(entityReference.Slot.Index) = t4Component;
        if (!ComponentMeta<T5>.IsZeroSize) chunk.Write<T5>(entityReference.Slot.Index) = t5Component;
        if (!ComponentMeta<T6>.IsZeroSize) chunk.Write<T6>(entityReference.Slot.Index) = t6Component;
        if (!ComponentMeta<T7>.IsZeroSize) chunk.Write<T7>(entityReference.Slot.Index) = t7Component;
        if (!ComponentMeta<T8>.IsZeroSize) chunk.Write<T8>(entityReference.Slot.Index) = t8Component;
        if (!ComponentMeta<T9>.IsZeroSize) chunk.Write<T9>(entityReference.Slot.Index) = t9Component;
        if (!ComponentMeta<T10>.IsZeroSize) chunk.Write<T10>(entityReference.Slot.Index) = t10Component;
        if (!ComponentMeta<T11>.IsZeroSize) chunk.Write<T11>(entityReference.Slot.Index) = t11Component;
        if (!ComponentMeta<T12>.IsZeroSize) chunk.Write<T12>(entityReference.Slot.Index) = t12Component;
        if (!ComponentMeta<T13>.IsZeroSize) chunk.Write<T13>(entityReference.Slot.Index) = t13Component;
        if (!ComponentMeta<T14>.IsZeroSize) chunk.Write<T14>(entityReference.Slot.Index) = t14Component;
        if (!ComponentMeta<T15>.IsZeroSize) chunk.Write<T15>(entityReference.Slot.Index) = t15Component;
	}
}