
namespace EntitiesDb;

internal struct ForEachJobMixed1<T, T0, T1>(in T forEach, in Ids<T0, T1> ids) : IChunkJob
	where T : IForEachMixed1<T0, T1>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
		var t1Handle = chunk.GetBufferHandle(_offsets.T1);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], t1Handle[index]);
		}
	}
}
internal struct ForEachJobMixed1<T, T0, T1, T2>(in T forEach, in Ids<T0, T1, T2> ids) : IChunkJob
	where T : IForEachMixed1<T0, T1, T2>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
		var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], t1Handle[index], t2Handle[index]);
		}
	}
}
internal struct ForEachJobMixed1<T, T0, T1, T2, T3>(in T forEach, in Ids<T0, T1, T2, T3> ids) : IChunkJob
	where T : IForEachMixed1<T0, T1, T2, T3>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
		var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index]);
		}
	}
}
internal struct ForEachJobMixed1<T, T0, T1, T2, T3, T4>(in T forEach, in Ids<T0, T1, T2, T3, T4> ids) : IChunkJob
	where T : IForEachMixed1<T0, T1, T2, T3, T4>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
		var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index]);
		}
	}
}
internal struct ForEachJobMixed1<T, T0, T1, T2, T3, T4, T5>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5> ids) : IChunkJob
	where T : IForEachMixed1<T0, T1, T2, T3, T4, T5>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
		var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index]);
		}
	}
}
internal struct ForEachJobMixed1<T, T0, T1, T2, T3, T4, T5, T6>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6> ids) : IChunkJob
	where T : IForEachMixed1<T0, T1, T2, T3, T4, T5, T6>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
		var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index]);
		}
	}
}
internal struct ForEachJobMixed1<T, T0, T1, T2, T3, T4, T5, T6, T7>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids) : IChunkJob
	where T : IForEachMixed1<T0, T1, T2, T3, T4, T5, T6, T7>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
		var t1Handle = chunk.GetBufferHandle(_offsets.T1);
        var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index]);
		}
	}
}
internal struct ForEachJobMixed1<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids) : IChunkJob
	where T : IForEachMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
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
			_forEach.ForEach(ref t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index]);
		}
	}
}
internal struct ForEachJobMixed1<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids) : IChunkJob
	where T : IForEachMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
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
			_forEach.ForEach(ref t0Handle[index], t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index]);
		}
	}
}
internal struct ForEachJobMixed2<T, T0, T1, T2>(in T forEach, in Ids<T0, T1, T2> ids) : IChunkJob
	where T : IForEachMixed2<T0, T1, T2>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
		var t2Handle = chunk.GetBufferHandle(_offsets.T2);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], t2Handle[index]);
		}
	}
}
internal struct ForEachJobMixed2<T, T0, T1, T2, T3>(in T forEach, in Ids<T0, T1, T2, T3> ids) : IChunkJob
	where T : IForEachMixed2<T0, T1, T2, T3>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
		var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], t2Handle[index], t3Handle[index]);
		}
	}
}
internal struct ForEachJobMixed2<T, T0, T1, T2, T3, T4>(in T forEach, in Ids<T0, T1, T2, T3, T4> ids) : IChunkJob
	where T : IForEachMixed2<T0, T1, T2, T3, T4>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
		var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index]);
		}
	}
}
internal struct ForEachJobMixed2<T, T0, T1, T2, T3, T4, T5>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5> ids) : IChunkJob
	where T : IForEachMixed2<T0, T1, T2, T3, T4, T5>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
		var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index]);
		}
	}
}
internal struct ForEachJobMixed2<T, T0, T1, T2, T3, T4, T5, T6>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6> ids) : IChunkJob
	where T : IForEachMixed2<T0, T1, T2, T3, T4, T5, T6>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
		var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index]);
		}
	}
}
internal struct ForEachJobMixed2<T, T0, T1, T2, T3, T4, T5, T6, T7>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids) : IChunkJob
	where T : IForEachMixed2<T0, T1, T2, T3, T4, T5, T6, T7>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
		var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index]);
		}
	}
}
internal struct ForEachJobMixed2<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids) : IChunkJob
	where T : IForEachMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
		var t2Handle = chunk.GetBufferHandle(_offsets.T2);
        var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index]);
		}
	}
}
internal struct ForEachJobMixed2<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids) : IChunkJob
	where T : IForEachMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
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
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index]);
		}
	}
}
internal struct ForEachJobMixed3<T, T0, T1, T2, T3>(in T forEach, in Ids<T0, T1, T2, T3> ids) : IChunkJob
	where T : IForEachMixed3<T0, T1, T2, T3>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
		var t3Handle = chunk.GetBufferHandle(_offsets.T3);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], t3Handle[index]);
		}
	}
}
internal struct ForEachJobMixed3<T, T0, T1, T2, T3, T4>(in T forEach, in Ids<T0, T1, T2, T3, T4> ids) : IChunkJob
	where T : IForEachMixed3<T0, T1, T2, T3, T4>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
		var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], t3Handle[index], t4Handle[index]);
		}
	}
}
internal struct ForEachJobMixed3<T, T0, T1, T2, T3, T4, T5>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5> ids) : IChunkJob
	where T : IForEachMixed3<T0, T1, T2, T3, T4, T5>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
		var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index]);
		}
	}
}
internal struct ForEachJobMixed3<T, T0, T1, T2, T3, T4, T5, T6>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6> ids) : IChunkJob
	where T : IForEachMixed3<T0, T1, T2, T3, T4, T5, T6>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
		var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index]);
		}
	}
}
internal struct ForEachJobMixed3<T, T0, T1, T2, T3, T4, T5, T6, T7>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids) : IChunkJob
	where T : IForEachMixed3<T0, T1, T2, T3, T4, T5, T6, T7>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
		var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index]);
		}
	}
}
internal struct ForEachJobMixed3<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids) : IChunkJob
	where T : IForEachMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
		var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index]);
		}
	}
}
internal struct ForEachJobMixed3<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids) : IChunkJob
	where T : IForEachMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
		var t3Handle = chunk.GetBufferHandle(_offsets.T3);
        var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index]);
		}
	}
}
internal struct ForEachJobMixed4<T, T0, T1, T2, T3, T4>(in T forEach, in Ids<T0, T1, T2, T3, T4> ids) : IChunkJob
	where T : IForEachMixed4<T0, T1, T2, T3, T4>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
		var t4Handle = chunk.GetBufferHandle(_offsets.T4);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], t4Handle[index]);
		}
	}
}
internal struct ForEachJobMixed4<T, T0, T1, T2, T3, T4, T5>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5> ids) : IChunkJob
	where T : IForEachMixed4<T0, T1, T2, T3, T4, T5>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
		var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], t4Handle[index], t5Handle[index]);
		}
	}
}
internal struct ForEachJobMixed4<T, T0, T1, T2, T3, T4, T5, T6>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6> ids) : IChunkJob
	where T : IForEachMixed4<T0, T1, T2, T3, T4, T5, T6>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
		var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index]);
		}
	}
}
internal struct ForEachJobMixed4<T, T0, T1, T2, T3, T4, T5, T6, T7>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids) : IChunkJob
	where T : IForEachMixed4<T0, T1, T2, T3, T4, T5, T6, T7>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
		var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index]);
		}
	}
}
internal struct ForEachJobMixed4<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids) : IChunkJob
	where T : IForEachMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
		var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index]);
		}
	}
}
internal struct ForEachJobMixed4<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids) : IChunkJob
	where T : IForEachMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
		var t4Handle = chunk.GetBufferHandle(_offsets.T4);
        var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index]);
		}
	}
}
internal struct ForEachJobMixed5<T, T0, T1, T2, T3, T4, T5>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5> ids) : IChunkJob
	where T : IForEachMixed5<T0, T1, T2, T3, T4, T5>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
		var t5Handle = chunk.GetBufferHandle(_offsets.T5);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], t5Handle[index]);
		}
	}
}
internal struct ForEachJobMixed5<T, T0, T1, T2, T3, T4, T5, T6>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6> ids) : IChunkJob
	where T : IForEachMixed5<T0, T1, T2, T3, T4, T5, T6>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
		var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], t5Handle[index], t6Handle[index]);
		}
	}
}
internal struct ForEachJobMixed5<T, T0, T1, T2, T3, T4, T5, T6, T7>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids) : IChunkJob
	where T : IForEachMixed5<T0, T1, T2, T3, T4, T5, T6, T7>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
		var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index]);
		}
	}
}
internal struct ForEachJobMixed5<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids) : IChunkJob
	where T : IForEachMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
		var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index]);
		}
	}
}
internal struct ForEachJobMixed5<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids) : IChunkJob
	where T : IForEachMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
		var t5Handle = chunk.GetBufferHandle(_offsets.T5);
        var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index]);
		}
	}
}
internal struct ForEachJobMixed6<T, T0, T1, T2, T3, T4, T5, T6>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6> ids) : IChunkJob
	where T : IForEachMixed6<T0, T1, T2, T3, T4, T5, T6>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
		var t6Handle = chunk.GetBufferHandle(_offsets.T6);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], t6Handle[index]);
		}
	}
}
internal struct ForEachJobMixed6<T, T0, T1, T2, T3, T4, T5, T6, T7>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids) : IChunkJob
	where T : IForEachMixed6<T0, T1, T2, T3, T4, T5, T6, T7>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
		var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], t6Handle[index], t7Handle[index]);
		}
	}
}
internal struct ForEachJobMixed6<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids) : IChunkJob
	where T : IForEachMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
		var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index]);
		}
	}
}
internal struct ForEachJobMixed6<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids) : IChunkJob
	where T : IForEachMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
		var t6Handle = chunk.GetBufferHandle(_offsets.T6);
        var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index]);
		}
	}
}
internal struct ForEachJobMixed7<T, T0, T1, T2, T3, T4, T5, T6, T7>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids) : IChunkJob
	where T : IForEachMixed7<T0, T1, T2, T3, T4, T5, T6, T7>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
		var t7Handle = chunk.GetBufferHandle(_offsets.T7);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], t7Handle[index]);
		}
	}
}
internal struct ForEachJobMixed7<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids) : IChunkJob
	where T : IForEachMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
		var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], t7Handle[index], t8Handle[index]);
		}
	}
}
internal struct ForEachJobMixed7<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids) : IChunkJob
	where T : IForEachMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
		var t7Handle = chunk.GetBufferHandle(_offsets.T7);
        var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], t7Handle[index], t8Handle[index], t9Handle[index]);
		}
	}
}
internal struct ForEachJobMixed8<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids) : IChunkJob
	where T : IForEachMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
        var t7Handle = chunk.GetHandle(_offsets.T7);
		var t8Handle = chunk.GetBufferHandle(_offsets.T8);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], ref t7Handle[index], t8Handle[index]);
		}
	}
}
internal struct ForEachJobMixed8<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids) : IChunkJob
	where T : IForEachMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
        var t7Handle = chunk.GetHandle(_offsets.T7);
		var t8Handle = chunk.GetBufferHandle(_offsets.T8);
        var t9Handle = chunk.GetBufferHandle(_offsets.T9);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], ref t7Handle[index], t8Handle[index], t9Handle[index]);
		}
	}
}
internal struct ForEachJobMixed9<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T forEach, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids) : IChunkJob
	where T : IForEachMixed9<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		var t0Handle = chunk.GetHandle(_offsets.T0);
        var t1Handle = chunk.GetHandle(_offsets.T1);
        var t2Handle = chunk.GetHandle(_offsets.T2);
        var t3Handle = chunk.GetHandle(_offsets.T3);
        var t4Handle = chunk.GetHandle(_offsets.T4);
        var t5Handle = chunk.GetHandle(_offsets.T5);
        var t6Handle = chunk.GetHandle(_offsets.T6);
        var t7Handle = chunk.GetHandle(_offsets.T7);
        var t8Handle = chunk.GetHandle(_offsets.T8);
		var t9Handle = chunk.GetBufferHandle(_offsets.T9);
		foreach (var index in chunk)
		{
			_forEach.ForEach(ref t0Handle[index], ref t1Handle[index], ref t2Handle[index], ref t3Handle[index], ref t4Handle[index], ref t5Handle[index], ref t6Handle[index], ref t7Handle[index], ref t8Handle[index], t9Handle[index]);
		}
	}
}
