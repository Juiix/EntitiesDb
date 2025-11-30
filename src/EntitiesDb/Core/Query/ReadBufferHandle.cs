using System.Runtime.CompilerServices;

namespace EntitiesDb;

public unsafe readonly ref struct ReadBufferHandle<T>(ReadBuffer<T> first) where T : unmanaged
{
	private readonly int _stride = ComponentMeta<T>.Stride;
	private readonly void* _first = first.Header;

	public ReadBuffer<T> this[int index] => new(ref Unsafe.AsRef<BufferHeader>((byte*)_first + _stride * index));
}