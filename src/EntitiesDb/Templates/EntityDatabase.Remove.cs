
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1>(Entity entity)
	{
		var removedSignature = Component<T0, T1>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1>(int entityId)
	{
		var removedSignature = Component<T0, T1>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(Entity)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		ref var entityReference = ref GetEntity(entity);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entity.Id, ref entityReference, srcArchetype, dstArchetype);
	}
	/// <inheritdoc cref="Remove{T0}(int)"/>
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId)
	{
		var removedSignature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		ref var entityReference = ref GetEntity(entityId);

		// check already added
		var srcArchetype = entityReference.Archetype;
        var dstSignature = srcArchetype.Signature.AndNot(in removedSignature);
		var dstArchetype = Archetypes.GetOrCreateArchetype(dstSignature);

		// move entity to new archetype
		MoveEntity(entityId, ref entityReference, srcArchetype, dstArchetype);
	}
}