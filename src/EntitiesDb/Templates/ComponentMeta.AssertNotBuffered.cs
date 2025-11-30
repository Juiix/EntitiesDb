
using System.Runtime.CompilerServices;

namespace EntitiesDb;

public static partial class ComponentMeta
{
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3, T4>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
        if (ComponentMeta<T4>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T4));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3, T4, T5>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
        if (ComponentMeta<T4>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T4));
        if (ComponentMeta<T5>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T5));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
        if (ComponentMeta<T4>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T4));
        if (ComponentMeta<T5>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T5));
        if (ComponentMeta<T6>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T6));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
        if (ComponentMeta<T4>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T4));
        if (ComponentMeta<T5>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T5));
        if (ComponentMeta<T6>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T6));
        if (ComponentMeta<T7>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T7));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
        if (ComponentMeta<T4>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T4));
        if (ComponentMeta<T5>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T5));
        if (ComponentMeta<T6>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T6));
        if (ComponentMeta<T7>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T7));
        if (ComponentMeta<T8>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T8));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
        if (ComponentMeta<T4>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T4));
        if (ComponentMeta<T5>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T5));
        if (ComponentMeta<T6>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T6));
        if (ComponentMeta<T7>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T7));
        if (ComponentMeta<T8>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T8));
        if (ComponentMeta<T9>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T9));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
        if (ComponentMeta<T4>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T4));
        if (ComponentMeta<T5>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T5));
        if (ComponentMeta<T6>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T6));
        if (ComponentMeta<T7>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T7));
        if (ComponentMeta<T8>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T8));
        if (ComponentMeta<T9>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T9));
        if (ComponentMeta<T10>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T10));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
        if (ComponentMeta<T4>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T4));
        if (ComponentMeta<T5>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T5));
        if (ComponentMeta<T6>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T6));
        if (ComponentMeta<T7>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T7));
        if (ComponentMeta<T8>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T8));
        if (ComponentMeta<T9>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T9));
        if (ComponentMeta<T10>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T10));
        if (ComponentMeta<T11>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T11));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
        if (ComponentMeta<T4>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T4));
        if (ComponentMeta<T5>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T5));
        if (ComponentMeta<T6>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T6));
        if (ComponentMeta<T7>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T7));
        if (ComponentMeta<T8>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T8));
        if (ComponentMeta<T9>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T9));
        if (ComponentMeta<T10>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T10));
        if (ComponentMeta<T11>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T11));
        if (ComponentMeta<T12>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T12));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
        if (ComponentMeta<T4>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T4));
        if (ComponentMeta<T5>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T5));
        if (ComponentMeta<T6>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T6));
        if (ComponentMeta<T7>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T7));
        if (ComponentMeta<T8>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T8));
        if (ComponentMeta<T9>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T9));
        if (ComponentMeta<T10>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T10));
        if (ComponentMeta<T11>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T11));
        if (ComponentMeta<T12>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T12));
        if (ComponentMeta<T13>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T13));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
        if (ComponentMeta<T4>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T4));
        if (ComponentMeta<T5>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T5));
        if (ComponentMeta<T6>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T6));
        if (ComponentMeta<T7>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T7));
        if (ComponentMeta<T8>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T8));
        if (ComponentMeta<T9>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T9));
        if (ComponentMeta<T10>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T10));
        if (ComponentMeta<T11>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T11));
        if (ComponentMeta<T12>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T12));
        if (ComponentMeta<T13>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T13));
        if (ComponentMeta<T14>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T14));
	}
	/// <inheritdoc cref="AssertNotBuffered{T0}()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>()
	{
		if (ComponentMeta<T0>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T0));
        if (ComponentMeta<T1>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T1));
        if (ComponentMeta<T2>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T2));
        if (ComponentMeta<T3>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T3));
        if (ComponentMeta<T4>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T4));
        if (ComponentMeta<T5>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T5));
        if (ComponentMeta<T6>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T6));
        if (ComponentMeta<T7>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T7));
        if (ComponentMeta<T8>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T8));
        if (ComponentMeta<T9>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T9));
        if (ComponentMeta<T10>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T10));
        if (ComponentMeta<T11>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T11));
        if (ComponentMeta<T12>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T12));
        if (ComponentMeta<T13>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T13));
        if (ComponentMeta<T14>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T14));
        if (ComponentMeta<T15>.IsBuffered) throw ThrowHelper.ComponentBuffered(typeof(T15));
	}
}