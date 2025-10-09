
namespace EntitiesDb;

public partial class EntityDatabase
{
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1> GetBulkCreate<T0, T1>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2> GetBulkCreate<T0, T1, T2>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3> GetBulkCreate<T0, T1, T2, T3>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4> GetBulkCreate<T0, T1, T2, T3, T4>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5> GetBulkCreate<T0, T1, T2, T3, T4, T5>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(archetype, in ids);
	}
	/// <inheritdoc cref="GetBulkCreate{T0}()"/>
	public BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> GetBulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>()
	{
		var ids = ComponentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		var signature = Signature.FromIds(in ids);
		var archetype = Archetypes.GetOrCreateArchetype(in signature);
		return new BulkCreate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(archetype, in ids);
	}
}