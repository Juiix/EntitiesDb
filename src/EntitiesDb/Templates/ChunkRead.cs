
namespace EntitiesDb;

public readonly ref struct ChunkRead<T0>(ref readonly Chunk chunk, Offsets<T0> offsets)
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
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
	}
}
public readonly ref struct ChunkRead<T0, T1>(ref readonly Chunk chunk, Offsets<T0, T1> offsets)
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
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
	}
}
public readonly ref struct ChunkRead<T0, T1, T2>(ref readonly Chunk chunk, Offsets<T0, T1, T2> offsets)
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
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
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
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle)
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
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle(_offsets.T0);
        t1Handle = _chunk.ReadHandle(_offsets.T1);
        t2Handle = _chunk.ReadHandle(_offsets.T2);
        t3Handle = _chunk.ReadHandle(_offsets.T3);
        t4Handle = _chunk.ReadHandle(_offsets.T4);
        t5Handle = _chunk.ReadHandle(_offsets.T5);
        t6Handle = _chunk.ReadHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
    public ReadOnlyHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle)
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
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle)
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
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
    public ReadOnlyHandle<T8?> ReadHandleT8() => _chunk.ReadHandle(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle)
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
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle)
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
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
    public ReadOnlyHandle<T9?> ReadHandleT9() => _chunk.ReadHandle(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> offsets)
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
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> ReadHandleT8() => _chunk.ReadHandle(_offsets.T8);
    public ReadOnlyHandle<T9?> ReadHandleT9() => _chunk.ReadHandle(_offsets.T9);
    public ReadOnlyHandle<T10?> ReadHandleT10() => _chunk.ReadHandle(_offsets.T10);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle, out ReadOnlyHandle<T10?> t10Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
        t10Handle = _chunk.ReadHandle(_offsets.T10);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle, out ReadOnlyHandle<T10?> t10Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
        t10Handle = _chunk.ReadHandle(_offsets.T10);
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> offsets)
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
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> ReadHandleT8() => _chunk.ReadHandle(_offsets.T8);
    public ReadOnlyHandle<T9?> ReadHandleT9() => _chunk.ReadHandle(_offsets.T9);
    public ReadOnlyHandle<T10?> ReadHandleT10() => _chunk.ReadHandle(_offsets.T10);
    public ReadOnlyHandle<T11?> ReadHandleT11() => _chunk.ReadHandle(_offsets.T11);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle, out ReadOnlyHandle<T10?> t10Handle, out ReadOnlyHandle<T11?> t11Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
        t10Handle = _chunk.ReadHandle(_offsets.T10);
        t11Handle = _chunk.ReadHandle(_offsets.T11);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle, out ReadOnlyHandle<T10?> t10Handle, out ReadOnlyHandle<T11?> t11Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
        t10Handle = _chunk.ReadHandle(_offsets.T10);
        t11Handle = _chunk.ReadHandle(_offsets.T11);
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> offsets)
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
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> ReadHandleT8() => _chunk.ReadHandle(_offsets.T8);
    public ReadOnlyHandle<T9?> ReadHandleT9() => _chunk.ReadHandle(_offsets.T9);
    public ReadOnlyHandle<T10?> ReadHandleT10() => _chunk.ReadHandle(_offsets.T10);
    public ReadOnlyHandle<T11?> ReadHandleT11() => _chunk.ReadHandle(_offsets.T11);
    public ReadOnlyHandle<T12?> ReadHandleT12() => _chunk.ReadHandle(_offsets.T12);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle, out ReadOnlyHandle<T10?> t10Handle, out ReadOnlyHandle<T11?> t11Handle, out ReadOnlyHandle<T12?> t12Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
        t10Handle = _chunk.ReadHandle(_offsets.T10);
        t11Handle = _chunk.ReadHandle(_offsets.T11);
        t12Handle = _chunk.ReadHandle(_offsets.T12);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle, out ReadOnlyHandle<T10?> t10Handle, out ReadOnlyHandle<T11?> t11Handle, out ReadOnlyHandle<T12?> t12Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
        t10Handle = _chunk.ReadHandle(_offsets.T10);
        t11Handle = _chunk.ReadHandle(_offsets.T11);
        t12Handle = _chunk.ReadHandle(_offsets.T12);
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> offsets)
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
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> ReadHandleT8() => _chunk.ReadHandle(_offsets.T8);
    public ReadOnlyHandle<T9?> ReadHandleT9() => _chunk.ReadHandle(_offsets.T9);
    public ReadOnlyHandle<T10?> ReadHandleT10() => _chunk.ReadHandle(_offsets.T10);
    public ReadOnlyHandle<T11?> ReadHandleT11() => _chunk.ReadHandle(_offsets.T11);
    public ReadOnlyHandle<T12?> ReadHandleT12() => _chunk.ReadHandle(_offsets.T12);
    public ReadOnlyHandle<T13?> ReadHandleT13() => _chunk.ReadHandle(_offsets.T13);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle, out ReadOnlyHandle<T10?> t10Handle, out ReadOnlyHandle<T11?> t11Handle, out ReadOnlyHandle<T12?> t12Handle, out ReadOnlyHandle<T13?> t13Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
        t10Handle = _chunk.ReadHandle(_offsets.T10);
        t11Handle = _chunk.ReadHandle(_offsets.T11);
        t12Handle = _chunk.ReadHandle(_offsets.T12);
        t13Handle = _chunk.ReadHandle(_offsets.T13);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle, out ReadOnlyHandle<T10?> t10Handle, out ReadOnlyHandle<T11?> t11Handle, out ReadOnlyHandle<T12?> t12Handle, out ReadOnlyHandle<T13?> t13Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
        t10Handle = _chunk.ReadHandle(_offsets.T10);
        t11Handle = _chunk.ReadHandle(_offsets.T11);
        t12Handle = _chunk.ReadHandle(_offsets.T12);
        t13Handle = _chunk.ReadHandle(_offsets.T13);
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> offsets)
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
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> ReadHandleT8() => _chunk.ReadHandle(_offsets.T8);
    public ReadOnlyHandle<T9?> ReadHandleT9() => _chunk.ReadHandle(_offsets.T9);
    public ReadOnlyHandle<T10?> ReadHandleT10() => _chunk.ReadHandle(_offsets.T10);
    public ReadOnlyHandle<T11?> ReadHandleT11() => _chunk.ReadHandle(_offsets.T11);
    public ReadOnlyHandle<T12?> ReadHandleT12() => _chunk.ReadHandle(_offsets.T12);
    public ReadOnlyHandle<T13?> ReadHandleT13() => _chunk.ReadHandle(_offsets.T13);
    public ReadOnlyHandle<T14?> ReadHandleT14() => _chunk.ReadHandle(_offsets.T14);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle, out ReadOnlyHandle<T10?> t10Handle, out ReadOnlyHandle<T11?> t11Handle, out ReadOnlyHandle<T12?> t12Handle, out ReadOnlyHandle<T13?> t13Handle, out ReadOnlyHandle<T14?> t14Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
        t10Handle = _chunk.ReadHandle(_offsets.T10);
        t11Handle = _chunk.ReadHandle(_offsets.T11);
        t12Handle = _chunk.ReadHandle(_offsets.T12);
        t13Handle = _chunk.ReadHandle(_offsets.T13);
        t14Handle = _chunk.ReadHandle(_offsets.T14);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle, out ReadOnlyHandle<T10?> t10Handle, out ReadOnlyHandle<T11?> t11Handle, out ReadOnlyHandle<T12?> t12Handle, out ReadOnlyHandle<T13?> t13Handle, out ReadOnlyHandle<T14?> t14Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
        t10Handle = _chunk.ReadHandle(_offsets.T10);
        t11Handle = _chunk.ReadHandle(_offsets.T11);
        t12Handle = _chunk.ReadHandle(_offsets.T12);
        t13Handle = _chunk.ReadHandle(_offsets.T13);
        t14Handle = _chunk.ReadHandle(_offsets.T14);
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> offsets)
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
	public ReadOnlyHandle<T0?> ReadHandleT0() => _chunk.ReadHandle(_offsets.T0);
    public ReadOnlyHandle<T1?> ReadHandleT1() => _chunk.ReadHandle(_offsets.T1);
    public ReadOnlyHandle<T2?> ReadHandleT2() => _chunk.ReadHandle(_offsets.T2);
    public ReadOnlyHandle<T3?> ReadHandleT3() => _chunk.ReadHandle(_offsets.T3);
    public ReadOnlyHandle<T4?> ReadHandleT4() => _chunk.ReadHandle(_offsets.T4);
    public ReadOnlyHandle<T5?> ReadHandleT5() => _chunk.ReadHandle(_offsets.T5);
    public ReadOnlyHandle<T6?> ReadHandleT6() => _chunk.ReadHandle(_offsets.T6);
    public ReadOnlyHandle<T7?> ReadHandleT7() => _chunk.ReadHandle(_offsets.T7);
    public ReadOnlyHandle<T8?> ReadHandleT8() => _chunk.ReadHandle(_offsets.T8);
    public ReadOnlyHandle<T9?> ReadHandleT9() => _chunk.ReadHandle(_offsets.T9);
    public ReadOnlyHandle<T10?> ReadHandleT10() => _chunk.ReadHandle(_offsets.T10);
    public ReadOnlyHandle<T11?> ReadHandleT11() => _chunk.ReadHandle(_offsets.T11);
    public ReadOnlyHandle<T12?> ReadHandleT12() => _chunk.ReadHandle(_offsets.T12);
    public ReadOnlyHandle<T13?> ReadHandleT13() => _chunk.ReadHandle(_offsets.T13);
    public ReadOnlyHandle<T14?> ReadHandleT14() => _chunk.ReadHandle(_offsets.T14);
    public ReadOnlyHandle<T15?> ReadHandleT15() => _chunk.ReadHandle(_offsets.T15);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle, out ReadOnlyHandle<T10?> t10Handle, out ReadOnlyHandle<T11?> t11Handle, out ReadOnlyHandle<T12?> t12Handle, out ReadOnlyHandle<T13?> t13Handle, out ReadOnlyHandle<T14?> t14Handle, out ReadOnlyHandle<T15?> t15Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
        t10Handle = _chunk.ReadHandle(_offsets.T10);
        t11Handle = _chunk.ReadHandle(_offsets.T11);
        t12Handle = _chunk.ReadHandle(_offsets.T12);
        t13Handle = _chunk.ReadHandle(_offsets.T13);
        t14Handle = _chunk.ReadHandle(_offsets.T14);
        t15Handle = _chunk.ReadHandle(_offsets.T15);
	}

	public void Deconstruct(out int length, out ReadOnlyHandle<T0?> t0Handle, out ReadOnlyHandle<T1?> t1Handle, out ReadOnlyHandle<T2?> t2Handle, out ReadOnlyHandle<T3?> t3Handle, out ReadOnlyHandle<T4?> t4Handle, out ReadOnlyHandle<T5?> t5Handle, out ReadOnlyHandle<T6?> t6Handle, out ReadOnlyHandle<T7?> t7Handle, out ReadOnlyHandle<T8?> t8Handle, out ReadOnlyHandle<T9?> t9Handle, out ReadOnlyHandle<T10?> t10Handle, out ReadOnlyHandle<T11?> t11Handle, out ReadOnlyHandle<T12?> t12Handle, out ReadOnlyHandle<T13?> t13Handle, out ReadOnlyHandle<T14?> t14Handle, out ReadOnlyHandle<T15?> t15Handle)
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
        t9Handle = _chunk.ReadHandle(_offsets.T9);
        t10Handle = _chunk.ReadHandle(_offsets.T10);
        t11Handle = _chunk.ReadHandle(_offsets.T11);
        t12Handle = _chunk.ReadHandle(_offsets.T12);
        t13Handle = _chunk.ReadHandle(_offsets.T13);
        t14Handle = _chunk.ReadHandle(_offsets.T14);
        t15Handle = _chunk.ReadHandle(_offsets.T15);
	}
}
