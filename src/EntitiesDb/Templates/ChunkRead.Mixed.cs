
namespace EntitiesDb;

public readonly ref struct ChunkReadMixed1<T0, T1>(ref readonly Chunk chunk)
	where T1 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2>(ref readonly Chunk chunk)
	where T1 : unmanaged
    where T2 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3, T4>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out  ReadBufferHandle<T1> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
		t1Handle = _chunk.ReadBufferHandle<T1>();
        t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2>(ref readonly Chunk chunk)
	where T2 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3>(ref readonly Chunk chunk)
	where T2 : unmanaged
    where T3 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3, T4>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out  ReadBufferHandle<T2> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
		t2Handle = _chunk.ReadBufferHandle<T2>();
        t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3>(ref readonly Chunk chunk)
	where T3 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3, T4>(ref readonly Chunk chunk)
	where T3 : unmanaged
    where T4 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out  ReadBufferHandle<T3> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
		t3Handle = _chunk.ReadBufferHandle<T3>();
        t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}
}
public readonly ref struct ChunkReadMixed4<T0, T1, T2, T3, T4>(ref readonly Chunk chunk)
	where T4 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
	public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out  ReadBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
		t4Handle = _chunk.ReadBufferHandle<T4>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out  ReadBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
		t4Handle = _chunk.ReadBufferHandle<T4>();
	}
}
public readonly ref struct ChunkReadMixed4<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk)
	where T4 : unmanaged
    where T5 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
	public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
		t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
		t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
	}
}
public readonly ref struct ChunkReadMixed4<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
	public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
		t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
		t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
	}
}
public readonly ref struct ChunkReadMixed4<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
	public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
		t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
		t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
	}
}
public readonly ref struct ChunkReadMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
	public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
		t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
		t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}
}
public readonly ref struct ChunkReadMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
	public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
		t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out  ReadBufferHandle<T4> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
		t4Handle = _chunk.ReadBufferHandle<T4>();
        t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}
}
public readonly ref struct ChunkReadMixed5<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk)
	where T5 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
	public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out  ReadBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
		t5Handle = _chunk.ReadBufferHandle<T5>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out  ReadBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
		t5Handle = _chunk.ReadBufferHandle<T5>();
	}
}
public readonly ref struct ChunkReadMixed5<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk)
	where T5 : unmanaged
    where T6 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
	public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
		t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
		t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
	}
}
public readonly ref struct ChunkReadMixed5<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
	public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
		t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
		t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
	}
}
public readonly ref struct ChunkReadMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
	public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
		t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
		t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}
}
public readonly ref struct ChunkReadMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
	public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
		t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out  ReadBufferHandle<T5> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
		t5Handle = _chunk.ReadBufferHandle<T5>();
        t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}
}
public readonly ref struct ChunkReadMixed6<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk)
	where T6 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle<T5>();
	public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
		t6Handle = _chunk.ReadBufferHandle<T6>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out  ReadBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
		t6Handle = _chunk.ReadBufferHandle<T6>();
	}
}
public readonly ref struct ChunkReadMixed6<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk)
	where T6 : unmanaged
    where T7 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle<T5>();
	public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
		t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
		t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
	}
}
public readonly ref struct ChunkReadMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle<T5>();
	public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
		t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
		t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}
}
public readonly ref struct ChunkReadMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle<T5>();
	public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
		t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out  ReadBufferHandle<T6> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
		t6Handle = _chunk.ReadBufferHandle<T6>();
        t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}
}
public readonly ref struct ChunkReadMixed7<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk)
	where T7 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle<T5>();
    public ReadHandle<T6?> ReadHandleT6() => _chunk.ReadHandle<T6>();
	public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
		t7Handle = _chunk.ReadBufferHandle<T7>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out  ReadBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
		t7Handle = _chunk.ReadBufferHandle<T7>();
	}
}
public readonly ref struct ChunkReadMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk)
	where T7 : unmanaged
    where T8 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle<T5>();
    public ReadHandle<T6?> ReadHandleT6() => _chunk.ReadHandle<T6>();
	public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
		t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
		t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
	}
}
public readonly ref struct ChunkReadMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle<T5>();
    public ReadHandle<T6?> ReadHandleT6() => _chunk.ReadHandle<T6>();
	public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
		t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out  ReadBufferHandle<T7> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
		t7Handle = _chunk.ReadBufferHandle<T7>();
        t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}
}
public readonly ref struct ChunkReadMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk)
	where T8 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle<T5>();
    public ReadHandle<T6?> ReadHandleT6() => _chunk.ReadHandle<T6>();
    public ReadHandle<T7?> ReadHandleT7() => _chunk.ReadHandle<T7>();
	public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
        t7Handle = _chunk.ReadHandle<T7>();
		t8Handle = _chunk.ReadBufferHandle<T8>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out  ReadBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
        t7Handle = _chunk.ReadHandle<T7>();
		t8Handle = _chunk.ReadBufferHandle<T8>();
	}
}
public readonly ref struct ChunkReadMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk)
	where T8 : unmanaged
    where T9 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle<T5>();
    public ReadHandle<T6?> ReadHandleT6() => _chunk.ReadHandle<T6>();
    public ReadHandle<T7?> ReadHandleT7() => _chunk.ReadHandle<T7>();
	public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
        t7Handle = _chunk.ReadHandle<T7>();
		t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out  ReadBufferHandle<T8> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
        t7Handle = _chunk.ReadHandle<T7>();
		t8Handle = _chunk.ReadBufferHandle<T8>();
        t9Handle = _chunk.ReadBufferHandle<T9>();
	}
}
public readonly ref struct ChunkReadMixed9<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk)
	where T9 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle<T0>();
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle<T1>();
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle<T2>();
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle<T3>();
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle<T4>();
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle<T5>();
    public ReadHandle<T6?> ReadHandleT6() => _chunk.ReadHandle<T6>();
    public ReadHandle<T7?> ReadHandleT7() => _chunk.ReadHandle<T7>();
    public ReadHandle<T8?> ReadHandleT8() => _chunk.ReadHandle<T8>();
	public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
        t7Handle = _chunk.ReadHandle<T7>();
        t8Handle = _chunk.ReadHandle<T8>();
		t9Handle = _chunk.ReadBufferHandle<T9>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out  ReadBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
        t7Handle = _chunk.ReadHandle<T7>();
        t8Handle = _chunk.ReadHandle<T8>();
		t9Handle = _chunk.ReadBufferHandle<T9>();
	}
}
