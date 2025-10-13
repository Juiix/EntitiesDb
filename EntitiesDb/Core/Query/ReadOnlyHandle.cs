using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EntitiesDb;

public readonly ref struct ReadOnlyHandle<T>
{
	internal readonly ref T _first;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ReadOnlyHandle(ref T first)
	{
		_first = ref first;
	}

	public ref readonly T this[int index]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => ref Unsafe.Add(ref _first, index);
	}

	public ReadOnlySpan<T> AsSpan(int length) => MemoryMarshal.CreateSpan(ref _first, length);
}
