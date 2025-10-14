using System.Runtime.CompilerServices;

namespace EntitiesDb;

public unsafe static class ReinterpretExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Handle<TTo> Reinterpret<TFrom, TTo>(this Handle<TFrom> handle)
		where TFrom : unmanaged
		where TTo : unmanaged
#if NETSTANDARD2_1
		=> new(ref Unsafe.As<TFrom, TTo>(ref handle._first.Value));
#else
		=> new(ref Unsafe.As<TFrom, TTo>(ref handle._first));
#endif

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ReadOnlyHandle<TTo> Reinterpret<TFrom, TTo>(this ReadOnlyHandle<TFrom> handle)
		where TFrom : unmanaged
		where TTo : unmanaged
#if NETSTANDARD2_1
		=> new(ref Unsafe.As<TFrom, TTo>(ref handle._first.Value));
#else
		=> new(ref Unsafe.As<TFrom, TTo>(ref handle._first));
#endif
}
