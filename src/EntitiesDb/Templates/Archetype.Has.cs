
namespace EntitiesDb;

public partial class Archetype
{
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1>() => Signature.HasAll(in Component<T0, T1>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1>() => Signature.HasAny(in Component<T0, T1>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2>() => Signature.HasAll(in Component<T0, T1, T2>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2>() => Signature.HasAny(in Component<T0, T1, T2>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3>() => Signature.HasAll(in Component<T0, T1, T2, T3>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3>() => Signature.HasAny(in Component<T0, T1, T2, T3>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3, T4>() => Signature.HasAll(in Component<T0, T1, T2, T3, T4>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3, T4>() => Signature.HasAny(in Component<T0, T1, T2, T3, T4>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3, T4, T5>() => Signature.HasAll(in Component<T0, T1, T2, T3, T4, T5>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3, T4, T5>() => Signature.HasAny(in Component<T0, T1, T2, T3, T4, T5>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6>() => Signature.HasAll(in Component<T0, T1, T2, T3, T4, T5, T6>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3, T4, T5, T6>() => Signature.HasAny(in Component<T0, T1, T2, T3, T4, T5, T6>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7>() => Signature.HasAll(in Component<T0, T1, T2, T3, T4, T5, T6, T7>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7>() => Signature.HasAny(in Component<T0, T1, T2, T3, T4, T5, T6, T7>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8>() => Signature.HasAll(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8>() => Signature.HasAny(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>() => Signature.HasAll(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>() => Signature.HasAny(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>() => Signature.HasAll(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>() => Signature.HasAny(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>() => Signature.HasAll(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>() => Signature.HasAny(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>() => Signature.HasAll(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>() => Signature.HasAny(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>() => Signature.HasAll(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>() => Signature.HasAny(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>() => Signature.HasAll(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>() => Signature.HasAny(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature);
	/// <inheritdoc cref="Has{T0}()"/>
	public bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>() => Signature.HasAll(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature);
	/// <inheritdoc cref="HasAny{T0}()"/>
	public bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>() => Signature.HasAny(in Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature);
}
