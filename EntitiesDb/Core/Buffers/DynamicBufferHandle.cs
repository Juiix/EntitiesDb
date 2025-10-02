using System.Runtime.CompilerServices;

namespace EntitiesDb;

public unsafe readonly ref struct DynamicBufferHandle<T> where T : unmanaged
{
	private readonly void* _header;

	internal DynamicBufferHandle(ref BufferHeader header)
	{
		_header = Unsafe.AsPointer(ref header);
	}

	public DynamicBuffer<T> this[int index] => new(ref GetHeader(index));

	private ref BufferHeader GetHeader(int index) => ref Unsafe.AsRef<BufferHeader>((byte*)_header + ComponentMeta<T>.Stride * index);
}
