
namespace EntitiesDb;

public readonly ref struct ChunkReadBuffer<T0>(ref readonly Chunk chunk, Offsets<T0> offsets)
	where T0 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1>(ref readonly Chunk chunk, Offsets<T0, T1> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2>(ref readonly Chunk chunk, Offsets<T0, T1, T2> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3, T4> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3, T4, T5> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
    where T10 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
    public ReadBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle(_offsets.T10);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle, out  ReadBufferHandle<T10> t10Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
        t10Handle = _chunk.ReadBufferHandle(_offsets.T10);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle, out  ReadBufferHandle<T10> t10Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
        t10Handle = _chunk.ReadBufferHandle(_offsets.T10);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
    where T10 : unmanaged
    where T11 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
    public ReadBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle(_offsets.T10);
    public ReadBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle(_offsets.T11);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle, out  ReadBufferHandle<T10> t10Handle, out  ReadBufferHandle<T11> t11Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
        t10Handle = _chunk.ReadBufferHandle(_offsets.T10);
        t11Handle = _chunk.ReadBufferHandle(_offsets.T11);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle, out  ReadBufferHandle<T10> t10Handle, out  ReadBufferHandle<T11> t11Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
        t10Handle = _chunk.ReadBufferHandle(_offsets.T10);
        t11Handle = _chunk.ReadBufferHandle(_offsets.T11);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
    where T10 : unmanaged
    where T11 : unmanaged
    where T12 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
    public ReadBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle(_offsets.T10);
    public ReadBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle(_offsets.T11);
    public ReadBufferHandle<T12> ReadBufferHandleT12() => _chunk.ReadBufferHandle(_offsets.T12);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle, out  ReadBufferHandle<T10> t10Handle, out  ReadBufferHandle<T11> t11Handle, out  ReadBufferHandle<T12> t12Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
        t10Handle = _chunk.ReadBufferHandle(_offsets.T10);
        t11Handle = _chunk.ReadBufferHandle(_offsets.T11);
        t12Handle = _chunk.ReadBufferHandle(_offsets.T12);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle, out  ReadBufferHandle<T10> t10Handle, out  ReadBufferHandle<T11> t11Handle, out  ReadBufferHandle<T12> t12Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
        t10Handle = _chunk.ReadBufferHandle(_offsets.T10);
        t11Handle = _chunk.ReadBufferHandle(_offsets.T11);
        t12Handle = _chunk.ReadBufferHandle(_offsets.T12);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
    where T10 : unmanaged
    where T11 : unmanaged
    where T12 : unmanaged
    where T13 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
    public ReadBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle(_offsets.T10);
    public ReadBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle(_offsets.T11);
    public ReadBufferHandle<T12> ReadBufferHandleT12() => _chunk.ReadBufferHandle(_offsets.T12);
    public ReadBufferHandle<T13> ReadBufferHandleT13() => _chunk.ReadBufferHandle(_offsets.T13);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle, out  ReadBufferHandle<T10> t10Handle, out  ReadBufferHandle<T11> t11Handle, out  ReadBufferHandle<T12> t12Handle, out  ReadBufferHandle<T13> t13Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
        t10Handle = _chunk.ReadBufferHandle(_offsets.T10);
        t11Handle = _chunk.ReadBufferHandle(_offsets.T11);
        t12Handle = _chunk.ReadBufferHandle(_offsets.T12);
        t13Handle = _chunk.ReadBufferHandle(_offsets.T13);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle, out  ReadBufferHandle<T10> t10Handle, out  ReadBufferHandle<T11> t11Handle, out  ReadBufferHandle<T12> t12Handle, out  ReadBufferHandle<T13> t13Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
        t10Handle = _chunk.ReadBufferHandle(_offsets.T10);
        t11Handle = _chunk.ReadBufferHandle(_offsets.T11);
        t12Handle = _chunk.ReadBufferHandle(_offsets.T12);
        t13Handle = _chunk.ReadBufferHandle(_offsets.T13);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
    where T10 : unmanaged
    where T11 : unmanaged
    where T12 : unmanaged
    where T13 : unmanaged
    where T14 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
    public ReadBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle(_offsets.T10);
    public ReadBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle(_offsets.T11);
    public ReadBufferHandle<T12> ReadBufferHandleT12() => _chunk.ReadBufferHandle(_offsets.T12);
    public ReadBufferHandle<T13> ReadBufferHandleT13() => _chunk.ReadBufferHandle(_offsets.T13);
    public ReadBufferHandle<T14> ReadBufferHandleT14() => _chunk.ReadBufferHandle(_offsets.T14);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle, out  ReadBufferHandle<T10> t10Handle, out  ReadBufferHandle<T11> t11Handle, out  ReadBufferHandle<T12> t12Handle, out  ReadBufferHandle<T13> t13Handle, out  ReadBufferHandle<T14> t14Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
        t10Handle = _chunk.ReadBufferHandle(_offsets.T10);
        t11Handle = _chunk.ReadBufferHandle(_offsets.T11);
        t12Handle = _chunk.ReadBufferHandle(_offsets.T12);
        t13Handle = _chunk.ReadBufferHandle(_offsets.T13);
        t14Handle = _chunk.ReadBufferHandle(_offsets.T14);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle, out  ReadBufferHandle<T10> t10Handle, out  ReadBufferHandle<T11> t11Handle, out  ReadBufferHandle<T12> t12Handle, out  ReadBufferHandle<T13> t13Handle, out  ReadBufferHandle<T14> t14Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
        t10Handle = _chunk.ReadBufferHandle(_offsets.T10);
        t11Handle = _chunk.ReadBufferHandle(_offsets.T11);
        t12Handle = _chunk.ReadBufferHandle(_offsets.T12);
        t13Handle = _chunk.ReadBufferHandle(_offsets.T13);
        t14Handle = _chunk.ReadBufferHandle(_offsets.T14);
	}
}
public readonly ref struct ChunkReadBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
    where T8 : unmanaged
    where T9 : unmanaged
    where T10 : unmanaged
    where T11 : unmanaged
    where T12 : unmanaged
    where T13 : unmanaged
    where T14 : unmanaged
    where T15 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
    public ReadBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle(_offsets.T10);
    public ReadBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle(_offsets.T11);
    public ReadBufferHandle<T12> ReadBufferHandleT12() => _chunk.ReadBufferHandle(_offsets.T12);
    public ReadBufferHandle<T13> ReadBufferHandleT13() => _chunk.ReadBufferHandle(_offsets.T13);
    public ReadBufferHandle<T14> ReadBufferHandleT14() => _chunk.ReadBufferHandle(_offsets.T14);
    public ReadBufferHandle<T15> ReadBufferHandleT15() => _chunk.ReadBufferHandle(_offsets.T15);

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle, out  ReadBufferHandle<T10> t10Handle, out  ReadBufferHandle<T11> t11Handle, out  ReadBufferHandle<T12> t12Handle, out  ReadBufferHandle<T13> t13Handle, out  ReadBufferHandle<T14> t14Handle, out  ReadBufferHandle<T15> t15Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
        t10Handle = _chunk.ReadBufferHandle(_offsets.T10);
        t11Handle = _chunk.ReadBufferHandle(_offsets.T11);
        t12Handle = _chunk.ReadBufferHandle(_offsets.T12);
        t13Handle = _chunk.ReadBufferHandle(_offsets.T13);
        t14Handle = _chunk.ReadBufferHandle(_offsets.T14);
        t15Handle = _chunk.ReadBufferHandle(_offsets.T15);
	}

	public void Deconstruct(out int length, out  ReadBufferHandle<T0> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle, out  ReadBufferHandle<T10> t10Handle, out  ReadBufferHandle<T11> t11Handle, out  ReadBufferHandle<T12> t12Handle, out  ReadBufferHandle<T13> t13Handle, out  ReadBufferHandle<T14> t14Handle, out  ReadBufferHandle<T15> t15Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadBufferHandle(_offsets.T0);
        t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
        t10Handle = _chunk.ReadBufferHandle(_offsets.T10);
        t11Handle = _chunk.ReadBufferHandle(_offsets.T11);
        t12Handle = _chunk.ReadBufferHandle(_offsets.T12);
        t13Handle = _chunk.ReadBufferHandle(_offsets.T13);
        t14Handle = _chunk.ReadBufferHandle(_offsets.T14);
        t15Handle = _chunk.ReadBufferHandle(_offsets.T15);
	}
}
