
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entity.Id, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
}