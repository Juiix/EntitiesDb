
namespace EntitiesDb;

public partial class Archetype
{
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1>(in Ids<T0, T1> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2>(in Ids<T0, T1, T2> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3>(in Ids<T0, T1, T2, T3> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3, T4>(in Ids<T0, T1, T2, T3, T4> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value) &&
        Signature.Test(ids.T4.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3, T4, T5>(in Ids<T0, T1, T2, T3, T4, T5> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value) &&
        Signature.Test(ids.T4.Value) &&
        Signature.Test(ids.T5.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6>(in Ids<T0, T1, T2, T3, T4, T5, T6> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value) &&
        Signature.Test(ids.T4.Value) &&
        Signature.Test(ids.T5.Value) &&
        Signature.Test(ids.T6.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value) &&
        Signature.Test(ids.T4.Value) &&
        Signature.Test(ids.T5.Value) &&
        Signature.Test(ids.T6.Value) &&
        Signature.Test(ids.T7.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value) &&
        Signature.Test(ids.T4.Value) &&
        Signature.Test(ids.T5.Value) &&
        Signature.Test(ids.T6.Value) &&
        Signature.Test(ids.T7.Value) &&
        Signature.Test(ids.T8.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value) &&
        Signature.Test(ids.T4.Value) &&
        Signature.Test(ids.T5.Value) &&
        Signature.Test(ids.T6.Value) &&
        Signature.Test(ids.T7.Value) &&
        Signature.Test(ids.T8.Value) &&
        Signature.Test(ids.T9.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value) &&
        Signature.Test(ids.T4.Value) &&
        Signature.Test(ids.T5.Value) &&
        Signature.Test(ids.T6.Value) &&
        Signature.Test(ids.T7.Value) &&
        Signature.Test(ids.T8.Value) &&
        Signature.Test(ids.T9.Value) &&
        Signature.Test(ids.T10.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value) &&
        Signature.Test(ids.T4.Value) &&
        Signature.Test(ids.T5.Value) &&
        Signature.Test(ids.T6.Value) &&
        Signature.Test(ids.T7.Value) &&
        Signature.Test(ids.T8.Value) &&
        Signature.Test(ids.T9.Value) &&
        Signature.Test(ids.T10.Value) &&
        Signature.Test(ids.T11.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value) &&
        Signature.Test(ids.T4.Value) &&
        Signature.Test(ids.T5.Value) &&
        Signature.Test(ids.T6.Value) &&
        Signature.Test(ids.T7.Value) &&
        Signature.Test(ids.T8.Value) &&
        Signature.Test(ids.T9.Value) &&
        Signature.Test(ids.T10.Value) &&
        Signature.Test(ids.T11.Value) &&
        Signature.Test(ids.T12.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value) &&
        Signature.Test(ids.T4.Value) &&
        Signature.Test(ids.T5.Value) &&
        Signature.Test(ids.T6.Value) &&
        Signature.Test(ids.T7.Value) &&
        Signature.Test(ids.T8.Value) &&
        Signature.Test(ids.T9.Value) &&
        Signature.Test(ids.T10.Value) &&
        Signature.Test(ids.T11.Value) &&
        Signature.Test(ids.T12.Value) &&
        Signature.Test(ids.T13.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value) &&
        Signature.Test(ids.T4.Value) &&
        Signature.Test(ids.T5.Value) &&
        Signature.Test(ids.T6.Value) &&
        Signature.Test(ids.T7.Value) &&
        Signature.Test(ids.T8.Value) &&
        Signature.Test(ids.T9.Value) &&
        Signature.Test(ids.T10.Value) &&
        Signature.Test(ids.T11.Value) &&
        Signature.Test(ids.T12.Value) &&
        Signature.Test(ids.T13.Value) &&
        Signature.Test(ids.T14.Value)
		;
	/// <inheritdoc cref="Has{T0}(in Ids{T0})"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids) =>
		Signature.Test(ids.T0.Value) &&
        Signature.Test(ids.T1.Value) &&
        Signature.Test(ids.T2.Value) &&
        Signature.Test(ids.T3.Value) &&
        Signature.Test(ids.T4.Value) &&
        Signature.Test(ids.T5.Value) &&
        Signature.Test(ids.T6.Value) &&
        Signature.Test(ids.T7.Value) &&
        Signature.Test(ids.T8.Value) &&
        Signature.Test(ids.T9.Value) &&
        Signature.Test(ids.T10.Value) &&
        Signature.Test(ids.T11.Value) &&
        Signature.Test(ids.T12.Value) &&
        Signature.Test(ids.T13.Value) &&
        Signature.Test(ids.T14.Value) &&
        Signature.Test(ids.T15.Value)
		;
}