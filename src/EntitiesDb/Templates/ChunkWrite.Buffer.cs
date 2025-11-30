
namespace EntitiesDb;

public readonly ref struct ChunkWriteBuffer<T0>(ref readonly Chunk chunk, Offsets<T0> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1>(ref readonly Chunk chunk, Offsets<T0, T1> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2>(ref readonly Chunk chunk, Offsets<T0, T1, T2> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public DynamicBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
    public ReadOnlyBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle(_offsets.T10);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public DynamicBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
    [ChunkChange]
    public DynamicBufferHandle<T10> WriteBufferHandleT10() => _chunk.WriteBufferHandle(_offsets.T10);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
        t10Handle = _chunk.WriteBufferHandle(_offsets.T10);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
        t10Handle = _chunk.WriteBufferHandle(_offsets.T10);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
    public ReadOnlyBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle(_offsets.T10);
    public ReadOnlyBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle(_offsets.T11);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public DynamicBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
    [ChunkChange]
    public DynamicBufferHandle<T10> WriteBufferHandleT10() => _chunk.WriteBufferHandle(_offsets.T10);
    [ChunkChange]
    public DynamicBufferHandle<T11> WriteBufferHandleT11() => _chunk.WriteBufferHandle(_offsets.T11);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
        t10Handle = _chunk.WriteBufferHandle(_offsets.T10);
        t11Handle = _chunk.WriteBufferHandle(_offsets.T11);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
        t10Handle = _chunk.WriteBufferHandle(_offsets.T10);
        t11Handle = _chunk.WriteBufferHandle(_offsets.T11);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
    public ReadOnlyBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle(_offsets.T10);
    public ReadOnlyBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle(_offsets.T11);
    public ReadOnlyBufferHandle<T12> ReadBufferHandleT12() => _chunk.ReadBufferHandle(_offsets.T12);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public DynamicBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
    [ChunkChange]
    public DynamicBufferHandle<T10> WriteBufferHandleT10() => _chunk.WriteBufferHandle(_offsets.T10);
    [ChunkChange]
    public DynamicBufferHandle<T11> WriteBufferHandleT11() => _chunk.WriteBufferHandle(_offsets.T11);
    [ChunkChange]
    public DynamicBufferHandle<T12> WriteBufferHandleT12() => _chunk.WriteBufferHandle(_offsets.T12);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
        t10Handle = _chunk.WriteBufferHandle(_offsets.T10);
        t11Handle = _chunk.WriteBufferHandle(_offsets.T11);
        t12Handle = _chunk.WriteBufferHandle(_offsets.T12);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
        t10Handle = _chunk.WriteBufferHandle(_offsets.T10);
        t11Handle = _chunk.WriteBufferHandle(_offsets.T11);
        t12Handle = _chunk.WriteBufferHandle(_offsets.T12);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
    public ReadOnlyBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle(_offsets.T10);
    public ReadOnlyBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle(_offsets.T11);
    public ReadOnlyBufferHandle<T12> ReadBufferHandleT12() => _chunk.ReadBufferHandle(_offsets.T12);
    public ReadOnlyBufferHandle<T13> ReadBufferHandleT13() => _chunk.ReadBufferHandle(_offsets.T13);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public DynamicBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
    [ChunkChange]
    public DynamicBufferHandle<T10> WriteBufferHandleT10() => _chunk.WriteBufferHandle(_offsets.T10);
    [ChunkChange]
    public DynamicBufferHandle<T11> WriteBufferHandleT11() => _chunk.WriteBufferHandle(_offsets.T11);
    [ChunkChange]
    public DynamicBufferHandle<T12> WriteBufferHandleT12() => _chunk.WriteBufferHandle(_offsets.T12);
    [ChunkChange]
    public DynamicBufferHandle<T13> WriteBufferHandleT13() => _chunk.WriteBufferHandle(_offsets.T13);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle, out DynamicBufferHandle<T13> t13Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
        t10Handle = _chunk.WriteBufferHandle(_offsets.T10);
        t11Handle = _chunk.WriteBufferHandle(_offsets.T11);
        t12Handle = _chunk.WriteBufferHandle(_offsets.T12);
        t13Handle = _chunk.WriteBufferHandle(_offsets.T13);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle, out DynamicBufferHandle<T13> t13Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
        t10Handle = _chunk.WriteBufferHandle(_offsets.T10);
        t11Handle = _chunk.WriteBufferHandle(_offsets.T11);
        t12Handle = _chunk.WriteBufferHandle(_offsets.T12);
        t13Handle = _chunk.WriteBufferHandle(_offsets.T13);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
    public ReadOnlyBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle(_offsets.T10);
    public ReadOnlyBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle(_offsets.T11);
    public ReadOnlyBufferHandle<T12> ReadBufferHandleT12() => _chunk.ReadBufferHandle(_offsets.T12);
    public ReadOnlyBufferHandle<T13> ReadBufferHandleT13() => _chunk.ReadBufferHandle(_offsets.T13);
    public ReadOnlyBufferHandle<T14> ReadBufferHandleT14() => _chunk.ReadBufferHandle(_offsets.T14);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public DynamicBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
    [ChunkChange]
    public DynamicBufferHandle<T10> WriteBufferHandleT10() => _chunk.WriteBufferHandle(_offsets.T10);
    [ChunkChange]
    public DynamicBufferHandle<T11> WriteBufferHandleT11() => _chunk.WriteBufferHandle(_offsets.T11);
    [ChunkChange]
    public DynamicBufferHandle<T12> WriteBufferHandleT12() => _chunk.WriteBufferHandle(_offsets.T12);
    [ChunkChange]
    public DynamicBufferHandle<T13> WriteBufferHandleT13() => _chunk.WriteBufferHandle(_offsets.T13);
    [ChunkChange]
    public DynamicBufferHandle<T14> WriteBufferHandleT14() => _chunk.WriteBufferHandle(_offsets.T14);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle, out DynamicBufferHandle<T13> t13Handle, out DynamicBufferHandle<T14> t14Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
        t10Handle = _chunk.WriteBufferHandle(_offsets.T10);
        t11Handle = _chunk.WriteBufferHandle(_offsets.T11);
        t12Handle = _chunk.WriteBufferHandle(_offsets.T12);
        t13Handle = _chunk.WriteBufferHandle(_offsets.T13);
        t14Handle = _chunk.WriteBufferHandle(_offsets.T14);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle, out DynamicBufferHandle<T13> t13Handle, out DynamicBufferHandle<T14> t14Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
        t10Handle = _chunk.WriteBufferHandle(_offsets.T10);
        t11Handle = _chunk.WriteBufferHandle(_offsets.T11);
        t12Handle = _chunk.WriteBufferHandle(_offsets.T12);
        t13Handle = _chunk.WriteBufferHandle(_offsets.T13);
        t14Handle = _chunk.WriteBufferHandle(_offsets.T14);
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> offsets)
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
	
	public ReadOnlyHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadOnlyBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle(_offsets.T0);
    public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
    public ReadOnlyBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle(_offsets.T10);
    public ReadOnlyBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle(_offsets.T11);
    public ReadOnlyBufferHandle<T12> ReadBufferHandleT12() => _chunk.ReadBufferHandle(_offsets.T12);
    public ReadOnlyBufferHandle<T13> ReadBufferHandleT13() => _chunk.ReadBufferHandle(_offsets.T13);
    public ReadOnlyBufferHandle<T14> ReadBufferHandleT14() => _chunk.ReadBufferHandle(_offsets.T14);
    public ReadOnlyBufferHandle<T15> ReadBufferHandleT15() => _chunk.ReadBufferHandle(_offsets.T15);
	[ChunkChange]
    public DynamicBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle(_offsets.T0);
    [ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public DynamicBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
    [ChunkChange]
    public DynamicBufferHandle<T10> WriteBufferHandleT10() => _chunk.WriteBufferHandle(_offsets.T10);
    [ChunkChange]
    public DynamicBufferHandle<T11> WriteBufferHandleT11() => _chunk.WriteBufferHandle(_offsets.T11);
    [ChunkChange]
    public DynamicBufferHandle<T12> WriteBufferHandleT12() => _chunk.WriteBufferHandle(_offsets.T12);
    [ChunkChange]
    public DynamicBufferHandle<T13> WriteBufferHandleT13() => _chunk.WriteBufferHandle(_offsets.T13);
    [ChunkChange]
    public DynamicBufferHandle<T14> WriteBufferHandleT14() => _chunk.WriteBufferHandle(_offsets.T14);
    [ChunkChange]
    public DynamicBufferHandle<T15> WriteBufferHandleT15() => _chunk.WriteBufferHandle(_offsets.T15);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle, out DynamicBufferHandle<T13> t13Handle, out DynamicBufferHandle<T14> t14Handle, out DynamicBufferHandle<T15> t15Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
        t10Handle = _chunk.WriteBufferHandle(_offsets.T10);
        t11Handle = _chunk.WriteBufferHandle(_offsets.T11);
        t12Handle = _chunk.WriteBufferHandle(_offsets.T12);
        t13Handle = _chunk.WriteBufferHandle(_offsets.T13);
        t14Handle = _chunk.WriteBufferHandle(_offsets.T14);
        t15Handle = _chunk.WriteBufferHandle(_offsets.T15);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle, out DynamicBufferHandle<T13> t13Handle, out DynamicBufferHandle<T14> t14Handle, out DynamicBufferHandle<T15> t15Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle(_offsets.T0);
        t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
        t10Handle = _chunk.WriteBufferHandle(_offsets.T10);
        t11Handle = _chunk.WriteBufferHandle(_offsets.T11);
        t12Handle = _chunk.WriteBufferHandle(_offsets.T12);
        t13Handle = _chunk.WriteBufferHandle(_offsets.T13);
        t14Handle = _chunk.WriteBufferHandle(_offsets.T14);
        t15Handle = _chunk.WriteBufferHandle(_offsets.T15);
	}
}
