
namespace EntitiesDb;

public readonly ref struct ChunkWriteMixed1<T0, T1>(ref readonly Chunk chunk, Offsets<T0, T1> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
	}
}
public readonly ref struct ChunkWriteMixed1<T0, T1, T2>(ref readonly Chunk chunk, Offsets<T0, T1, T2> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
	}
}
public readonly ref struct ChunkWriteMixed1<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkWriteMixed1<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public DynamicBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkWriteMixed1<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkWriteMixed1<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkWriteMixed1<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkWriteMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
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
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
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
public readonly ref struct ChunkWriteMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
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
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
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
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
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
public readonly ref struct ChunkWriteMixed2<T0, T1, T2>(ref readonly Chunk chunk, Offsets<T0, T1, T2> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	[ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
	}
}
public readonly ref struct ChunkWriteMixed2<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	[ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkWriteMixed2<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	[ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkWriteMixed2<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	[ChunkChange]
    public DynamicBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkWriteMixed2<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkWriteMixed2<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkWriteMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkWriteMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
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
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
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
public readonly ref struct ChunkWriteMixed3<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
	[ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkWriteMixed3<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
	[ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkWriteMixed3<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
	[ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkWriteMixed3<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
	[ChunkChange]
    public DynamicBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkWriteMixed3<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkWriteMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkWriteMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
        t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkWriteMixed4<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
	[ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
		t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
		t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkWriteMixed4<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
	[ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
		t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
		t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkWriteMixed4<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
	[ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
		t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
		t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkWriteMixed4<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
	[ChunkChange]
    public DynamicBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
		t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
		t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkWriteMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
		t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
		t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkWriteMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
		t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
		t4Handle = _chunk.WriteBufferHandle(_offsets.T4);
        t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkWriteMixed5<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
	[ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
		t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
		t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkWriteMixed5<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
	[ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
		t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
		t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkWriteMixed5<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
	[ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
		t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
		t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkWriteMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
	[ChunkChange]
    public DynamicBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
		t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
		t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkWriteMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadOnlyBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
		t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
		t5Handle = _chunk.WriteBufferHandle(_offsets.T5);
        t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkWriteMixed6<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
	public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public Handle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
	[ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
		t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
		t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkWriteMixed6<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
	public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public Handle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
	[ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
		t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
		t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkWriteMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
	public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public Handle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
	[ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
		t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
		t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkWriteMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
	public ReadOnlyBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public Handle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
	[ChunkChange]
    public DynamicBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public DynamicBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
		t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
		t6Handle = _chunk.WriteBufferHandle(_offsets.T6);
        t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkWriteMixed7<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
	public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public Handle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
    [ChunkChange]
    public Handle<T6?> WriteHandleT6() => _chunk.WriteHandle(_offsets.T6);
	[ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
		t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
		t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkWriteMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
	public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public Handle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
    [ChunkChange]
    public Handle<T6?> WriteHandleT6() => _chunk.WriteHandle(_offsets.T6);
	[ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
		t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
		t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkWriteMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
	public ReadOnlyBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public Handle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
    [ChunkChange]
    public Handle<T6?> WriteHandleT6() => _chunk.WriteHandle(_offsets.T6);
	[ChunkChange]
    public DynamicBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public DynamicBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
		t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
		t7Handle = _chunk.WriteBufferHandle(_offsets.T7);
        t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkWriteMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.ReadHandle(_offsets.T7);
	public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public Handle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
    [ChunkChange]
    public Handle<T6?> WriteHandleT6() => _chunk.WriteHandle(_offsets.T6);
    [ChunkChange]
    public Handle<T7?> WriteHandleT7() => _chunk.WriteHandle(_offsets.T7);
	[ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
        t7Handle = _chunk.WriteHandle(_offsets.T7);
		t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
        t7Handle = _chunk.WriteHandle(_offsets.T7);
		t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkWriteMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.ReadHandle(_offsets.T7);
	public ReadOnlyBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public Handle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
    [ChunkChange]
    public Handle<T6?> WriteHandleT6() => _chunk.WriteHandle(_offsets.T6);
    [ChunkChange]
    public Handle<T7?> WriteHandleT7() => _chunk.WriteHandle(_offsets.T7);
	[ChunkChange]
    public DynamicBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public DynamicBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
        t7Handle = _chunk.WriteHandle(_offsets.T7);
		t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
        t7Handle = _chunk.WriteHandle(_offsets.T7);
		t8Handle = _chunk.WriteBufferHandle(_offsets.T8);
        t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkWriteMixed9<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.ReadHandle(_offsets.T8);
	public ReadOnlyBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public Handle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public Handle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
    [ChunkChange]
    public Handle<T6?> WriteHandleT6() => _chunk.WriteHandle(_offsets.T6);
    [ChunkChange]
    public Handle<T7?> WriteHandleT7() => _chunk.WriteHandle(_offsets.T7);
    [ChunkChange]
    public Handle<T8?> WriteHandleT8() => _chunk.WriteHandle(_offsets.T8);
	[ChunkChange]
    public DynamicBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
        t7Handle = _chunk.WriteHandle(_offsets.T7);
        t8Handle = _chunk.WriteHandle(_offsets.T8);
		t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
        t7Handle = _chunk.WriteHandle(_offsets.T7);
        t8Handle = _chunk.WriteHandle(_offsets.T8);
		t9Handle = _chunk.WriteBufferHandle(_offsets.T9);
	}
}
