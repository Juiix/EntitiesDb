
namespace EntitiesDb;

public readonly ref struct ChunkMixed1<T0, T1>(ref readonly Chunk chunk, Offsets<T0, T1> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
	public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
	public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
	public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
	public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
	}
}
public readonly ref struct ChunkMixed1<T0, T1, T2>(ref readonly Chunk chunk, Offsets<T0, T1, T2> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
	public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
	public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
	public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
	public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
	}
}
public readonly ref struct ChunkMixed1<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
	public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
	public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
	public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
	public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkMixed1<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
	public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
	public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
	public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
	public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkMixed1<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
	public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
	public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
	public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
	public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkMixed1<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
	public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
	public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
	public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
	public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkMixed1<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
	public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
	public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
	public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
	public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
	public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
	public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
	public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
	public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
	public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
	public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
	public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
	public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
		t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkMixed2<T0, T1, T2>(ref readonly Chunk chunk, Offsets<T0, T1, T2> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
	public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
	public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
	public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
	public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
	}
}
public readonly ref struct ChunkMixed2<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
	public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
	public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
	public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
	public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkMixed2<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
	public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
	public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
	public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
	public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkMixed2<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
	public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
	public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
	public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
	public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkMixed2<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
	public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
	public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
	public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
	public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkMixed2<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
	public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
	public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
	public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
	public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
	public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
	public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
	public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
	public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
	public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
	public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
	public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
	public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
		t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkMixed3<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
	public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
	public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
	public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
	public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkMixed3<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
	public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
	public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
	public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
	public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkMixed3<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
	public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
	public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
	public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
	public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkMixed3<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
	public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
	public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
	public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
	public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkMixed3<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
	public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
	public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
	public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
	public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
	public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
	public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
	public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
	public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
	public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
	public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
	public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
	public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
		t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkMixed4<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
	public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
	public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
	public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
	public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
		t4Handle = _chunk.GetBufferHandle(_offsets.T4);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
		t4Handle = _chunk.GetBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkMixed4<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
	public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
	public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
	public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
	public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
		t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
		t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkMixed4<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
	public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
	public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
	public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
	public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
		t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
		t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkMixed4<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
	public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
	public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
	public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
	public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
		t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
		t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
	public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
	public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
	public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
	public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
		t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
		t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
	public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
	public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
	public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
	public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
		t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
		t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkMixed5<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
	public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
	public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
	public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
	public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
		t5Handle = _chunk.GetBufferHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
		t5Handle = _chunk.GetBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkMixed5<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
	public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
	public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
	public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
	public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
		t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
		t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkMixed5<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
	public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
	public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
	public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
	public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
		t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
		t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
	public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
	public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
	public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
	public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
		t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
		t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
	public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
	public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
	public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
	public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
		t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
		t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkMixed6<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
    public ref T5? GetT5(int index) => ref _chunk.Get(index, _offsets.T5);
	public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
	public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
	public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
	public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
		t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
		t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkMixed6<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
    public ref T5? GetT5(int index) => ref _chunk.Get(index, _offsets.T5);
	public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
	public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
	public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
	public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
		t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
		t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
    public ref T5? GetT5(int index) => ref _chunk.Get(index, _offsets.T5);
	public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
	public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
	public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
	public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
		t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
		t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
    public ref T5? GetT5(int index) => ref _chunk.Get(index, _offsets.T5);
	public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
	public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
	public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
	public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
		t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
		t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkMixed7<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
    public ref T5? GetT5(int index) => ref _chunk.Get(index, _offsets.T5);
    public ref T6? GetT6(int index) => ref _chunk.Get(index, _offsets.T6);
	public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
	public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
	public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
	public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
		t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
		t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
    public ref T5? GetT5(int index) => ref _chunk.Get(index, _offsets.T5);
    public ref T6? GetT6(int index) => ref _chunk.Get(index, _offsets.T6);
	public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
	public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
	public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
	public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
		t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
		t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
    public ref T5? GetT5(int index) => ref _chunk.Get(index, _offsets.T5);
    public ref T6? GetT6(int index) => ref _chunk.Get(index, _offsets.T6);
	public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
	public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
	public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
	public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
		t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
		t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
    public ref T5? GetT5(int index) => ref _chunk.Get(index, _offsets.T5);
    public ref T6? GetT6(int index) => ref _chunk.Get(index, _offsets.T6);
    public ref T7? GetT7(int index) => ref _chunk.Get(index, _offsets.T7);
	public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
    public ref readonly T7? GetReadOnlyT7(int index) => ref _chunk.GetReadOnly(index, _offsets.T7);
	public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
    public Handle<T7?> GetHandleT7() => _chunk.GetHandle(_offsets.T7);
	public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.GetHandleReadOnly(_offsets.T7);
	public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
        t7Handle = _chunk.GetHandle(_offsets.T7);
		t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
        t7Handle = _chunk.GetHandle(_offsets.T7);
		t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}
}
public readonly ref struct ChunkMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
    public ref T5? GetT5(int index) => ref _chunk.Get(index, _offsets.T5);
    public ref T6? GetT6(int index) => ref _chunk.Get(index, _offsets.T6);
    public ref T7? GetT7(int index) => ref _chunk.Get(index, _offsets.T7);
	public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
    public ref readonly T7? GetReadOnlyT7(int index) => ref _chunk.GetReadOnly(index, _offsets.T7);
	public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
    public Handle<T7?> GetHandleT7() => _chunk.GetHandle(_offsets.T7);
	public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.GetHandleReadOnly(_offsets.T7);
	public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
        t7Handle = _chunk.GetHandle(_offsets.T7);
		t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
        t7Handle = _chunk.GetHandle(_offsets.T7);
		t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}
}
public readonly ref struct ChunkMixed9<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
    public ref T5? GetT5(int index) => ref _chunk.Get(index, _offsets.T5);
    public ref T6? GetT6(int index) => ref _chunk.Get(index, _offsets.T6);
    public ref T7? GetT7(int index) => ref _chunk.Get(index, _offsets.T7);
    public ref T8? GetT8(int index) => ref _chunk.Get(index, _offsets.T8);
	public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
    public ref readonly T7? GetReadOnlyT7(int index) => ref _chunk.GetReadOnly(index, _offsets.T7);
    public ref readonly T8? GetReadOnlyT8(int index) => ref _chunk.GetReadOnly(index, _offsets.T8);
	public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
    public Handle<T7?> GetHandleT7() => _chunk.GetHandle(_offsets.T7);
    public Handle<T8?> GetHandleT8() => _chunk.GetHandle(_offsets.T8);
	public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.GetHandleReadOnly(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.GetHandleReadOnly(_offsets.T8);
	public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
        t7Handle = _chunk.GetHandle(_offsets.T7);
        t8Handle = _chunk.GetHandle(_offsets.T8);
		t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
        t7Handle = _chunk.GetHandle(_offsets.T7);
        t8Handle = _chunk.GetHandle(_offsets.T8);
		t9Handle = _chunk.GetBufferHandle(_offsets.T9);
	}
}
