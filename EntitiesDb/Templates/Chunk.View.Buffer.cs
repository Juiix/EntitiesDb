
namespace EntitiesDb;

public readonly ref struct ChunkBuffer<T0>(ref readonly Chunk chunk, Offsets<T0> offsets)
	where T0 : unmanaged
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
	}
}
public readonly ref struct ChunkBuffer<T0, T1>(ref readonly Chunk chunk, Offsets<T0, T1> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
	}
}
public readonly ref struct ChunkBuffer<T0, T1, T2>(ref readonly Chunk chunk, Offsets<T0, T1, T2> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
	}
}
public readonly ref struct ChunkBuffer<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
	}
}
public readonly ref struct ChunkBuffer<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
	}
}
public readonly ref struct ChunkBuffer<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
	}
}
public readonly ref struct ChunkBuffer<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
	}
}
public readonly ref struct ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
	}
}
public readonly ref struct ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
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
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
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
public readonly ref struct ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
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
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
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

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
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
public readonly ref struct ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> offsets)
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
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
    public DynamicBuffer<T10> GetBufferT10(int index) => _chunk.GetBuffer(index, _offsets.T10);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
    public ReadOnlyBuffer<T10> GetBufferReadOnlyT10(int index) => _chunk.GetBufferReadOnly(index, _offsets.T10);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
    public DynamicBufferHandle<T10> GetBufferHandleT10() => _chunk.GetBufferHandle(_offsets.T10);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);
    public ReadOnlyBufferHandle<T10> GetBufferHandleReadOnlyT10() => _chunk.GetBufferHandleReadOnly(_offsets.T10);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
        t10Handle = _chunk.GetBufferHandle(_offsets.T10);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
        t10Handle = _chunk.GetBufferHandle(_offsets.T10);
	}
}
public readonly ref struct ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> offsets)
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
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
    public DynamicBuffer<T10> GetBufferT10(int index) => _chunk.GetBuffer(index, _offsets.T10);
    public DynamicBuffer<T11> GetBufferT11(int index) => _chunk.GetBuffer(index, _offsets.T11);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
    public ReadOnlyBuffer<T10> GetBufferReadOnlyT10(int index) => _chunk.GetBufferReadOnly(index, _offsets.T10);
    public ReadOnlyBuffer<T11> GetBufferReadOnlyT11(int index) => _chunk.GetBufferReadOnly(index, _offsets.T11);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
    public DynamicBufferHandle<T10> GetBufferHandleT10() => _chunk.GetBufferHandle(_offsets.T10);
    public DynamicBufferHandle<T11> GetBufferHandleT11() => _chunk.GetBufferHandle(_offsets.T11);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);
    public ReadOnlyBufferHandle<T10> GetBufferHandleReadOnlyT10() => _chunk.GetBufferHandleReadOnly(_offsets.T10);
    public ReadOnlyBufferHandle<T11> GetBufferHandleReadOnlyT11() => _chunk.GetBufferHandleReadOnly(_offsets.T11);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
        t10Handle = _chunk.GetBufferHandle(_offsets.T10);
        t11Handle = _chunk.GetBufferHandle(_offsets.T11);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
        t10Handle = _chunk.GetBufferHandle(_offsets.T10);
        t11Handle = _chunk.GetBufferHandle(_offsets.T11);
	}
}
public readonly ref struct ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> offsets)
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
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
    public DynamicBuffer<T10> GetBufferT10(int index) => _chunk.GetBuffer(index, _offsets.T10);
    public DynamicBuffer<T11> GetBufferT11(int index) => _chunk.GetBuffer(index, _offsets.T11);
    public DynamicBuffer<T12> GetBufferT12(int index) => _chunk.GetBuffer(index, _offsets.T12);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
    public ReadOnlyBuffer<T10> GetBufferReadOnlyT10(int index) => _chunk.GetBufferReadOnly(index, _offsets.T10);
    public ReadOnlyBuffer<T11> GetBufferReadOnlyT11(int index) => _chunk.GetBufferReadOnly(index, _offsets.T11);
    public ReadOnlyBuffer<T12> GetBufferReadOnlyT12(int index) => _chunk.GetBufferReadOnly(index, _offsets.T12);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
    public DynamicBufferHandle<T10> GetBufferHandleT10() => _chunk.GetBufferHandle(_offsets.T10);
    public DynamicBufferHandle<T11> GetBufferHandleT11() => _chunk.GetBufferHandle(_offsets.T11);
    public DynamicBufferHandle<T12> GetBufferHandleT12() => _chunk.GetBufferHandle(_offsets.T12);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);
    public ReadOnlyBufferHandle<T10> GetBufferHandleReadOnlyT10() => _chunk.GetBufferHandleReadOnly(_offsets.T10);
    public ReadOnlyBufferHandle<T11> GetBufferHandleReadOnlyT11() => _chunk.GetBufferHandleReadOnly(_offsets.T11);
    public ReadOnlyBufferHandle<T12> GetBufferHandleReadOnlyT12() => _chunk.GetBufferHandleReadOnly(_offsets.T12);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
        t10Handle = _chunk.GetBufferHandle(_offsets.T10);
        t11Handle = _chunk.GetBufferHandle(_offsets.T11);
        t12Handle = _chunk.GetBufferHandle(_offsets.T12);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
        t10Handle = _chunk.GetBufferHandle(_offsets.T10);
        t11Handle = _chunk.GetBufferHandle(_offsets.T11);
        t12Handle = _chunk.GetBufferHandle(_offsets.T12);
	}
}
public readonly ref struct ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> offsets)
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
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
    public DynamicBuffer<T10> GetBufferT10(int index) => _chunk.GetBuffer(index, _offsets.T10);
    public DynamicBuffer<T11> GetBufferT11(int index) => _chunk.GetBuffer(index, _offsets.T11);
    public DynamicBuffer<T12> GetBufferT12(int index) => _chunk.GetBuffer(index, _offsets.T12);
    public DynamicBuffer<T13> GetBufferT13(int index) => _chunk.GetBuffer(index, _offsets.T13);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
    public ReadOnlyBuffer<T10> GetBufferReadOnlyT10(int index) => _chunk.GetBufferReadOnly(index, _offsets.T10);
    public ReadOnlyBuffer<T11> GetBufferReadOnlyT11(int index) => _chunk.GetBufferReadOnly(index, _offsets.T11);
    public ReadOnlyBuffer<T12> GetBufferReadOnlyT12(int index) => _chunk.GetBufferReadOnly(index, _offsets.T12);
    public ReadOnlyBuffer<T13> GetBufferReadOnlyT13(int index) => _chunk.GetBufferReadOnly(index, _offsets.T13);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
    public DynamicBufferHandle<T10> GetBufferHandleT10() => _chunk.GetBufferHandle(_offsets.T10);
    public DynamicBufferHandle<T11> GetBufferHandleT11() => _chunk.GetBufferHandle(_offsets.T11);
    public DynamicBufferHandle<T12> GetBufferHandleT12() => _chunk.GetBufferHandle(_offsets.T12);
    public DynamicBufferHandle<T13> GetBufferHandleT13() => _chunk.GetBufferHandle(_offsets.T13);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);
    public ReadOnlyBufferHandle<T10> GetBufferHandleReadOnlyT10() => _chunk.GetBufferHandleReadOnly(_offsets.T10);
    public ReadOnlyBufferHandle<T11> GetBufferHandleReadOnlyT11() => _chunk.GetBufferHandleReadOnly(_offsets.T11);
    public ReadOnlyBufferHandle<T12> GetBufferHandleReadOnlyT12() => _chunk.GetBufferHandleReadOnly(_offsets.T12);
    public ReadOnlyBufferHandle<T13> GetBufferHandleReadOnlyT13() => _chunk.GetBufferHandleReadOnly(_offsets.T13);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle, out DynamicBufferHandle<T13> t13Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
        t10Handle = _chunk.GetBufferHandle(_offsets.T10);
        t11Handle = _chunk.GetBufferHandle(_offsets.T11);
        t12Handle = _chunk.GetBufferHandle(_offsets.T12);
        t13Handle = _chunk.GetBufferHandle(_offsets.T13);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle, out DynamicBufferHandle<T13> t13Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
        t10Handle = _chunk.GetBufferHandle(_offsets.T10);
        t11Handle = _chunk.GetBufferHandle(_offsets.T11);
        t12Handle = _chunk.GetBufferHandle(_offsets.T12);
        t13Handle = _chunk.GetBufferHandle(_offsets.T13);
	}
}
public readonly ref struct ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> offsets)
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
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
    public DynamicBuffer<T10> GetBufferT10(int index) => _chunk.GetBuffer(index, _offsets.T10);
    public DynamicBuffer<T11> GetBufferT11(int index) => _chunk.GetBuffer(index, _offsets.T11);
    public DynamicBuffer<T12> GetBufferT12(int index) => _chunk.GetBuffer(index, _offsets.T12);
    public DynamicBuffer<T13> GetBufferT13(int index) => _chunk.GetBuffer(index, _offsets.T13);
    public DynamicBuffer<T14> GetBufferT14(int index) => _chunk.GetBuffer(index, _offsets.T14);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
    public ReadOnlyBuffer<T10> GetBufferReadOnlyT10(int index) => _chunk.GetBufferReadOnly(index, _offsets.T10);
    public ReadOnlyBuffer<T11> GetBufferReadOnlyT11(int index) => _chunk.GetBufferReadOnly(index, _offsets.T11);
    public ReadOnlyBuffer<T12> GetBufferReadOnlyT12(int index) => _chunk.GetBufferReadOnly(index, _offsets.T12);
    public ReadOnlyBuffer<T13> GetBufferReadOnlyT13(int index) => _chunk.GetBufferReadOnly(index, _offsets.T13);
    public ReadOnlyBuffer<T14> GetBufferReadOnlyT14(int index) => _chunk.GetBufferReadOnly(index, _offsets.T14);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
    public DynamicBufferHandle<T10> GetBufferHandleT10() => _chunk.GetBufferHandle(_offsets.T10);
    public DynamicBufferHandle<T11> GetBufferHandleT11() => _chunk.GetBufferHandle(_offsets.T11);
    public DynamicBufferHandle<T12> GetBufferHandleT12() => _chunk.GetBufferHandle(_offsets.T12);
    public DynamicBufferHandle<T13> GetBufferHandleT13() => _chunk.GetBufferHandle(_offsets.T13);
    public DynamicBufferHandle<T14> GetBufferHandleT14() => _chunk.GetBufferHandle(_offsets.T14);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);
    public ReadOnlyBufferHandle<T10> GetBufferHandleReadOnlyT10() => _chunk.GetBufferHandleReadOnly(_offsets.T10);
    public ReadOnlyBufferHandle<T11> GetBufferHandleReadOnlyT11() => _chunk.GetBufferHandleReadOnly(_offsets.T11);
    public ReadOnlyBufferHandle<T12> GetBufferHandleReadOnlyT12() => _chunk.GetBufferHandleReadOnly(_offsets.T12);
    public ReadOnlyBufferHandle<T13> GetBufferHandleReadOnlyT13() => _chunk.GetBufferHandleReadOnly(_offsets.T13);
    public ReadOnlyBufferHandle<T14> GetBufferHandleReadOnlyT14() => _chunk.GetBufferHandleReadOnly(_offsets.T14);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle, out DynamicBufferHandle<T13> t13Handle, out DynamicBufferHandle<T14> t14Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
        t10Handle = _chunk.GetBufferHandle(_offsets.T10);
        t11Handle = _chunk.GetBufferHandle(_offsets.T11);
        t12Handle = _chunk.GetBufferHandle(_offsets.T12);
        t13Handle = _chunk.GetBufferHandle(_offsets.T13);
        t14Handle = _chunk.GetBufferHandle(_offsets.T14);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle, out DynamicBufferHandle<T13> t13Handle, out DynamicBufferHandle<T14> t14Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
        t10Handle = _chunk.GetBufferHandle(_offsets.T10);
        t11Handle = _chunk.GetBufferHandle(_offsets.T11);
        t12Handle = _chunk.GetBufferHandle(_offsets.T12);
        t13Handle = _chunk.GetBufferHandle(_offsets.T13);
        t14Handle = _chunk.GetBufferHandle(_offsets.T14);
	}
}
public readonly ref struct ChunkBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> offsets)
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
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public DynamicBuffer<T0> GetBufferT0(int index) => _chunk.GetBuffer(index, _offsets.T0);
    public DynamicBuffer<T1> GetBufferT1(int index) => _chunk.GetBuffer(index, _offsets.T1);
    public DynamicBuffer<T2> GetBufferT2(int index) => _chunk.GetBuffer(index, _offsets.T2);
    public DynamicBuffer<T3> GetBufferT3(int index) => _chunk.GetBuffer(index, _offsets.T3);
    public DynamicBuffer<T4> GetBufferT4(int index) => _chunk.GetBuffer(index, _offsets.T4);
    public DynamicBuffer<T5> GetBufferT5(int index) => _chunk.GetBuffer(index, _offsets.T5);
    public DynamicBuffer<T6> GetBufferT6(int index) => _chunk.GetBuffer(index, _offsets.T6);
    public DynamicBuffer<T7> GetBufferT7(int index) => _chunk.GetBuffer(index, _offsets.T7);
    public DynamicBuffer<T8> GetBufferT8(int index) => _chunk.GetBuffer(index, _offsets.T8);
    public DynamicBuffer<T9> GetBufferT9(int index) => _chunk.GetBuffer(index, _offsets.T9);
    public DynamicBuffer<T10> GetBufferT10(int index) => _chunk.GetBuffer(index, _offsets.T10);
    public DynamicBuffer<T11> GetBufferT11(int index) => _chunk.GetBuffer(index, _offsets.T11);
    public DynamicBuffer<T12> GetBufferT12(int index) => _chunk.GetBuffer(index, _offsets.T12);
    public DynamicBuffer<T13> GetBufferT13(int index) => _chunk.GetBuffer(index, _offsets.T13);
    public DynamicBuffer<T14> GetBufferT14(int index) => _chunk.GetBuffer(index, _offsets.T14);
    public DynamicBuffer<T15> GetBufferT15(int index) => _chunk.GetBuffer(index, _offsets.T15);
	public ReadOnlyBuffer<T0> GetBufferReadOnlyT0(int index) => _chunk.GetBufferReadOnly(index, _offsets.T0);
    public ReadOnlyBuffer<T1> GetBufferReadOnlyT1(int index) => _chunk.GetBufferReadOnly(index, _offsets.T1);
    public ReadOnlyBuffer<T2> GetBufferReadOnlyT2(int index) => _chunk.GetBufferReadOnly(index, _offsets.T2);
    public ReadOnlyBuffer<T3> GetBufferReadOnlyT3(int index) => _chunk.GetBufferReadOnly(index, _offsets.T3);
    public ReadOnlyBuffer<T4> GetBufferReadOnlyT4(int index) => _chunk.GetBufferReadOnly(index, _offsets.T4);
    public ReadOnlyBuffer<T5> GetBufferReadOnlyT5(int index) => _chunk.GetBufferReadOnly(index, _offsets.T5);
    public ReadOnlyBuffer<T6> GetBufferReadOnlyT6(int index) => _chunk.GetBufferReadOnly(index, _offsets.T6);
    public ReadOnlyBuffer<T7> GetBufferReadOnlyT7(int index) => _chunk.GetBufferReadOnly(index, _offsets.T7);
    public ReadOnlyBuffer<T8> GetBufferReadOnlyT8(int index) => _chunk.GetBufferReadOnly(index, _offsets.T8);
    public ReadOnlyBuffer<T9> GetBufferReadOnlyT9(int index) => _chunk.GetBufferReadOnly(index, _offsets.T9);
    public ReadOnlyBuffer<T10> GetBufferReadOnlyT10(int index) => _chunk.GetBufferReadOnly(index, _offsets.T10);
    public ReadOnlyBuffer<T11> GetBufferReadOnlyT11(int index) => _chunk.GetBufferReadOnly(index, _offsets.T11);
    public ReadOnlyBuffer<T12> GetBufferReadOnlyT12(int index) => _chunk.GetBufferReadOnly(index, _offsets.T12);
    public ReadOnlyBuffer<T13> GetBufferReadOnlyT13(int index) => _chunk.GetBufferReadOnly(index, _offsets.T13);
    public ReadOnlyBuffer<T14> GetBufferReadOnlyT14(int index) => _chunk.GetBufferReadOnly(index, _offsets.T14);
    public ReadOnlyBuffer<T15> GetBufferReadOnlyT15(int index) => _chunk.GetBufferReadOnly(index, _offsets.T15);
	public DynamicBufferHandle<T0> GetBufferHandleT0() => _chunk.GetBufferHandle(_offsets.T0);
    public DynamicBufferHandle<T1> GetBufferHandleT1() => _chunk.GetBufferHandle(_offsets.T1);
    public DynamicBufferHandle<T2> GetBufferHandleT2() => _chunk.GetBufferHandle(_offsets.T2);
    public DynamicBufferHandle<T3> GetBufferHandleT3() => _chunk.GetBufferHandle(_offsets.T3);
    public DynamicBufferHandle<T4> GetBufferHandleT4() => _chunk.GetBufferHandle(_offsets.T4);
    public DynamicBufferHandle<T5> GetBufferHandleT5() => _chunk.GetBufferHandle(_offsets.T5);
    public DynamicBufferHandle<T6> GetBufferHandleT6() => _chunk.GetBufferHandle(_offsets.T6);
    public DynamicBufferHandle<T7> GetBufferHandleT7() => _chunk.GetBufferHandle(_offsets.T7);
    public DynamicBufferHandle<T8> GetBufferHandleT8() => _chunk.GetBufferHandle(_offsets.T8);
    public DynamicBufferHandle<T9> GetBufferHandleT9() => _chunk.GetBufferHandle(_offsets.T9);
    public DynamicBufferHandle<T10> GetBufferHandleT10() => _chunk.GetBufferHandle(_offsets.T10);
    public DynamicBufferHandle<T11> GetBufferHandleT11() => _chunk.GetBufferHandle(_offsets.T11);
    public DynamicBufferHandle<T12> GetBufferHandleT12() => _chunk.GetBufferHandle(_offsets.T12);
    public DynamicBufferHandle<T13> GetBufferHandleT13() => _chunk.GetBufferHandle(_offsets.T13);
    public DynamicBufferHandle<T14> GetBufferHandleT14() => _chunk.GetBufferHandle(_offsets.T14);
    public DynamicBufferHandle<T15> GetBufferHandleT15() => _chunk.GetBufferHandle(_offsets.T15);
	public ReadOnlyBufferHandle<T0> GetBufferHandleReadOnlyT0() => _chunk.GetBufferHandleReadOnly(_offsets.T0);
    public ReadOnlyBufferHandle<T1> GetBufferHandleReadOnlyT1() => _chunk.GetBufferHandleReadOnly(_offsets.T1);
    public ReadOnlyBufferHandle<T2> GetBufferHandleReadOnlyT2() => _chunk.GetBufferHandleReadOnly(_offsets.T2);
    public ReadOnlyBufferHandle<T3> GetBufferHandleReadOnlyT3() => _chunk.GetBufferHandleReadOnly(_offsets.T3);
    public ReadOnlyBufferHandle<T4> GetBufferHandleReadOnlyT4() => _chunk.GetBufferHandleReadOnly(_offsets.T4);
    public ReadOnlyBufferHandle<T5> GetBufferHandleReadOnlyT5() => _chunk.GetBufferHandleReadOnly(_offsets.T5);
    public ReadOnlyBufferHandle<T6> GetBufferHandleReadOnlyT6() => _chunk.GetBufferHandleReadOnly(_offsets.T6);
    public ReadOnlyBufferHandle<T7> GetBufferHandleReadOnlyT7() => _chunk.GetBufferHandleReadOnly(_offsets.T7);
    public ReadOnlyBufferHandle<T8> GetBufferHandleReadOnlyT8() => _chunk.GetBufferHandleReadOnly(_offsets.T8);
    public ReadOnlyBufferHandle<T9> GetBufferHandleReadOnlyT9() => _chunk.GetBufferHandleReadOnly(_offsets.T9);
    public ReadOnlyBufferHandle<T10> GetBufferHandleReadOnlyT10() => _chunk.GetBufferHandleReadOnly(_offsets.T10);
    public ReadOnlyBufferHandle<T11> GetBufferHandleReadOnlyT11() => _chunk.GetBufferHandleReadOnly(_offsets.T11);
    public ReadOnlyBufferHandle<T12> GetBufferHandleReadOnlyT12() => _chunk.GetBufferHandleReadOnly(_offsets.T12);
    public ReadOnlyBufferHandle<T13> GetBufferHandleReadOnlyT13() => _chunk.GetBufferHandleReadOnly(_offsets.T13);
    public ReadOnlyBufferHandle<T14> GetBufferHandleReadOnlyT14() => _chunk.GetBufferHandleReadOnly(_offsets.T14);
    public ReadOnlyBufferHandle<T15> GetBufferHandleReadOnlyT15() => _chunk.GetBufferHandleReadOnly(_offsets.T15);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle, out DynamicBufferHandle<T13> t13Handle, out DynamicBufferHandle<T14> t14Handle, out DynamicBufferHandle<T15> t15Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
        t10Handle = _chunk.GetBufferHandle(_offsets.T10);
        t11Handle = _chunk.GetBufferHandle(_offsets.T11);
        t12Handle = _chunk.GetBufferHandle(_offsets.T12);
        t13Handle = _chunk.GetBufferHandle(_offsets.T13);
        t14Handle = _chunk.GetBufferHandle(_offsets.T14);
        t15Handle = _chunk.GetBufferHandle(_offsets.T15);
	}

	public void Deconstruct(out int length, out DynamicBufferHandle<T0> t0Handle, out DynamicBufferHandle<T1> t1Handle, out DynamicBufferHandle<T2> t2Handle, out DynamicBufferHandle<T3> t3Handle, out DynamicBufferHandle<T4> t4Handle, out DynamicBufferHandle<T5> t5Handle, out DynamicBufferHandle<T6> t6Handle, out DynamicBufferHandle<T7> t7Handle, out DynamicBufferHandle<T8> t8Handle, out DynamicBufferHandle<T9> t9Handle, out DynamicBufferHandle<T10> t10Handle, out DynamicBufferHandle<T11> t11Handle, out DynamicBufferHandle<T12> t12Handle, out DynamicBufferHandle<T13> t13Handle, out DynamicBufferHandle<T14> t14Handle, out DynamicBufferHandle<T15> t15Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetBufferHandle(_offsets.T0);
        t1Handle = _chunk.GetBufferHandle(_offsets.T1);
        t2Handle = _chunk.GetBufferHandle(_offsets.T2);
        t3Handle = _chunk.GetBufferHandle(_offsets.T3);
        t4Handle = _chunk.GetBufferHandle(_offsets.T4);
        t5Handle = _chunk.GetBufferHandle(_offsets.T5);
        t6Handle = _chunk.GetBufferHandle(_offsets.T6);
        t7Handle = _chunk.GetBufferHandle(_offsets.T7);
        t8Handle = _chunk.GetBufferHandle(_offsets.T8);
        t9Handle = _chunk.GetBufferHandle(_offsets.T9);
        t10Handle = _chunk.GetBufferHandle(_offsets.T10);
        t11Handle = _chunk.GetBufferHandle(_offsets.T11);
        t12Handle = _chunk.GetBufferHandle(_offsets.T12);
        t13Handle = _chunk.GetBufferHandle(_offsets.T13);
        t14Handle = _chunk.GetBufferHandle(_offsets.T14);
        t15Handle = _chunk.GetBufferHandle(_offsets.T15);
	}
}
