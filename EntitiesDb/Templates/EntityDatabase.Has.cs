
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3, T4>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3, T4, T5>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(int)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int entityId)
	{
		ref var reference = ref GetEntity(entityId);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		return reference.Archetype.Has(in ids);
	}
}