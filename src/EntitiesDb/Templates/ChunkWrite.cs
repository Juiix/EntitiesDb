
namespace EntitiesDb;

public readonly ref struct ChunkWrite<T0>(ref readonly Chunk chunk, Offsets<T0> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
	}
}
public readonly ref struct ChunkWrite<T0, T1>(ref readonly Chunk chunk, Offsets<T0, T1> offsets)
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
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2>(ref readonly Chunk chunk, Offsets<T0, T1, T2> offsets)
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
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
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
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
	[ChunkChange]
    public Handle<T0?> WriteHandleT0() => _chunk.WriteHandle(_offsets.T0);
    [ChunkChange]
    public Handle<T1?> WriteHandleT1() => _chunk.WriteHandle(_offsets.T1);
    [ChunkChange]
    public Handle<T2?> WriteHandleT2() => _chunk.WriteHandle(_offsets.T2);
    [ChunkChange]
    public Handle<T3?> WriteHandleT3() => _chunk.WriteHandle(_offsets.T3);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle)
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
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.WriteHandle(_offsets.T0);
        t1Handle = _chunk.WriteHandle(_offsets.T1);
        t2Handle = _chunk.WriteHandle(_offsets.T2);
        t3Handle = _chunk.WriteHandle(_offsets.T3);
        t4Handle = _chunk.WriteHandle(_offsets.T4);
        t5Handle = _chunk.WriteHandle(_offsets.T5);
        t6Handle = _chunk.WriteHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.ReadHandle(_offsets.T7);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle)
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
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle)
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
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.ReadHandle(_offsets.T8);
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
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle)
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
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle)
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
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.ReadHandle(_offsets.T9);
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
    public Handle<T9?> WriteHandleT9() => _chunk.WriteHandle(_offsets.T9);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.ReadHandle(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.ReadHandle(_offsets.T9);
    public ReadOnlyHandle<T10?> GetHandleReadOnlyT10() => _chunk.ReadHandle(_offsets.T10);
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
    public Handle<T9?> WriteHandleT9() => _chunk.WriteHandle(_offsets.T9);
    [ChunkChange]
    public Handle<T10?> WriteHandleT10() => _chunk.WriteHandle(_offsets.T10);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
        t10Handle = _chunk.WriteHandle(_offsets.T10);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
        t10Handle = _chunk.WriteHandle(_offsets.T10);
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.ReadHandle(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.ReadHandle(_offsets.T9);
    public ReadOnlyHandle<T10?> GetHandleReadOnlyT10() => _chunk.ReadHandle(_offsets.T10);
    public ReadOnlyHandle<T11?> GetHandleReadOnlyT11() => _chunk.ReadHandle(_offsets.T11);
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
    public Handle<T9?> WriteHandleT9() => _chunk.WriteHandle(_offsets.T9);
    [ChunkChange]
    public Handle<T10?> WriteHandleT10() => _chunk.WriteHandle(_offsets.T10);
    [ChunkChange]
    public Handle<T11?> WriteHandleT11() => _chunk.WriteHandle(_offsets.T11);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
        t10Handle = _chunk.WriteHandle(_offsets.T10);
        t11Handle = _chunk.WriteHandle(_offsets.T11);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
        t10Handle = _chunk.WriteHandle(_offsets.T10);
        t11Handle = _chunk.WriteHandle(_offsets.T11);
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.ReadHandle(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.ReadHandle(_offsets.T9);
    public ReadOnlyHandle<T10?> GetHandleReadOnlyT10() => _chunk.ReadHandle(_offsets.T10);
    public ReadOnlyHandle<T11?> GetHandleReadOnlyT11() => _chunk.ReadHandle(_offsets.T11);
    public ReadOnlyHandle<T12?> GetHandleReadOnlyT12() => _chunk.ReadHandle(_offsets.T12);
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
    public Handle<T9?> WriteHandleT9() => _chunk.WriteHandle(_offsets.T9);
    [ChunkChange]
    public Handle<T10?> WriteHandleT10() => _chunk.WriteHandle(_offsets.T10);
    [ChunkChange]
    public Handle<T11?> WriteHandleT11() => _chunk.WriteHandle(_offsets.T11);
    [ChunkChange]
    public Handle<T12?> WriteHandleT12() => _chunk.WriteHandle(_offsets.T12);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
        t10Handle = _chunk.WriteHandle(_offsets.T10);
        t11Handle = _chunk.WriteHandle(_offsets.T11);
        t12Handle = _chunk.WriteHandle(_offsets.T12);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
        t10Handle = _chunk.WriteHandle(_offsets.T10);
        t11Handle = _chunk.WriteHandle(_offsets.T11);
        t12Handle = _chunk.WriteHandle(_offsets.T12);
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.ReadHandle(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.ReadHandle(_offsets.T9);
    public ReadOnlyHandle<T10?> GetHandleReadOnlyT10() => _chunk.ReadHandle(_offsets.T10);
    public ReadOnlyHandle<T11?> GetHandleReadOnlyT11() => _chunk.ReadHandle(_offsets.T11);
    public ReadOnlyHandle<T12?> GetHandleReadOnlyT12() => _chunk.ReadHandle(_offsets.T12);
    public ReadOnlyHandle<T13?> GetHandleReadOnlyT13() => _chunk.ReadHandle(_offsets.T13);
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
    public Handle<T9?> WriteHandleT9() => _chunk.WriteHandle(_offsets.T9);
    [ChunkChange]
    public Handle<T10?> WriteHandleT10() => _chunk.WriteHandle(_offsets.T10);
    [ChunkChange]
    public Handle<T11?> WriteHandleT11() => _chunk.WriteHandle(_offsets.T11);
    [ChunkChange]
    public Handle<T12?> WriteHandleT12() => _chunk.WriteHandle(_offsets.T12);
    [ChunkChange]
    public Handle<T13?> WriteHandleT13() => _chunk.WriteHandle(_offsets.T13);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle, out Handle<T13?> t13Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
        t10Handle = _chunk.WriteHandle(_offsets.T10);
        t11Handle = _chunk.WriteHandle(_offsets.T11);
        t12Handle = _chunk.WriteHandle(_offsets.T12);
        t13Handle = _chunk.WriteHandle(_offsets.T13);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle, out Handle<T13?> t13Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
        t10Handle = _chunk.WriteHandle(_offsets.T10);
        t11Handle = _chunk.WriteHandle(_offsets.T11);
        t12Handle = _chunk.WriteHandle(_offsets.T12);
        t13Handle = _chunk.WriteHandle(_offsets.T13);
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.ReadHandle(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.ReadHandle(_offsets.T9);
    public ReadOnlyHandle<T10?> GetHandleReadOnlyT10() => _chunk.ReadHandle(_offsets.T10);
    public ReadOnlyHandle<T11?> GetHandleReadOnlyT11() => _chunk.ReadHandle(_offsets.T11);
    public ReadOnlyHandle<T12?> GetHandleReadOnlyT12() => _chunk.ReadHandle(_offsets.T12);
    public ReadOnlyHandle<T13?> GetHandleReadOnlyT13() => _chunk.ReadHandle(_offsets.T13);
    public ReadOnlyHandle<T14?> GetHandleReadOnlyT14() => _chunk.ReadHandle(_offsets.T14);
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
    public Handle<T9?> WriteHandleT9() => _chunk.WriteHandle(_offsets.T9);
    [ChunkChange]
    public Handle<T10?> WriteHandleT10() => _chunk.WriteHandle(_offsets.T10);
    [ChunkChange]
    public Handle<T11?> WriteHandleT11() => _chunk.WriteHandle(_offsets.T11);
    [ChunkChange]
    public Handle<T12?> WriteHandleT12() => _chunk.WriteHandle(_offsets.T12);
    [ChunkChange]
    public Handle<T13?> WriteHandleT13() => _chunk.WriteHandle(_offsets.T13);
    [ChunkChange]
    public Handle<T14?> WriteHandleT14() => _chunk.WriteHandle(_offsets.T14);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle, out Handle<T13?> t13Handle, out Handle<T14?> t14Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
        t10Handle = _chunk.WriteHandle(_offsets.T10);
        t11Handle = _chunk.WriteHandle(_offsets.T11);
        t12Handle = _chunk.WriteHandle(_offsets.T12);
        t13Handle = _chunk.WriteHandle(_offsets.T13);
        t14Handle = _chunk.WriteHandle(_offsets.T14);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle, out Handle<T13?> t13Handle, out Handle<T14?> t14Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
        t10Handle = _chunk.WriteHandle(_offsets.T10);
        t11Handle = _chunk.WriteHandle(_offsets.T11);
        t12Handle = _chunk.WriteHandle(_offsets.T12);
        t13Handle = _chunk.WriteHandle(_offsets.T13);
        t14Handle = _chunk.WriteHandle(_offsets.T14);
	}
}
public readonly ref struct ChunkWrite<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> offsets)
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
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.ReadHandle(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.ReadHandle(_offsets.T9);
    public ReadOnlyHandle<T10?> GetHandleReadOnlyT10() => _chunk.ReadHandle(_offsets.T10);
    public ReadOnlyHandle<T11?> GetHandleReadOnlyT11() => _chunk.ReadHandle(_offsets.T11);
    public ReadOnlyHandle<T12?> GetHandleReadOnlyT12() => _chunk.ReadHandle(_offsets.T12);
    public ReadOnlyHandle<T13?> GetHandleReadOnlyT13() => _chunk.ReadHandle(_offsets.T13);
    public ReadOnlyHandle<T14?> GetHandleReadOnlyT14() => _chunk.ReadHandle(_offsets.T14);
    public ReadOnlyHandle<T15?> GetHandleReadOnlyT15() => _chunk.ReadHandle(_offsets.T15);
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
    public Handle<T9?> WriteHandleT9() => _chunk.WriteHandle(_offsets.T9);
    [ChunkChange]
    public Handle<T10?> WriteHandleT10() => _chunk.WriteHandle(_offsets.T10);
    [ChunkChange]
    public Handle<T11?> WriteHandleT11() => _chunk.WriteHandle(_offsets.T11);
    [ChunkChange]
    public Handle<T12?> WriteHandleT12() => _chunk.WriteHandle(_offsets.T12);
    [ChunkChange]
    public Handle<T13?> WriteHandleT13() => _chunk.WriteHandle(_offsets.T13);
    [ChunkChange]
    public Handle<T14?> WriteHandleT14() => _chunk.WriteHandle(_offsets.T14);
    [ChunkChange]
    public Handle<T15?> WriteHandleT15() => _chunk.WriteHandle(_offsets.T15);
	
	[ChunkChange]
	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle, out Handle<T13?> t13Handle, out Handle<T14?> t14Handle, out Handle<T15?> t15Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
        t10Handle = _chunk.WriteHandle(_offsets.T10);
        t11Handle = _chunk.WriteHandle(_offsets.T11);
        t12Handle = _chunk.WriteHandle(_offsets.T12);
        t13Handle = _chunk.WriteHandle(_offsets.T13);
        t14Handle = _chunk.WriteHandle(_offsets.T14);
        t15Handle = _chunk.WriteHandle(_offsets.T15);
	}

	[ChunkChange]
	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle, out Handle<T13?> t13Handle, out Handle<T14?> t14Handle, out Handle<T15?> t15Handle)
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
        t9Handle = _chunk.WriteHandle(_offsets.T9);
        t10Handle = _chunk.WriteHandle(_offsets.T10);
        t11Handle = _chunk.WriteHandle(_offsets.T11);
        t12Handle = _chunk.WriteHandle(_offsets.T12);
        t13Handle = _chunk.WriteHandle(_offsets.T13);
        t14Handle = _chunk.WriteHandle(_offsets.T14);
        t15Handle = _chunk.WriteHandle(_offsets.T15);
	}
}
