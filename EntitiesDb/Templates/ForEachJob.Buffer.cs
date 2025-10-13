
namespace EntitiesDb;

internal struct ForEachJobBuffer<T, T0>(in T forEach, in Ids<T0> ids) : IChunkJob
	where T : IForEachBuffer<T0>
	where T0 : unmanaged
{
	private readonly T _forEach = forEach;
	private readonly Ids<T0> _ids = ids;
	private Offsets<T0> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1>(in T forEach, in Ids<T0, T1> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1>
	where T0 : unmanaged
    where T1 : unmanaged
{
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1> _ids = ids;
	private Offsets<T0, T1> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2>(in T forEach, in Ids<T0, T1, T2> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
{
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2> _ids = ids;
	private Offsets<T0, T1, T2> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3>(in T forEach, in Ids<T0, T1, T2, T3> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
{
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3> _ids = ids;
	private Offsets<T0, T1, T2, T3> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3, T4>(in T forEach, in Ids<T0, T1, T2, T3, T4> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3, T4>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
{
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3, T4> _ids = ids;
	private Offsets<T0, T1, T2, T3, T4> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3, T4, T5>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3, T4, T5>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
{
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3, T4, T5> _ids = ids;
	private Offsets<T0, T1, T2, T3, T4, T5> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3, T4, T5, T6>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3, T4, T5, T6>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
{
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6> _ids = ids;
	private Offsets<T0, T1, T2, T3, T4, T5, T6> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3, T4, T5, T6, T7>
	where T0 : unmanaged
    where T1 : unmanaged
    where T2 : unmanaged
    where T3 : unmanaged
    where T4 : unmanaged
    where T5 : unmanaged
    where T6 : unmanaged
    where T7 : unmanaged
{
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7> _ids = ids;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> _ids = ids;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _ids = ids;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _ids = ids;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
        var t10Handle = chunk.GetBufferHandle(_offsets.T10);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index], t10Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _ids = ids;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
        var t10Handle = chunk.GetBufferHandle(_offsets.T10);
        var t11Handle = chunk.GetBufferHandle(_offsets.T11);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index], t10Handle[index], t11Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _ids = ids;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
        var t10Handle = chunk.GetBufferHandle(_offsets.T10);
        var t11Handle = chunk.GetBufferHandle(_offsets.T11);
        var t12Handle = chunk.GetBufferHandle(_offsets.T12);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index], t10Handle[index], t11Handle[index], t12Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _ids = ids;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
        var t10Handle = chunk.GetBufferHandle(_offsets.T10);
        var t11Handle = chunk.GetBufferHandle(_offsets.T11);
        var t12Handle = chunk.GetBufferHandle(_offsets.T12);
        var t13Handle = chunk.GetBufferHandle(_offsets.T13);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index], t10Handle[index], t11Handle[index], t12Handle[index], t13Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _ids = ids;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
        var t10Handle = chunk.GetBufferHandle(_offsets.T10);
        var t11Handle = chunk.GetBufferHandle(_offsets.T11);
        var t12Handle = chunk.GetBufferHandle(_offsets.T12);
        var t13Handle = chunk.GetBufferHandle(_offsets.T13);
        var t14Handle = chunk.GetBufferHandle(_offsets.T14);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index], t10Handle[index], t11Handle[index], t12Handle[index], t13Handle[index], t14Handle[index]);
		}
	}
}
internal struct ForEachJobBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids) : IChunkJob
	where T : IForEachBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
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
	private readonly T _forEach = forEach;
	private readonly Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _ids = ids;
	private Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _offsets = default;

	public void Enter(Archetype archetype)
	{
		_offsets = archetype.GetOffsets(in _ids);
	}

	public void ForEach(in Chunk chunk)
	{
		var t0Handle = chunk.GetBufferHandle(_offsets.T0);
        var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
        var t10Handle = chunk.GetBufferHandle(_offsets.T10);
        var t11Handle = chunk.GetBufferHandle(_offsets.T11);
        var t12Handle = chunk.GetBufferHandle(_offsets.T12);
        var t13Handle = chunk.GetBufferHandle(_offsets.T13);
        var t14Handle = chunk.GetBufferHandle(_offsets.T14);
        var t15Handle = chunk.GetBufferHandle(_offsets.T15);
		foreach (var index in chunk)
		{
			_forEach.ForEach(t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index], t10Handle[index], t11Handle[index], t12Handle[index], t13Handle[index], t14Handle[index], t15Handle[index]);
		}
	}
}
