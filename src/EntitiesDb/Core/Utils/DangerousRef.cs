using System.Runtime.CompilerServices;

namespace EntitiesDb;

public unsafe readonly struct DangerousRef<T>(ref T value)
{
	private readonly void* _ptr = Unsafe.AsPointer(ref value);
	public readonly ref T Value => ref Unsafe.AsRef<T>(_ptr);
}
