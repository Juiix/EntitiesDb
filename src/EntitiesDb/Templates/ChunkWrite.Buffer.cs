
namespace EntitiesDb;

public readonly ref struct ChunkWriteBuffer<T0>(ref readonly Chunk chunk)
	where T0 : unmanaged
{
#if NETSTANDARD2_1
	private readonly ReadOnlyRef<Chunk> _chunkRef = new ReadOnlyRef<Chunk>(in chunk);
	private readonly ref readonly Chunk _chunk => ref _chunkRef.Value;
#else
	private readonly ref readonly Chunk _chunk = ref chunk;
#endif

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1>(ref readonly Chunk chunk)
	where T0 : unmanaged
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
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle<T4>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle<T4>();
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle<T5>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle<T4>();
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle<T5>();
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle<T6>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle<T4>();
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle<T5>();
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle<T6>();
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle<T7>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle<T4>();
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle<T5>();
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle<T6>();
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle<T7>();
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle<T8>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle<T4>();
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle<T5>();
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle<T6>();
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle<T7>();
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle<T8>();
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle<T9>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();
    public ReadBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle<T10>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle<T4>();
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle<T5>();
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle<T6>();
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle<T7>();
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle<T8>();
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle<T9>();
    [ChunkChange]
    public WriteBufferHandle<T10> WriteBufferHandleT10() => _chunk.WriteBufferHandle<T10>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle, out  WriteBufferHandle<T10> t10Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
        t10Handle = _chunk.WriteBufferHandle<T10>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle, out  WriteBufferHandle<T10> t10Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
        t10Handle = _chunk.WriteBufferHandle<T10>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();
    public ReadBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle<T10>();
    public ReadBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle<T11>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle<T4>();
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle<T5>();
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle<T6>();
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle<T7>();
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle<T8>();
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle<T9>();
    [ChunkChange]
    public WriteBufferHandle<T10> WriteBufferHandleT10() => _chunk.WriteBufferHandle<T10>();
    [ChunkChange]
    public WriteBufferHandle<T11> WriteBufferHandleT11() => _chunk.WriteBufferHandle<T11>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle, out  WriteBufferHandle<T10> t10Handle, out  WriteBufferHandle<T11> t11Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
        t10Handle = _chunk.WriteBufferHandle<T10>();
        t11Handle = _chunk.WriteBufferHandle<T11>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle, out  WriteBufferHandle<T10> t10Handle, out  WriteBufferHandle<T11> t11Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
        t10Handle = _chunk.WriteBufferHandle<T10>();
        t11Handle = _chunk.WriteBufferHandle<T11>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();
    public ReadBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle<T10>();
    public ReadBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle<T11>();
    public ReadBufferHandle<T12> ReadBufferHandleT12() => _chunk.ReadBufferHandle<T12>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle<T4>();
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle<T5>();
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle<T6>();
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle<T7>();
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle<T8>();
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle<T9>();
    [ChunkChange]
    public WriteBufferHandle<T10> WriteBufferHandleT10() => _chunk.WriteBufferHandle<T10>();
    [ChunkChange]
    public WriteBufferHandle<T11> WriteBufferHandleT11() => _chunk.WriteBufferHandle<T11>();
    [ChunkChange]
    public WriteBufferHandle<T12> WriteBufferHandleT12() => _chunk.WriteBufferHandle<T12>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle, out  WriteBufferHandle<T10> t10Handle, out  WriteBufferHandle<T11> t11Handle, out  WriteBufferHandle<T12> t12Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
        t10Handle = _chunk.WriteBufferHandle<T10>();
        t11Handle = _chunk.WriteBufferHandle<T11>();
        t12Handle = _chunk.WriteBufferHandle<T12>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle, out  WriteBufferHandle<T10> t10Handle, out  WriteBufferHandle<T11> t11Handle, out  WriteBufferHandle<T12> t12Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
        t10Handle = _chunk.WriteBufferHandle<T10>();
        t11Handle = _chunk.WriteBufferHandle<T11>();
        t12Handle = _chunk.WriteBufferHandle<T12>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();
    public ReadBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle<T10>();
    public ReadBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle<T11>();
    public ReadBufferHandle<T12> ReadBufferHandleT12() => _chunk.ReadBufferHandle<T12>();
    public ReadBufferHandle<T13> ReadBufferHandleT13() => _chunk.ReadBufferHandle<T13>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle<T4>();
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle<T5>();
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle<T6>();
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle<T7>();
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle<T8>();
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle<T9>();
    [ChunkChange]
    public WriteBufferHandle<T10> WriteBufferHandleT10() => _chunk.WriteBufferHandle<T10>();
    [ChunkChange]
    public WriteBufferHandle<T11> WriteBufferHandleT11() => _chunk.WriteBufferHandle<T11>();
    [ChunkChange]
    public WriteBufferHandle<T12> WriteBufferHandleT12() => _chunk.WriteBufferHandle<T12>();
    [ChunkChange]
    public WriteBufferHandle<T13> WriteBufferHandleT13() => _chunk.WriteBufferHandle<T13>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle, out  WriteBufferHandle<T10> t10Handle, out  WriteBufferHandle<T11> t11Handle, out  WriteBufferHandle<T12> t12Handle, out  WriteBufferHandle<T13> t13Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
        t10Handle = _chunk.WriteBufferHandle<T10>();
        t11Handle = _chunk.WriteBufferHandle<T11>();
        t12Handle = _chunk.WriteBufferHandle<T12>();
        t13Handle = _chunk.WriteBufferHandle<T13>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle, out  WriteBufferHandle<T10> t10Handle, out  WriteBufferHandle<T11> t11Handle, out  WriteBufferHandle<T12> t12Handle, out  WriteBufferHandle<T13> t13Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
        t10Handle = _chunk.WriteBufferHandle<T10>();
        t11Handle = _chunk.WriteBufferHandle<T11>();
        t12Handle = _chunk.WriteBufferHandle<T12>();
        t13Handle = _chunk.WriteBufferHandle<T13>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();
    public ReadBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle<T10>();
    public ReadBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle<T11>();
    public ReadBufferHandle<T12> ReadBufferHandleT12() => _chunk.ReadBufferHandle<T12>();
    public ReadBufferHandle<T13> ReadBufferHandleT13() => _chunk.ReadBufferHandle<T13>();
    public ReadBufferHandle<T14> ReadBufferHandleT14() => _chunk.ReadBufferHandle<T14>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle<T4>();
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle<T5>();
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle<T6>();
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle<T7>();
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle<T8>();
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle<T9>();
    [ChunkChange]
    public WriteBufferHandle<T10> WriteBufferHandleT10() => _chunk.WriteBufferHandle<T10>();
    [ChunkChange]
    public WriteBufferHandle<T11> WriteBufferHandleT11() => _chunk.WriteBufferHandle<T11>();
    [ChunkChange]
    public WriteBufferHandle<T12> WriteBufferHandleT12() => _chunk.WriteBufferHandle<T12>();
    [ChunkChange]
    public WriteBufferHandle<T13> WriteBufferHandleT13() => _chunk.WriteBufferHandle<T13>();
    [ChunkChange]
    public WriteBufferHandle<T14> WriteBufferHandleT14() => _chunk.WriteBufferHandle<T14>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle, out  WriteBufferHandle<T10> t10Handle, out  WriteBufferHandle<T11> t11Handle, out  WriteBufferHandle<T12> t12Handle, out  WriteBufferHandle<T13> t13Handle, out  WriteBufferHandle<T14> t14Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
        t10Handle = _chunk.WriteBufferHandle<T10>();
        t11Handle = _chunk.WriteBufferHandle<T11>();
        t12Handle = _chunk.WriteBufferHandle<T12>();
        t13Handle = _chunk.WriteBufferHandle<T13>();
        t14Handle = _chunk.WriteBufferHandle<T14>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle, out  WriteBufferHandle<T10> t10Handle, out  WriteBufferHandle<T11> t11Handle, out  WriteBufferHandle<T12> t12Handle, out  WriteBufferHandle<T13> t13Handle, out  WriteBufferHandle<T14> t14Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
        t10Handle = _chunk.WriteBufferHandle<T10>();
        t11Handle = _chunk.WriteBufferHandle<T11>();
        t12Handle = _chunk.WriteBufferHandle<T12>();
        t13Handle = _chunk.WriteBufferHandle<T13>();
        t14Handle = _chunk.WriteBufferHandle<T14>();
	}
}
public readonly ref struct ChunkWriteBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref readonly Chunk chunk)
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

	public int EntityCount => _chunk.EntityCount;
	
	public ReadHandle<Entity> EntityHandle() => _chunk.EntityHandle();
	public ReadBufferHandle<T0> ReadBufferHandleT0() => _chunk.ReadBufferHandle<T0>();
    public ReadBufferHandle<T1> ReadBufferHandleT1() => _chunk.ReadBufferHandle<T1>();
    public ReadBufferHandle<T2> ReadBufferHandleT2() => _chunk.ReadBufferHandle<T2>();
    public ReadBufferHandle<T3> ReadBufferHandleT3() => _chunk.ReadBufferHandle<T3>();
    public ReadBufferHandle<T4> ReadBufferHandleT4() => _chunk.ReadBufferHandle<T4>();
    public ReadBufferHandle<T5> ReadBufferHandleT5() => _chunk.ReadBufferHandle<T5>();
    public ReadBufferHandle<T6> ReadBufferHandleT6() => _chunk.ReadBufferHandle<T6>();
    public ReadBufferHandle<T7> ReadBufferHandleT7() => _chunk.ReadBufferHandle<T7>();
    public ReadBufferHandle<T8> ReadBufferHandleT8() => _chunk.ReadBufferHandle<T8>();
    public ReadBufferHandle<T9> ReadBufferHandleT9() => _chunk.ReadBufferHandle<T9>();
    public ReadBufferHandle<T10> ReadBufferHandleT10() => _chunk.ReadBufferHandle<T10>();
    public ReadBufferHandle<T11> ReadBufferHandleT11() => _chunk.ReadBufferHandle<T11>();
    public ReadBufferHandle<T12> ReadBufferHandleT12() => _chunk.ReadBufferHandle<T12>();
    public ReadBufferHandle<T13> ReadBufferHandleT13() => _chunk.ReadBufferHandle<T13>();
    public ReadBufferHandle<T14> ReadBufferHandleT14() => _chunk.ReadBufferHandle<T14>();
    public ReadBufferHandle<T15> ReadBufferHandleT15() => _chunk.ReadBufferHandle<T15>();
	[ChunkChange]
    public WriteBufferHandle<T0> WriteBufferHandleT0() => _chunk.WriteBufferHandle<T0>();
    [ChunkChange]
    public WriteBufferHandle<T1> WriteBufferHandleT1() => _chunk.WriteBufferHandle<T1>();
    [ChunkChange]
    public WriteBufferHandle<T2> WriteBufferHandleT2() => _chunk.WriteBufferHandle<T2>();
    [ChunkChange]
    public WriteBufferHandle<T3> WriteBufferHandleT3() => _chunk.WriteBufferHandle<T3>();
    [ChunkChange]
    public WriteBufferHandle<T4> WriteBufferHandleT4() => _chunk.WriteBufferHandle<T4>();
    [ChunkChange]
    public WriteBufferHandle<T5> WriteBufferHandleT5() => _chunk.WriteBufferHandle<T5>();
    [ChunkChange]
    public WriteBufferHandle<T6> WriteBufferHandleT6() => _chunk.WriteBufferHandle<T6>();
    [ChunkChange]
    public WriteBufferHandle<T7> WriteBufferHandleT7() => _chunk.WriteBufferHandle<T7>();
    [ChunkChange]
    public WriteBufferHandle<T8> WriteBufferHandleT8() => _chunk.WriteBufferHandle<T8>();
    [ChunkChange]
    public WriteBufferHandle<T9> WriteBufferHandleT9() => _chunk.WriteBufferHandle<T9>();
    [ChunkChange]
    public WriteBufferHandle<T10> WriteBufferHandleT10() => _chunk.WriteBufferHandle<T10>();
    [ChunkChange]
    public WriteBufferHandle<T11> WriteBufferHandleT11() => _chunk.WriteBufferHandle<T11>();
    [ChunkChange]
    public WriteBufferHandle<T12> WriteBufferHandleT12() => _chunk.WriteBufferHandle<T12>();
    [ChunkChange]
    public WriteBufferHandle<T13> WriteBufferHandleT13() => _chunk.WriteBufferHandle<T13>();
    [ChunkChange]
    public WriteBufferHandle<T14> WriteBufferHandleT14() => _chunk.WriteBufferHandle<T14>();
    [ChunkChange]
    public WriteBufferHandle<T15> WriteBufferHandleT15() => _chunk.WriteBufferHandle<T15>();
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle, out  WriteBufferHandle<T10> t10Handle, out  WriteBufferHandle<T11> t11Handle, out  WriteBufferHandle<T12> t12Handle, out  WriteBufferHandle<T13> t13Handle, out  WriteBufferHandle<T14> t14Handle, out  WriteBufferHandle<T15> t15Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
        t10Handle = _chunk.WriteBufferHandle<T10>();
        t11Handle = _chunk.WriteBufferHandle<T11>();
        t12Handle = _chunk.WriteBufferHandle<T12>();
        t13Handle = _chunk.WriteBufferHandle<T13>();
        t14Handle = _chunk.WriteBufferHandle<T14>();
        t15Handle = _chunk.WriteBufferHandle<T15>();
	}
	
	[ChunkChange]
	public void Deconstruct(out int length, out  WriteBufferHandle<T0> t0Handle, out  WriteBufferHandle<T1> t1Handle, out  WriteBufferHandle<T2> t2Handle, out  WriteBufferHandle<T3> t3Handle, out  WriteBufferHandle<T4> t4Handle, out  WriteBufferHandle<T5> t5Handle, out  WriteBufferHandle<T6> t6Handle, out  WriteBufferHandle<T7> t7Handle, out  WriteBufferHandle<T8> t8Handle, out  WriteBufferHandle<T9> t9Handle, out  WriteBufferHandle<T10> t10Handle, out  WriteBufferHandle<T11> t11Handle, out  WriteBufferHandle<T12> t12Handle, out  WriteBufferHandle<T13> t13Handle, out  WriteBufferHandle<T14> t14Handle, out  WriteBufferHandle<T15> t15Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteBufferHandle<T0>();
        t1Handle = _chunk.WriteBufferHandle<T1>();
        t2Handle = _chunk.WriteBufferHandle<T2>();
        t3Handle = _chunk.WriteBufferHandle<T3>();
        t4Handle = _chunk.WriteBufferHandle<T4>();
        t5Handle = _chunk.WriteBufferHandle<T5>();
        t6Handle = _chunk.WriteBufferHandle<T6>();
        t7Handle = _chunk.WriteBufferHandle<T7>();
        t8Handle = _chunk.WriteBufferHandle<T8>();
        t9Handle = _chunk.WriteBufferHandle<T9>();
        t10Handle = _chunk.WriteBufferHandle<T10>();
        t11Handle = _chunk.WriteBufferHandle<T11>();
        t12Handle = _chunk.WriteBufferHandle<T12>();
        t13Handle = _chunk.WriteBufferHandle<T13>();
        t14Handle = _chunk.WriteBufferHandle<T14>();
        t15Handle = _chunk.WriteBufferHandle<T15>();
	}
}
