using System.Runtime.CompilerServices;

namespace EntitiesDb;

public readonly ref struct ReadOnlyHandle<T>(ref T first)
{
	private readonly ref T _first = ref first;

	public ref readonly T this[int index] => ref Unsafe.Add(ref _first, index);

	public ReadOnlyHandle<TTo> Reinterpret<TTo>() => new(ref Unsafe.As<T, TTo>(ref _first));
}
