
namespace EntitiesDb;

public readonly ref struct ChunkRead<T0>(ref readonly Chunk chunk)
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

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
	}
}
public readonly ref struct ChunkRead<T0, T1>(ref readonly Chunk chunk)
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

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
	}
}
public readonly ref struct ChunkRead<T0, T1, T2>(ref readonly Chunk chunk)
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

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3>(ref readonly Chunk chunk)
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

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4>(ref readonly Chunk chunk)
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

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk)
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

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.EntityHandle();
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk)
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

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle)
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
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.ReadHandle<T0>();
        t1Handle = _chunk.ReadHandle<T1>();
        t2Handle = _chunk.ReadHandle<T2>();
        t3Handle = _chunk.ReadHandle<T3>();
        t4Handle = _chunk.ReadHandle<T4>();
        t5Handle = _chunk.ReadHandle<T5>();
        t6Handle = _chunk.ReadHandle<T6>();
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk)
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

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle)
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
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle)
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
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk)
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

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle)
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
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle)
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
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk)
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
    public ReadHandle<T9?> ReadHandleT9() => _chunk.ReadHandle<T9>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref readonly Chunk chunk)
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
    public ReadHandle<T9?> ReadHandleT9() => _chunk.ReadHandle<T9>();
    public ReadHandle<T10?> ReadHandleT10() => _chunk.ReadHandle<T10>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle, out ReadHandle<T10?> t10Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
        t10Handle = _chunk.ReadHandle<T10>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle, out ReadHandle<T10?> t10Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
        t10Handle = _chunk.ReadHandle<T10>();
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref readonly Chunk chunk)
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
    public ReadHandle<T9?> ReadHandleT9() => _chunk.ReadHandle<T9>();
    public ReadHandle<T10?> ReadHandleT10() => _chunk.ReadHandle<T10>();
    public ReadHandle<T11?> ReadHandleT11() => _chunk.ReadHandle<T11>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle, out ReadHandle<T10?> t10Handle, out ReadHandle<T11?> t11Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
        t10Handle = _chunk.ReadHandle<T10>();
        t11Handle = _chunk.ReadHandle<T11>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle, out ReadHandle<T10?> t10Handle, out ReadHandle<T11?> t11Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
        t10Handle = _chunk.ReadHandle<T10>();
        t11Handle = _chunk.ReadHandle<T11>();
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref readonly Chunk chunk)
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
    public ReadHandle<T9?> ReadHandleT9() => _chunk.ReadHandle<T9>();
    public ReadHandle<T10?> ReadHandleT10() => _chunk.ReadHandle<T10>();
    public ReadHandle<T11?> ReadHandleT11() => _chunk.ReadHandle<T11>();
    public ReadHandle<T12?> ReadHandleT12() => _chunk.ReadHandle<T12>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle, out ReadHandle<T10?> t10Handle, out ReadHandle<T11?> t11Handle, out ReadHandle<T12?> t12Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
        t10Handle = _chunk.ReadHandle<T10>();
        t11Handle = _chunk.ReadHandle<T11>();
        t12Handle = _chunk.ReadHandle<T12>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle, out ReadHandle<T10?> t10Handle, out ReadHandle<T11?> t11Handle, out ReadHandle<T12?> t12Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
        t10Handle = _chunk.ReadHandle<T10>();
        t11Handle = _chunk.ReadHandle<T11>();
        t12Handle = _chunk.ReadHandle<T12>();
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref readonly Chunk chunk)
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
    public ReadHandle<T9?> ReadHandleT9() => _chunk.ReadHandle<T9>();
    public ReadHandle<T10?> ReadHandleT10() => _chunk.ReadHandle<T10>();
    public ReadHandle<T11?> ReadHandleT11() => _chunk.ReadHandle<T11>();
    public ReadHandle<T12?> ReadHandleT12() => _chunk.ReadHandle<T12>();
    public ReadHandle<T13?> ReadHandleT13() => _chunk.ReadHandle<T13>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle, out ReadHandle<T10?> t10Handle, out ReadHandle<T11?> t11Handle, out ReadHandle<T12?> t12Handle, out ReadHandle<T13?> t13Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
        t10Handle = _chunk.ReadHandle<T10>();
        t11Handle = _chunk.ReadHandle<T11>();
        t12Handle = _chunk.ReadHandle<T12>();
        t13Handle = _chunk.ReadHandle<T13>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle, out ReadHandle<T10?> t10Handle, out ReadHandle<T11?> t11Handle, out ReadHandle<T12?> t12Handle, out ReadHandle<T13?> t13Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
        t10Handle = _chunk.ReadHandle<T10>();
        t11Handle = _chunk.ReadHandle<T11>();
        t12Handle = _chunk.ReadHandle<T12>();
        t13Handle = _chunk.ReadHandle<T13>();
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref readonly Chunk chunk)
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
    public ReadHandle<T9?> ReadHandleT9() => _chunk.ReadHandle<T9>();
    public ReadHandle<T10?> ReadHandleT10() => _chunk.ReadHandle<T10>();
    public ReadHandle<T11?> ReadHandleT11() => _chunk.ReadHandle<T11>();
    public ReadHandle<T12?> ReadHandleT12() => _chunk.ReadHandle<T12>();
    public ReadHandle<T13?> ReadHandleT13() => _chunk.ReadHandle<T13>();
    public ReadHandle<T14?> ReadHandleT14() => _chunk.ReadHandle<T14>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle, out ReadHandle<T10?> t10Handle, out ReadHandle<T11?> t11Handle, out ReadHandle<T12?> t12Handle, out ReadHandle<T13?> t13Handle, out ReadHandle<T14?> t14Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
        t10Handle = _chunk.ReadHandle<T10>();
        t11Handle = _chunk.ReadHandle<T11>();
        t12Handle = _chunk.ReadHandle<T12>();
        t13Handle = _chunk.ReadHandle<T13>();
        t14Handle = _chunk.ReadHandle<T14>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle, out ReadHandle<T10?> t10Handle, out ReadHandle<T11?> t11Handle, out ReadHandle<T12?> t12Handle, out ReadHandle<T13?> t13Handle, out ReadHandle<T14?> t14Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
        t10Handle = _chunk.ReadHandle<T10>();
        t11Handle = _chunk.ReadHandle<T11>();
        t12Handle = _chunk.ReadHandle<T12>();
        t13Handle = _chunk.ReadHandle<T13>();
        t14Handle = _chunk.ReadHandle<T14>();
	}
}
public readonly ref struct ChunkRead<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref readonly Chunk chunk)
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
    public ReadHandle<T9?> ReadHandleT9() => _chunk.ReadHandle<T9>();
    public ReadHandle<T10?> ReadHandleT10() => _chunk.ReadHandle<T10>();
    public ReadHandle<T11?> ReadHandleT11() => _chunk.ReadHandle<T11>();
    public ReadHandle<T12?> ReadHandleT12() => _chunk.ReadHandle<T12>();
    public ReadHandle<T13?> ReadHandleT13() => _chunk.ReadHandle<T13>();
    public ReadHandle<T14?> ReadHandleT14() => _chunk.ReadHandle<T14>();
    public ReadHandle<T15?> ReadHandleT15() => _chunk.ReadHandle<T15>();

	public void Deconstruct(out int length, out ReadHandle<Entity> entities, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle, out ReadHandle<T10?> t10Handle, out ReadHandle<T11?> t11Handle, out ReadHandle<T12?> t12Handle, out ReadHandle<T13?> t13Handle, out ReadHandle<T14?> t14Handle, out ReadHandle<T15?> t15Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
        t10Handle = _chunk.ReadHandle<T10>();
        t11Handle = _chunk.ReadHandle<T11>();
        t12Handle = _chunk.ReadHandle<T12>();
        t13Handle = _chunk.ReadHandle<T13>();
        t14Handle = _chunk.ReadHandle<T14>();
        t15Handle = _chunk.ReadHandle<T15>();
	}

	public void Deconstruct(out int length, out ReadHandle<T0?> t0Handle, out ReadHandle<T1?> t1Handle, out ReadHandle<T2?> t2Handle, out ReadHandle<T3?> t3Handle, out ReadHandle<T4?> t4Handle, out ReadHandle<T5?> t5Handle, out ReadHandle<T6?> t6Handle, out ReadHandle<T7?> t7Handle, out ReadHandle<T8?> t8Handle, out ReadHandle<T9?> t9Handle, out ReadHandle<T10?> t10Handle, out ReadHandle<T11?> t11Handle, out ReadHandle<T12?> t12Handle, out ReadHandle<T13?> t13Handle, out ReadHandle<T14?> t14Handle, out ReadHandle<T15?> t15Handle)
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
        t9Handle = _chunk.ReadHandle<T9>();
        t10Handle = _chunk.ReadHandle<T10>();
        t11Handle = _chunk.ReadHandle<T11>();
        t12Handle = _chunk.ReadHandle<T12>();
        t13Handle = _chunk.ReadHandle<T13>();
        t14Handle = _chunk.ReadHandle<T14>();
        t15Handle = _chunk.ReadHandle<T15>();
	}
}
