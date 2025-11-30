
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1> GetBulkCreate<T0, T1>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2> GetBulkCreate<T0, T1, T2>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3> GetBulkCreate<T0, T1, T2, T3>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4> GetBulkCreate<T0, T1, T2, T3, T4>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3, T4>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5> GetBulkCreate<T0, T1, T2, T3, T4, T5>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3, T4, T5>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(archetype, in offsets);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		var offsets = archetype.GetOffsets(in ids);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(archetype, in offsets);
	}
}