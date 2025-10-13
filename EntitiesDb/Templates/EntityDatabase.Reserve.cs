
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3, T4>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3, T4, T5>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3, T4, T5, T6>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3, T4, T5, T6, T7>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
	/// <inheritdoc cref="Reserve{T0}(int)"/>
	public void Reserve<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityCount)
	{
		_entityMap.EnsureCapacity(EntityCount + entityCount - _recycledEntityIds.Count);
		var signature = ComponentRegistry.GetSignature<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		archetype.Reserve(entityCount);
	}
}