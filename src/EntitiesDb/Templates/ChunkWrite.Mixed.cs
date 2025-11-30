
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
		t1Handle = _chunk.WriteBufferHandle(_offsets.T1);
        t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
	public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle(_offsets.T1);
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	[ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle(_offsets.T1);
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	[ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	[ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
		t2Handle = _chunk.WriteBufferHandle(_offsets.T2);
        t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	[ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	[ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	[ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	[ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	[ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
	public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle(_offsets.T2);
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	[ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle(_offsets.T2);
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
	[ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
		t3Handle = _chunk.WriteBufferHandle(_offsets.T3);
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
	[ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
	[ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
	[ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
	[ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
	[ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
	public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle(_offsets.T3);
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
	[ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle(_offsets.T3);
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
	[ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out  WriteBufferHandle<T4> t4Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out  WriteBufferHandle<T4> t4Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
	[ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
	[ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
	[ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
	[ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
	public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle(_offsets.T4);
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
	[ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle(_offsets.T4);
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
	[ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out  WriteBufferHandle<T5> t5Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out  WriteBufferHandle<T5> t5Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
	[ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
	[ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
	[ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
	public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle(_offsets.T5);
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
	[ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle(_offsets.T5);
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
	public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public WriteHandle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
	[ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out  WriteBufferHandle<T6> t6Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out  WriteBufferHandle<T6> t6Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
	public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public WriteHandle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
	[ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
	public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public WriteHandle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
	[ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
	public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle(_offsets.T6);
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public WriteHandle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
	[ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle(_offsets.T6);
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
	public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public WriteHandle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
    [ChunkChange]
    public WriteHandle<T6?> WriteHandleT6() => _chunk.WriteHandle(_offsets.T6);
	[ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out WriteHandle<T6?> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out WriteHandle<T6?> t6Handle, out  WriteBufferHandle<T7> t7Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
	public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public WriteHandle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
    [ChunkChange]
    public WriteHandle<T6?> WriteHandleT6() => _chunk.WriteHandle(_offsets.T6);
	[ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out WriteHandle<T6?> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out WriteHandle<T6?> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
	public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle(_offsets.T7);
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public WriteHandle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
    [ChunkChange]
    public WriteHandle<T6?> WriteHandleT6() => _chunk.WriteHandle(_offsets.T6);
	[ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle(_offsets.T7);
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out WriteHandle<T6?> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out WriteHandle<T6?> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);
	public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public WriteHandle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
    [ChunkChange]
    public WriteHandle<T6?> WriteHandleT6() => _chunk.WriteHandle(_offsets.T6);
    [ChunkChange]
    public WriteHandle<T7?> WriteHandleT7() => _chunk.WriteHandle(_offsets.T7);
	[ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out WriteHandle<T6?> t6Handle, out WriteHandle<T7?> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out WriteHandle<T6?> t6Handle, out WriteHandle<T7?> t7Handle, out  WriteBufferHandle<T8> t8Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);
	public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle(_offsets.T8);
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public WriteHandle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
    [ChunkChange]
    public WriteHandle<T6?> WriteHandleT6() => _chunk.WriteHandle(_offsets.T6);
    [ChunkChange]
    public WriteHandle<T7?> WriteHandleT7() => _chunk.WriteHandle(_offsets.T7);
	[ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle(_offsets.T8);
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out WriteHandle<T6?> t6Handle, out WriteHandle<T7?> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out WriteHandle<T6?> t6Handle, out WriteHandle<T7?> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadHandle<T8?> ReadHandleT8() => _chunk.ReadHandle(_offsets.T8);
	public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle(_offsets.T9);
	[ChunkChange]
    public WriteHandle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public WriteHandle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public WriteHandle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public WriteHandle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
    [ChunkChange]
    public WriteHandle<T4?> WriteHandleT4() => _chunk.WriteHandle(_offsets.T4);
    [ChunkChange]
    public WriteHandle<T5?> WriteHandleT5() => _chunk.WriteHandle(_offsets.T5);
    [ChunkChange]
    public WriteHandle<T6?> WriteHandleT6() => _chunk.WriteHandle(_offsets.T6);
    [ChunkChange]
    public WriteHandle<T7?> WriteHandleT7() => _chunk.WriteHandle(_offsets.T7);
    [ChunkChange]
    public WriteHandle<T8?> WriteHandleT8() => _chunk.WriteHandle(_offsets.T8);
	[ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out WriteHandle<T6?> t6Handle, out WriteHandle<T7?> t7Handle, out WriteHandle<T8?> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
	public void Deconstruct(out int length, out WriteHandle<T0?> t0Handle, out WriteHandle<T1?> t1Handle, out WriteHandle<T2?> t2Handle, out WriteHandle<T3?> t3Handle, out WriteHandle<T4?> t4Handle, out WriteHandle<T5?> t5Handle, out WriteHandle<T6?> t6Handle, out WriteHandle<T7?> t7Handle, out WriteHandle<T8?> t8Handle, out  WriteBufferHandle<T9> t9Handle)
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
