
namespace EntitiesDb;

public readonly ref struct Chunk<T0>(ref readonly Chunk chunk, Offsets<T0> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
	}
}
public readonly ref struct Chunk<T0, T1>(ref readonly Chunk chunk, Offsets<T0, T1> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
	}
}
public readonly ref struct Chunk<T0, T1, T2>(ref readonly Chunk chunk, Offsets<T0, T1, T2> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3, T4>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3, T4, T5>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
    public ref T5? GetT5(int index) => ref _chunk.Get(index, _offsets.T5);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle)
	{
		length = _chunk.EntityCount;
		entities = _chunk.GetEntityHandle();
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3, T4, T5, T6>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets = offsets;

	public int EntityCount => _chunk.EntityCount;
	
	public ReadOnlyHandle<Entity> GetEntityHandle() => _chunk.GetEntityHandle();
	public ref T0? GetT0(int index) => ref _chunk.Get(index, _offsets.T0);
    public ref T1? GetT1(int index) => ref _chunk.Get(index, _offsets.T1);
    public ref T2? GetT2(int index) => ref _chunk.Get(index, _offsets.T2);
    public ref T3? GetT3(int index) => ref _chunk.Get(index, _offsets.T3);
    public ref T4? GetT4(int index) => ref _chunk.Get(index, _offsets.T4);
    public ref T5? GetT5(int index) => ref _chunk.Get(index, _offsets.T5);
    public ref T6? GetT6(int index) => ref _chunk.Get(index, _offsets.T6);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle)
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
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle)
	{
		length = _chunk.EntityCount;
		t0Handle = _chunk.GetHandle(_offsets.T0);
        t1Handle = _chunk.GetHandle(_offsets.T1);
        t2Handle = _chunk.GetHandle(_offsets.T2);
        t3Handle = _chunk.GetHandle(_offsets.T3);
        t4Handle = _chunk.GetHandle(_offsets.T4);
        t5Handle = _chunk.GetHandle(_offsets.T5);
        t6Handle = _chunk.GetHandle(_offsets.T6);
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3, T4, T5, T6, T7>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
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
    public ref T7? GetT7(int index) => ref _chunk.Get(index, _offsets.T7);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
    public ref readonly T7? GetReadOnlyT7(int index) => ref _chunk.GetReadOnly(index, _offsets.T7);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
    public Handle<T7?> GetHandleT7() => _chunk.GetHandle(_offsets.T7);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.GetHandleReadOnly(_offsets.T7);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle)
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
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle)
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
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
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
    public ref T8? GetT8(int index) => ref _chunk.Get(index, _offsets.T8);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
    public ref readonly T7? GetReadOnlyT7(int index) => ref _chunk.GetReadOnly(index, _offsets.T7);
    public ref readonly T8? GetReadOnlyT8(int index) => ref _chunk.GetReadOnly(index, _offsets.T8);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
    public Handle<T7?> GetHandleT7() => _chunk.GetHandle(_offsets.T7);
    public Handle<T8?> GetHandleT8() => _chunk.GetHandle(_offsets.T8);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.GetHandleReadOnly(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.GetHandleReadOnly(_offsets.T8);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle)
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
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle)
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
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
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
    public ref T9? GetT9(int index) => ref _chunk.Get(index, _offsets.T9);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
    public ref readonly T7? GetReadOnlyT7(int index) => ref _chunk.GetReadOnly(index, _offsets.T7);
    public ref readonly T8? GetReadOnlyT8(int index) => ref _chunk.GetReadOnly(index, _offsets.T8);
    public ref readonly T9? GetReadOnlyT9(int index) => ref _chunk.GetReadOnly(index, _offsets.T9);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
    public Handle<T7?> GetHandleT7() => _chunk.GetHandle(_offsets.T7);
    public Handle<T8?> GetHandleT8() => _chunk.GetHandle(_offsets.T8);
    public Handle<T9?> GetHandleT9() => _chunk.GetHandle(_offsets.T9);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.GetHandleReadOnly(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.GetHandleReadOnly(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.GetHandleReadOnly(_offsets.T9);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _offsets = offsets;

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
    public ref T9? GetT9(int index) => ref _chunk.Get(index, _offsets.T9);
    public ref T10? GetT10(int index) => ref _chunk.Get(index, _offsets.T10);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
    public ref readonly T7? GetReadOnlyT7(int index) => ref _chunk.GetReadOnly(index, _offsets.T7);
    public ref readonly T8? GetReadOnlyT8(int index) => ref _chunk.GetReadOnly(index, _offsets.T8);
    public ref readonly T9? GetReadOnlyT9(int index) => ref _chunk.GetReadOnly(index, _offsets.T9);
    public ref readonly T10? GetReadOnlyT10(int index) => ref _chunk.GetReadOnly(index, _offsets.T10);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
    public Handle<T7?> GetHandleT7() => _chunk.GetHandle(_offsets.T7);
    public Handle<T8?> GetHandleT8() => _chunk.GetHandle(_offsets.T8);
    public Handle<T9?> GetHandleT9() => _chunk.GetHandle(_offsets.T9);
    public Handle<T10?> GetHandleT10() => _chunk.GetHandle(_offsets.T10);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.GetHandleReadOnly(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.GetHandleReadOnly(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.GetHandleReadOnly(_offsets.T9);
    public ReadOnlyHandle<T10?> GetHandleReadOnlyT10() => _chunk.GetHandleReadOnly(_offsets.T10);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
        t10Handle = _chunk.GetHandle(_offsets.T10);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
        t10Handle = _chunk.GetHandle(_offsets.T10);
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _offsets = offsets;

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
    public ref T9? GetT9(int index) => ref _chunk.Get(index, _offsets.T9);
    public ref T10? GetT10(int index) => ref _chunk.Get(index, _offsets.T10);
    public ref T11? GetT11(int index) => ref _chunk.Get(index, _offsets.T11);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
    public ref readonly T7? GetReadOnlyT7(int index) => ref _chunk.GetReadOnly(index, _offsets.T7);
    public ref readonly T8? GetReadOnlyT8(int index) => ref _chunk.GetReadOnly(index, _offsets.T8);
    public ref readonly T9? GetReadOnlyT9(int index) => ref _chunk.GetReadOnly(index, _offsets.T9);
    public ref readonly T10? GetReadOnlyT10(int index) => ref _chunk.GetReadOnly(index, _offsets.T10);
    public ref readonly T11? GetReadOnlyT11(int index) => ref _chunk.GetReadOnly(index, _offsets.T11);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
    public Handle<T7?> GetHandleT7() => _chunk.GetHandle(_offsets.T7);
    public Handle<T8?> GetHandleT8() => _chunk.GetHandle(_offsets.T8);
    public Handle<T9?> GetHandleT9() => _chunk.GetHandle(_offsets.T9);
    public Handle<T10?> GetHandleT10() => _chunk.GetHandle(_offsets.T10);
    public Handle<T11?> GetHandleT11() => _chunk.GetHandle(_offsets.T11);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.GetHandleReadOnly(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.GetHandleReadOnly(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.GetHandleReadOnly(_offsets.T9);
    public ReadOnlyHandle<T10?> GetHandleReadOnlyT10() => _chunk.GetHandleReadOnly(_offsets.T10);
    public ReadOnlyHandle<T11?> GetHandleReadOnlyT11() => _chunk.GetHandleReadOnly(_offsets.T11);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
        t10Handle = _chunk.GetHandle(_offsets.T10);
        t11Handle = _chunk.GetHandle(_offsets.T11);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
        t10Handle = _chunk.GetHandle(_offsets.T10);
        t11Handle = _chunk.GetHandle(_offsets.T11);
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _offsets = offsets;

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
    public ref T9? GetT9(int index) => ref _chunk.Get(index, _offsets.T9);
    public ref T10? GetT10(int index) => ref _chunk.Get(index, _offsets.T10);
    public ref T11? GetT11(int index) => ref _chunk.Get(index, _offsets.T11);
    public ref T12? GetT12(int index) => ref _chunk.Get(index, _offsets.T12);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
    public ref readonly T7? GetReadOnlyT7(int index) => ref _chunk.GetReadOnly(index, _offsets.T7);
    public ref readonly T8? GetReadOnlyT8(int index) => ref _chunk.GetReadOnly(index, _offsets.T8);
    public ref readonly T9? GetReadOnlyT9(int index) => ref _chunk.GetReadOnly(index, _offsets.T9);
    public ref readonly T10? GetReadOnlyT10(int index) => ref _chunk.GetReadOnly(index, _offsets.T10);
    public ref readonly T11? GetReadOnlyT11(int index) => ref _chunk.GetReadOnly(index, _offsets.T11);
    public ref readonly T12? GetReadOnlyT12(int index) => ref _chunk.GetReadOnly(index, _offsets.T12);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
    public Handle<T7?> GetHandleT7() => _chunk.GetHandle(_offsets.T7);
    public Handle<T8?> GetHandleT8() => _chunk.GetHandle(_offsets.T8);
    public Handle<T9?> GetHandleT9() => _chunk.GetHandle(_offsets.T9);
    public Handle<T10?> GetHandleT10() => _chunk.GetHandle(_offsets.T10);
    public Handle<T11?> GetHandleT11() => _chunk.GetHandle(_offsets.T11);
    public Handle<T12?> GetHandleT12() => _chunk.GetHandle(_offsets.T12);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.GetHandleReadOnly(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.GetHandleReadOnly(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.GetHandleReadOnly(_offsets.T9);
    public ReadOnlyHandle<T10?> GetHandleReadOnlyT10() => _chunk.GetHandleReadOnly(_offsets.T10);
    public ReadOnlyHandle<T11?> GetHandleReadOnlyT11() => _chunk.GetHandleReadOnly(_offsets.T11);
    public ReadOnlyHandle<T12?> GetHandleReadOnlyT12() => _chunk.GetHandleReadOnly(_offsets.T12);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
        t10Handle = _chunk.GetHandle(_offsets.T10);
        t11Handle = _chunk.GetHandle(_offsets.T11);
        t12Handle = _chunk.GetHandle(_offsets.T12);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
        t10Handle = _chunk.GetHandle(_offsets.T10);
        t11Handle = _chunk.GetHandle(_offsets.T11);
        t12Handle = _chunk.GetHandle(_offsets.T12);
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _offsets = offsets;

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
    public ref T9? GetT9(int index) => ref _chunk.Get(index, _offsets.T9);
    public ref T10? GetT10(int index) => ref _chunk.Get(index, _offsets.T10);
    public ref T11? GetT11(int index) => ref _chunk.Get(index, _offsets.T11);
    public ref T12? GetT12(int index) => ref _chunk.Get(index, _offsets.T12);
    public ref T13? GetT13(int index) => ref _chunk.Get(index, _offsets.T13);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
    public ref readonly T7? GetReadOnlyT7(int index) => ref _chunk.GetReadOnly(index, _offsets.T7);
    public ref readonly T8? GetReadOnlyT8(int index) => ref _chunk.GetReadOnly(index, _offsets.T8);
    public ref readonly T9? GetReadOnlyT9(int index) => ref _chunk.GetReadOnly(index, _offsets.T9);
    public ref readonly T10? GetReadOnlyT10(int index) => ref _chunk.GetReadOnly(index, _offsets.T10);
    public ref readonly T11? GetReadOnlyT11(int index) => ref _chunk.GetReadOnly(index, _offsets.T11);
    public ref readonly T12? GetReadOnlyT12(int index) => ref _chunk.GetReadOnly(index, _offsets.T12);
    public ref readonly T13? GetReadOnlyT13(int index) => ref _chunk.GetReadOnly(index, _offsets.T13);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
    public Handle<T7?> GetHandleT7() => _chunk.GetHandle(_offsets.T7);
    public Handle<T8?> GetHandleT8() => _chunk.GetHandle(_offsets.T8);
    public Handle<T9?> GetHandleT9() => _chunk.GetHandle(_offsets.T9);
    public Handle<T10?> GetHandleT10() => _chunk.GetHandle(_offsets.T10);
    public Handle<T11?> GetHandleT11() => _chunk.GetHandle(_offsets.T11);
    public Handle<T12?> GetHandleT12() => _chunk.GetHandle(_offsets.T12);
    public Handle<T13?> GetHandleT13() => _chunk.GetHandle(_offsets.T13);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.GetHandleReadOnly(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.GetHandleReadOnly(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.GetHandleReadOnly(_offsets.T9);
    public ReadOnlyHandle<T10?> GetHandleReadOnlyT10() => _chunk.GetHandleReadOnly(_offsets.T10);
    public ReadOnlyHandle<T11?> GetHandleReadOnlyT11() => _chunk.GetHandleReadOnly(_offsets.T11);
    public ReadOnlyHandle<T12?> GetHandleReadOnlyT12() => _chunk.GetHandleReadOnly(_offsets.T12);
    public ReadOnlyHandle<T13?> GetHandleReadOnlyT13() => _chunk.GetHandleReadOnly(_offsets.T13);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle, out Handle<T13?> t13Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
        t10Handle = _chunk.GetHandle(_offsets.T10);
        t11Handle = _chunk.GetHandle(_offsets.T11);
        t12Handle = _chunk.GetHandle(_offsets.T12);
        t13Handle = _chunk.GetHandle(_offsets.T13);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle, out Handle<T13?> t13Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
        t10Handle = _chunk.GetHandle(_offsets.T10);
        t11Handle = _chunk.GetHandle(_offsets.T11);
        t12Handle = _chunk.GetHandle(_offsets.T12);
        t13Handle = _chunk.GetHandle(_offsets.T13);
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _offsets = offsets;

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
    public ref T9? GetT9(int index) => ref _chunk.Get(index, _offsets.T9);
    public ref T10? GetT10(int index) => ref _chunk.Get(index, _offsets.T10);
    public ref T11? GetT11(int index) => ref _chunk.Get(index, _offsets.T11);
    public ref T12? GetT12(int index) => ref _chunk.Get(index, _offsets.T12);
    public ref T13? GetT13(int index) => ref _chunk.Get(index, _offsets.T13);
    public ref T14? GetT14(int index) => ref _chunk.Get(index, _offsets.T14);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
    public ref readonly T7? GetReadOnlyT7(int index) => ref _chunk.GetReadOnly(index, _offsets.T7);
    public ref readonly T8? GetReadOnlyT8(int index) => ref _chunk.GetReadOnly(index, _offsets.T8);
    public ref readonly T9? GetReadOnlyT9(int index) => ref _chunk.GetReadOnly(index, _offsets.T9);
    public ref readonly T10? GetReadOnlyT10(int index) => ref _chunk.GetReadOnly(index, _offsets.T10);
    public ref readonly T11? GetReadOnlyT11(int index) => ref _chunk.GetReadOnly(index, _offsets.T11);
    public ref readonly T12? GetReadOnlyT12(int index) => ref _chunk.GetReadOnly(index, _offsets.T12);
    public ref readonly T13? GetReadOnlyT13(int index) => ref _chunk.GetReadOnly(index, _offsets.T13);
    public ref readonly T14? GetReadOnlyT14(int index) => ref _chunk.GetReadOnly(index, _offsets.T14);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
    public Handle<T7?> GetHandleT7() => _chunk.GetHandle(_offsets.T7);
    public Handle<T8?> GetHandleT8() => _chunk.GetHandle(_offsets.T8);
    public Handle<T9?> GetHandleT9() => _chunk.GetHandle(_offsets.T9);
    public Handle<T10?> GetHandleT10() => _chunk.GetHandle(_offsets.T10);
    public Handle<T11?> GetHandleT11() => _chunk.GetHandle(_offsets.T11);
    public Handle<T12?> GetHandleT12() => _chunk.GetHandle(_offsets.T12);
    public Handle<T13?> GetHandleT13() => _chunk.GetHandle(_offsets.T13);
    public Handle<T14?> GetHandleT14() => _chunk.GetHandle(_offsets.T14);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.GetHandleReadOnly(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.GetHandleReadOnly(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.GetHandleReadOnly(_offsets.T9);
    public ReadOnlyHandle<T10?> GetHandleReadOnlyT10() => _chunk.GetHandleReadOnly(_offsets.T10);
    public ReadOnlyHandle<T11?> GetHandleReadOnlyT11() => _chunk.GetHandleReadOnly(_offsets.T11);
    public ReadOnlyHandle<T12?> GetHandleReadOnlyT12() => _chunk.GetHandleReadOnly(_offsets.T12);
    public ReadOnlyHandle<T13?> GetHandleReadOnlyT13() => _chunk.GetHandleReadOnly(_offsets.T13);
    public ReadOnlyHandle<T14?> GetHandleReadOnlyT14() => _chunk.GetHandleReadOnly(_offsets.T14);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle, out Handle<T13?> t13Handle, out Handle<T14?> t14Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
        t10Handle = _chunk.GetHandle(_offsets.T10);
        t11Handle = _chunk.GetHandle(_offsets.T11);
        t12Handle = _chunk.GetHandle(_offsets.T12);
        t13Handle = _chunk.GetHandle(_offsets.T13);
        t14Handle = _chunk.GetHandle(_offsets.T14);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle, out Handle<T13?> t13Handle, out Handle<T14?> t14Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
        t10Handle = _chunk.GetHandle(_offsets.T10);
        t11Handle = _chunk.GetHandle(_offsets.T11);
        t12Handle = _chunk.GetHandle(_offsets.T12);
        t13Handle = _chunk.GetHandle(_offsets.T13);
        t14Handle = _chunk.GetHandle(_offsets.T14);
	}
}
public readonly ref struct Chunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref readonly Chunk chunk, Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> offsets)
{
	private readonly ref readonly Chunk _chunk = ref chunk;
	private readonly Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _offsets = offsets;

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
    public ref T9? GetT9(int index) => ref _chunk.Get(index, _offsets.T9);
    public ref T10? GetT10(int index) => ref _chunk.Get(index, _offsets.T10);
    public ref T11? GetT11(int index) => ref _chunk.Get(index, _offsets.T11);
    public ref T12? GetT12(int index) => ref _chunk.Get(index, _offsets.T12);
    public ref T13? GetT13(int index) => ref _chunk.Get(index, _offsets.T13);
    public ref T14? GetT14(int index) => ref _chunk.Get(index, _offsets.T14);
    public ref T15? GetT15(int index) => ref _chunk.Get(index, _offsets.T15);
	public ref readonly T0? GetReadOnlyT0(int index) => ref _chunk.GetReadOnly(index, _offsets.T0);
    public ref readonly T1? GetReadOnlyT1(int index) => ref _chunk.GetReadOnly(index, _offsets.T1);
    public ref readonly T2? GetReadOnlyT2(int index) => ref _chunk.GetReadOnly(index, _offsets.T2);
    public ref readonly T3? GetReadOnlyT3(int index) => ref _chunk.GetReadOnly(index, _offsets.T3);
    public ref readonly T4? GetReadOnlyT4(int index) => ref _chunk.GetReadOnly(index, _offsets.T4);
    public ref readonly T5? GetReadOnlyT5(int index) => ref _chunk.GetReadOnly(index, _offsets.T5);
    public ref readonly T6? GetReadOnlyT6(int index) => ref _chunk.GetReadOnly(index, _offsets.T6);
    public ref readonly T7? GetReadOnlyT7(int index) => ref _chunk.GetReadOnly(index, _offsets.T7);
    public ref readonly T8? GetReadOnlyT8(int index) => ref _chunk.GetReadOnly(index, _offsets.T8);
    public ref readonly T9? GetReadOnlyT9(int index) => ref _chunk.GetReadOnly(index, _offsets.T9);
    public ref readonly T10? GetReadOnlyT10(int index) => ref _chunk.GetReadOnly(index, _offsets.T10);
    public ref readonly T11? GetReadOnlyT11(int index) => ref _chunk.GetReadOnly(index, _offsets.T11);
    public ref readonly T12? GetReadOnlyT12(int index) => ref _chunk.GetReadOnly(index, _offsets.T12);
    public ref readonly T13? GetReadOnlyT13(int index) => ref _chunk.GetReadOnly(index, _offsets.T13);
    public ref readonly T14? GetReadOnlyT14(int index) => ref _chunk.GetReadOnly(index, _offsets.T14);
    public ref readonly T15? GetReadOnlyT15(int index) => ref _chunk.GetReadOnly(index, _offsets.T15);
	public Handle<T0?> GetHandleT0() => _chunk.GetHandle(_offsets.T0);
    public Handle<T1?> GetHandleT1() => _chunk.GetHandle(_offsets.T1);
    public Handle<T2?> GetHandleT2() => _chunk.GetHandle(_offsets.T2);
    public Handle<T3?> GetHandleT3() => _chunk.GetHandle(_offsets.T3);
    public Handle<T4?> GetHandleT4() => _chunk.GetHandle(_offsets.T4);
    public Handle<T5?> GetHandleT5() => _chunk.GetHandle(_offsets.T5);
    public Handle<T6?> GetHandleT6() => _chunk.GetHandle(_offsets.T6);
    public Handle<T7?> GetHandleT7() => _chunk.GetHandle(_offsets.T7);
    public Handle<T8?> GetHandleT8() => _chunk.GetHandle(_offsets.T8);
    public Handle<T9?> GetHandleT9() => _chunk.GetHandle(_offsets.T9);
    public Handle<T10?> GetHandleT10() => _chunk.GetHandle(_offsets.T10);
    public Handle<T11?> GetHandleT11() => _chunk.GetHandle(_offsets.T11);
    public Handle<T12?> GetHandleT12() => _chunk.GetHandle(_offsets.T12);
    public Handle<T13?> GetHandleT13() => _chunk.GetHandle(_offsets.T13);
    public Handle<T14?> GetHandleT14() => _chunk.GetHandle(_offsets.T14);
    public Handle<T15?> GetHandleT15() => _chunk.GetHandle(_offsets.T15);
	public ReadOnlyHandle<T0?> GetHandleReadOnlyT0() => _chunk.GetHandleReadOnly(_offsets.T0);
    public ReadOnlyHandle<T1?> GetHandleReadOnlyT1() => _chunk.GetHandleReadOnly(_offsets.T1);
    public ReadOnlyHandle<T2?> GetHandleReadOnlyT2() => _chunk.GetHandleReadOnly(_offsets.T2);
    public ReadOnlyHandle<T3?> GetHandleReadOnlyT3() => _chunk.GetHandleReadOnly(_offsets.T3);
    public ReadOnlyHandle<T4?> GetHandleReadOnlyT4() => _chunk.GetHandleReadOnly(_offsets.T4);
    public ReadOnlyHandle<T5?> GetHandleReadOnlyT5() => _chunk.GetHandleReadOnly(_offsets.T5);
    public ReadOnlyHandle<T6?> GetHandleReadOnlyT6() => _chunk.GetHandleReadOnly(_offsets.T6);
    public ReadOnlyHandle<T7?> GetHandleReadOnlyT7() => _chunk.GetHandleReadOnly(_offsets.T7);
    public ReadOnlyHandle<T8?> GetHandleReadOnlyT8() => _chunk.GetHandleReadOnly(_offsets.T8);
    public ReadOnlyHandle<T9?> GetHandleReadOnlyT9() => _chunk.GetHandleReadOnly(_offsets.T9);
    public ReadOnlyHandle<T10?> GetHandleReadOnlyT10() => _chunk.GetHandleReadOnly(_offsets.T10);
    public ReadOnlyHandle<T11?> GetHandleReadOnlyT11() => _chunk.GetHandleReadOnly(_offsets.T11);
    public ReadOnlyHandle<T12?> GetHandleReadOnlyT12() => _chunk.GetHandleReadOnly(_offsets.T12);
    public ReadOnlyHandle<T13?> GetHandleReadOnlyT13() => _chunk.GetHandleReadOnly(_offsets.T13);
    public ReadOnlyHandle<T14?> GetHandleReadOnlyT14() => _chunk.GetHandleReadOnly(_offsets.T14);
    public ReadOnlyHandle<T15?> GetHandleReadOnlyT15() => _chunk.GetHandleReadOnly(_offsets.T15);

	public void Deconstruct(out int length, out ReadOnlyHandle<Entity> entities, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle, out Handle<T13?> t13Handle, out Handle<T14?> t14Handle, out Handle<T15?> t15Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
        t10Handle = _chunk.GetHandle(_offsets.T10);
        t11Handle = _chunk.GetHandle(_offsets.T11);
        t12Handle = _chunk.GetHandle(_offsets.T12);
        t13Handle = _chunk.GetHandle(_offsets.T13);
        t14Handle = _chunk.GetHandle(_offsets.T14);
        t15Handle = _chunk.GetHandle(_offsets.T15);
	}

	public void Deconstruct(out int length, out Handle<T0?> t0Handle, out Handle<T1?> t1Handle, out Handle<T2?> t2Handle, out Handle<T3?> t3Handle, out Handle<T4?> t4Handle, out Handle<T5?> t5Handle, out Handle<T6?> t6Handle, out Handle<T7?> t7Handle, out Handle<T8?> t8Handle, out Handle<T9?> t9Handle, out Handle<T10?> t10Handle, out Handle<T11?> t11Handle, out Handle<T12?> t12Handle, out Handle<T13?> t13Handle, out Handle<T14?> t14Handle, out Handle<T15?> t15Handle)
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
        t9Handle = _chunk.GetHandle(_offsets.T9);
        t10Handle = _chunk.GetHandle(_offsets.T10);
        t11Handle = _chunk.GetHandle(_offsets.T11);
        t12Handle = _chunk.GetHandle(_offsets.T12);
        t13Handle = _chunk.GetHandle(_offsets.T13);
        t14Handle = _chunk.GetHandle(_offsets.T14);
        t15Handle = _chunk.GetHandle(_offsets.T15);
	}
}
