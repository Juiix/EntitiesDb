
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3, T4>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3, T4, T5>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		return reference.Archetype.Has(in ids);
	}
	/// <inheritdoc cref="Has{T0}(Entity)"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity)
	{
		ref var reference = ref GetEntity(entity);
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		return reference.Archetype.Has(in ids);
	}
}