using System.Runtime.CompilerServices;

namespace EntitiesDb;

public unsafe static class ReinterpretExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Handle<TTo> Reinterpret<TFrom, TTo>(this Handle<TFrom> handle)
		where TFrom : unmanaged
		where TTo : unmanaged
		=> new(ref Unsafe.As<TFrom, TTo>(ref handle._first));

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ReadOnlyHandle<TTo> Reinterpret<TFrom, TTo>(this ReadOnlyHandle<TFrom> handle)
		where TFrom : unmanaged
		where TTo : unmanaged
		=> new(ref Unsafe.As<TFrom, TTo>(ref handle._first));
}
