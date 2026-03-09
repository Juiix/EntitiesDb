
namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1>() => Has<T0>() && Has<T1>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1>() => Has<T0>() || Has<T1>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2>() => Has<T0>() && Has<T1>() && Has<T2>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2>() => Has<T0>() || Has<T1>() || Has<T2>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3, T4>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>() && Has<T4>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3, T4>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>() || Has<T4>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3, T4, T5>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>() && Has<T4>() && Has<T5>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3, T4, T5>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>() || Has<T4>() || Has<T5>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3, T4, T5, T6>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>() && Has<T4>() && Has<T5>() && Has<T6>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3, T4, T5, T6>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>() || Has<T4>() || Has<T5>() || Has<T6>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3, T4, T5, T6, T7>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>() && Has<T4>() && Has<T5>() && Has<T6>() && Has<T7>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>() || Has<T4>() || Has<T5>() || Has<T6>() || Has<T7>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>() && Has<T4>() && Has<T5>() && Has<T6>() && Has<T7>() && Has<T8>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>() || Has<T4>() || Has<T5>() || Has<T6>() || Has<T7>() || Has<T8>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>() && Has<T4>() && Has<T5>() && Has<T6>() && Has<T7>() && Has<T8>() && Has<T9>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>() || Has<T4>() || Has<T5>() || Has<T6>() || Has<T7>() || Has<T8>() || Has<T9>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>() && Has<T4>() && Has<T5>() && Has<T6>() && Has<T7>() && Has<T8>() && Has<T9>() && Has<T10>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>() || Has<T4>() || Has<T5>() || Has<T6>() || Has<T7>() || Has<T8>() || Has<T9>() || Has<T10>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>() && Has<T4>() && Has<T5>() && Has<T6>() && Has<T7>() && Has<T8>() && Has<T9>() && Has<T10>() && Has<T11>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>() || Has<T4>() || Has<T5>() || Has<T6>() || Has<T7>() || Has<T8>() || Has<T9>() || Has<T10>() || Has<T11>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>() && Has<T4>() && Has<T5>() && Has<T6>() && Has<T7>() && Has<T8>() && Has<T9>() && Has<T10>() && Has<T11>() && Has<T12>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>() || Has<T4>() || Has<T5>() || Has<T6>() || Has<T7>() || Has<T8>() || Has<T9>() || Has<T10>() || Has<T11>() || Has<T12>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>() && Has<T4>() && Has<T5>() && Has<T6>() && Has<T7>() && Has<T8>() && Has<T9>() && Has<T10>() && Has<T11>() && Has<T12>() && Has<T13>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>() || Has<T4>() || Has<T5>() || Has<T6>() || Has<T7>() || Has<T8>() || Has<T9>() || Has<T10>() || Has<T11>() || Has<T12>() || Has<T13>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>() && Has<T4>() && Has<T5>() && Has<T6>() && Has<T7>() && Has<T8>() && Has<T9>() && Has<T10>() && Has<T11>() && Has<T12>() && Has<T13>() && Has<T14>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>() || Has<T4>() || Has<T5>() || Has<T6>() || Has<T7>() || Has<T8>() || Has<T9>() || Has<T10>() || Has<T11>() || Has<T12>() || Has<T13>() || Has<T14>();
	/// <inheritdoc cref="Has{T0}()"/>
	public readonly bool Has<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>() => Has<T0>() && Has<T1>() && Has<T2>() && Has<T3>() && Has<T4>() && Has<T5>() && Has<T6>() && Has<T7>() && Has<T8>() && Has<T9>() && Has<T10>() && Has<T11>() && Has<T12>() && Has<T13>() && Has<T14>() && Has<T15>();
	/// <inheritdoc cref="HasAny{T0}()"/>
	public readonly bool HasAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>() => Has<T0>() || Has<T1>() || Has<T2>() || Has<T3>() || Has<T4>() || Has<T5>() || Has<T6>() || Has<T7>() || Has<T8>() || Has<T9>() || Has<T10>() || Has<T11>() || Has<T12>() || Has<T13>() || Has<T14>() || Has<T15>();
}
