
namespace EntitiesDb;

public readonly ref struct ChunkReadMixed1<T0, T1>(ref readonly Chunk chunk, Offsets<T0, T1> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2>(ref readonly Chunk chunk, Offsets<T0, T1, T2> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
		t1Handle = _chunk.ReadBufferHandle(_offsets.T1);
        t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
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
public readonly ref struct ChunkReadMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
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

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyBufferHandle<T1> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
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
public readonly ref struct ChunkReadMixed2<T0, T1, T2>(ref readonly Chunk chunk, Offsets<T0, T1, T2> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkReadMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
		t2Handle = _chunk.ReadBufferHandle(_offsets.T2);
        t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyBufferHandle<T2> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
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
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkReadMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyBufferHandle<T3> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
		t3Handle = _chunk.ReadBufferHandle(_offsets.T3);
        t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkReadMixed4<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
		t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
		t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkReadMixed4<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
		t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
		t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkReadMixed4<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
		t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
		t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkReadMixed4<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
		t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
		t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkReadMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
		t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
		t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkReadMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
		t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyBufferHandle<T4> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
		t4Handle = _chunk.ReadBufferHandle(_offsets.T4);
        t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkReadMixed5<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
		t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
		t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkReadMixed5<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
		t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
		t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkReadMixed5<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
		t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
		t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkReadMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
		t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
		t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkReadMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
		t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyBufferHandle<T5> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
		t5Handle = _chunk.ReadBufferHandle(_offsets.T5);
        t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkReadMixed6<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
	public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
		t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
		t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkReadMixed6<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
	public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
		t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
		t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkReadMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
	public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
		t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
		t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkReadMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
	public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
		t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyBufferHandle<T6> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
		t6Handle = _chunk.ReadBufferHandle(_offsets.T6);
        t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkReadMixed7<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
	public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
		t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
		t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkReadMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
	public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
		t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
		t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkReadMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
	public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
		t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyBufferHandle<T7> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
		t7Handle = _chunk.ReadBufferHandle(_offsets.T7);
        t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkReadMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);
	public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
        t7Handle = _chunk.ReadHandle(_offsets.T7);
		t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
        t7Handle = _chunk.ReadHandle(_offsets.T7);
		t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkReadMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);
	public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
        t7Handle = _chunk.ReadHandle(_offsets.T7);
		t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyBufferHandle<T8> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
        t7Handle = _chunk.ReadHandle(_offsets.T7);
		t8Handle = _chunk.ReadBufferHandle(_offsets.T8);
        t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkReadMixed9<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> ReadHandleT8() => _chunk.ReadHandle(_offsets.T8);
	public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
        t7Handle = _chunk.ReadHandle(_offsets.T7);
        t8Handle = _chunk.ReadHandle(_offsets.T8);
		t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
        t7Handle = _chunk.ReadHandle(_offsets.T7);
        t8Handle = _chunk.ReadHandle(_offsets.T8);
		t9Handle = _chunk.ReadBufferHandle(_offsets.T9);
	}
}
