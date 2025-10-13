
namespace EntitiesDb;

internal struct ForEachJob<T, T0>(in T forEach, in Ids<T0> ids) : IChunkJob
	where T : IForEach<T0>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1>(in T forEach, in Ids<T0, T1> ids) : IChunkJob
	where T : IForEach<T0, T1>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2>(in T forEach, in Ids<T0, T1, T2> ids) : IChunkJob
	where T : IForEach<T0, T1, T2>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3>(in T forEach, in Ids<T0, T1, T2, T3> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3, T4>(in T forEach, in Ids<T0, T1, T2, T3, T4> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3, T4>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3, T4, T5>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3, T4, T5>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3, T4, T5, T6>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3, T4, T5, T6>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
        var t7Handle = chunk.GetHandle(_offsets.T7);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], ref t7Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
        var t7Handle = chunk.GetHandle(_offsets.T7);
        var t8Handle = chunk.GetHandle(_offsets.T8);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], ref t7Handle[index], ref t8Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
        var t7Handle = chunk.GetHandle(_offsets.T7);
        var t8Handle = chunk.GetHandle(_offsets.T8);
        var t9Handle = chunk.GetHandle(_offsets.T9);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], ref t7Handle[index], ref t8Handle[index], ref t9Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
        var t7Handle = chunk.GetHandle(_offsets.T7);
        var t8Handle = chunk.GetHandle(_offsets.T8);
        var t9Handle = chunk.GetHandle(_offsets.T9);
        var t10Handle = chunk.GetHandle(_offsets.T10);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], ref t7Handle[index], ref t8Handle[index], ref t9Handle[index], ref t10Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
        var t7Handle = chunk.GetHandle(_offsets.T7);
        var t8Handle = chunk.GetHandle(_offsets.T8);
        var t9Handle = chunk.GetHandle(_offsets.T9);
        var t10Handle = chunk.GetHandle(_offsets.T10);
        var t11Handle = chunk.GetHandle(_offsets.T11);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], ref t7Handle[index], ref t8Handle[index], ref t9Handle[index], ref t10Handle[index], ref t11Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
        var t7Handle = chunk.GetHandle(_offsets.T7);
        var t8Handle = chunk.GetHandle(_offsets.T8);
        var t9Handle = chunk.GetHandle(_offsets.T9);
        var t10Handle = chunk.GetHandle(_offsets.T10);
        var t11Handle = chunk.GetHandle(_offsets.T11);
        var t12Handle = chunk.GetHandle(_offsets.T12);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], ref t7Handle[index], ref t8Handle[index], ref t9Handle[index], ref t10Handle[index], ref t11Handle[index], ref t12Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
        var t7Handle = chunk.GetHandle(_offsets.T7);
        var t8Handle = chunk.GetHandle(_offsets.T8);
        var t9Handle = chunk.GetHandle(_offsets.T9);
        var t10Handle = chunk.GetHandle(_offsets.T10);
        var t11Handle = chunk.GetHandle(_offsets.T11);
        var t12Handle = chunk.GetHandle(_offsets.T12);
        var t13Handle = chunk.GetHandle(_offsets.T13);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], ref t7Handle[index], ref t8Handle[index], ref t9Handle[index], ref t10Handle[index], ref t11Handle[index], ref t12Handle[index], ref t13Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
        var t7Handle = chunk.GetHandle(_offsets.T7);
        var t8Handle = chunk.GetHandle(_offsets.T8);
        var t9Handle = chunk.GetHandle(_offsets.T9);
        var t10Handle = chunk.GetHandle(_offsets.T10);
        var t11Handle = chunk.GetHandle(_offsets.T11);
        var t12Handle = chunk.GetHandle(_offsets.T12);
        var t13Handle = chunk.GetHandle(_offsets.T13);
        var t14Handle = chunk.GetHandle(_offsets.T14);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], ref t7Handle[index], ref t8Handle[index], ref t9Handle[index], ref t10Handle[index], ref t11Handle[index], ref t12Handle[index], ref t13Handle[index], ref t14Handle[index]);
		}
	}
}
internal struct ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids) : IChunkJob
	where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
        var t7Handle = chunk.GetHandle(_offsets.T7);
        var t8Handle = chunk.GetHandle(_offsets.T8);
        var t9Handle = chunk.GetHandle(_offsets.T9);
        var t10Handle = chunk.GetHandle(_offsets.T10);
        var t11Handle = chunk.GetHandle(_offsets.T11);
        var t12Handle = chunk.GetHandle(_offsets.T12);
        var t13Handle = chunk.GetHandle(_offsets.T13);
        var t14Handle = chunk.GetHandle(_offsets.T14);
        var t15Handle = chunk.GetHandle(_offsets.T15);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], ref t7Handle[index], ref t8Handle[index], ref t9Handle[index], ref t10Handle[index], ref t11Handle[index], ref t12Handle[index], ref t13Handle[index], ref t14Handle[index], ref t15Handle[index]);
		}
	}
}
