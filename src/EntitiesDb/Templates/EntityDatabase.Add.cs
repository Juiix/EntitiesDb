
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1>(Entity entity, in T0? t0Component = default, in T1? t1Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);

		// set component value
		ref readonly var chunk = ref dstArchetype.GetChunk(entityReference.Slot.ChunkIndex);
		if (!ComponentMeta<T0>.IsZeroSize) chunk.Write<T0>(entityReference.Slot.Index) = t0Component;
        if (!ComponentMeta<T1>.IsZeroSize) chunk.Write<T1>(entityReference.Slot.Index) = t1Component;
        if (!ComponentMeta<T2>.IsZeroSize) chunk.Write<T2>(entityReference.Slot.Index) = t2Component;
	}
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
	/// <inheritdoc cref="Add{T0}(Entity, in T0)"/>
	[StructuralChange]
	[ChunkChange]
	public void Add<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
		var addedSignature = ComponentSingle<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		ref var entityReference = ref GetEntity(entity);

		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.Or(in addedSignature);
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
}