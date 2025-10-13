
namespace EntitiesDb;

public partial class Query
{
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1>(ref T forEach)
		where T : IForEachChunk<T0, T1>
	{
		var ids = _componentRegistry.GetIds<T0, T1>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3, T4>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3, T4>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle, t4Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3, T4, T5>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle, t4Handle, t5Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3, T4, T5, T6>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle, t4Handle, t5Handle, t6Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3, T4, T5, T6, T7>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
                var t7Handle = chunk.GetHandle(offsets.T7);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle, t4Handle, t5Handle, t6Handle, t7Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
                var t7Handle = chunk.GetHandle(offsets.T7);
                var t8Handle = chunk.GetHandle(offsets.T8);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle, t4Handle, t5Handle, t6Handle, t7Handle, t8Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
                var t7Handle = chunk.GetHandle(offsets.T7);
                var t8Handle = chunk.GetHandle(offsets.T8);
                var t9Handle = chunk.GetHandle(offsets.T9);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle, t4Handle, t5Handle, t6Handle, t7Handle, t8Handle, t9Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
                var t7Handle = chunk.GetHandle(offsets.T7);
                var t8Handle = chunk.GetHandle(offsets.T8);
                var t9Handle = chunk.GetHandle(offsets.T9);
                var t10Handle = chunk.GetHandle(offsets.T10);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle, t4Handle, t5Handle, t6Handle, t7Handle, t8Handle, t9Handle, t10Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
                var t7Handle = chunk.GetHandle(offsets.T7);
                var t8Handle = chunk.GetHandle(offsets.T8);
                var t9Handle = chunk.GetHandle(offsets.T9);
                var t10Handle = chunk.GetHandle(offsets.T10);
                var t11Handle = chunk.GetHandle(offsets.T11);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle, t4Handle, t5Handle, t6Handle, t7Handle, t8Handle, t9Handle, t10Handle, t11Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
                var t7Handle = chunk.GetHandle(offsets.T7);
                var t8Handle = chunk.GetHandle(offsets.T8);
                var t9Handle = chunk.GetHandle(offsets.T9);
                var t10Handle = chunk.GetHandle(offsets.T10);
                var t11Handle = chunk.GetHandle(offsets.T11);
                var t12Handle = chunk.GetHandle(offsets.T12);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle, t4Handle, t5Handle, t6Handle, t7Handle, t8Handle, t9Handle, t10Handle, t11Handle, t12Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
                var t7Handle = chunk.GetHandle(offsets.T7);
                var t8Handle = chunk.GetHandle(offsets.T8);
                var t9Handle = chunk.GetHandle(offsets.T9);
                var t10Handle = chunk.GetHandle(offsets.T10);
                var t11Handle = chunk.GetHandle(offsets.T11);
                var t12Handle = chunk.GetHandle(offsets.T12);
                var t13Handle = chunk.GetHandle(offsets.T13);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle, t4Handle, t5Handle, t6Handle, t7Handle, t8Handle, t9Handle, t10Handle, t11Handle, t12Handle, t13Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
                var t7Handle = chunk.GetHandle(offsets.T7);
                var t8Handle = chunk.GetHandle(offsets.T8);
                var t9Handle = chunk.GetHandle(offsets.T9);
                var t10Handle = chunk.GetHandle(offsets.T10);
                var t11Handle = chunk.GetHandle(offsets.T11);
                var t12Handle = chunk.GetHandle(offsets.T12);
                var t13Handle = chunk.GetHandle(offsets.T13);
                var t14Handle = chunk.GetHandle(offsets.T14);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle, t4Handle, t5Handle, t6Handle, t7Handle, t8Handle, t9Handle, t10Handle, t11Handle, t12Handle, t13Handle, t14Handle);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunk<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref T forEach)
		where T : IForEachChunk<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
                var t7Handle = chunk.GetHandle(offsets.T7);
                var t8Handle = chunk.GetHandle(offsets.T8);
                var t9Handle = chunk.GetHandle(offsets.T9);
                var t10Handle = chunk.GetHandle(offsets.T10);
                var t11Handle = chunk.GetHandle(offsets.T11);
                var t12Handle = chunk.GetHandle(offsets.T12);
                var t13Handle = chunk.GetHandle(offsets.T13);
                var t14Handle = chunk.GetHandle(offsets.T14);
                var t15Handle = chunk.GetHandle(offsets.T15);
				forEach.ForEach(chunk.EntityCount, t0Handle, t1Handle, t2Handle, t3Handle, t4Handle, t5Handle, t6Handle, t7Handle, t8Handle, t9Handle, t10Handle, t11Handle, t12Handle, t13Handle, t14Handle, t15Handle);
			}
		}
	}
}