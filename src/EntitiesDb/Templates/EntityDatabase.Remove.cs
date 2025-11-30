
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId)
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
        var removedSignature = Signature.FromIds(in ids);
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
		if (!srcArchetype.Signature.HasAny(in removedSignature))
			throw srcArchetype.GetComponentNotFound(entityId, in ids);
			
		// clear buffers
        srcArchetype.Clear(in entityReference.Slot, in ids);

        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
}