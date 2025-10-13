
using System;

namespace EntitiesDb;

public partial class Query
{
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed1<T, T0, T1>(ref T forEach)
		where T : IForEachChunkMixed1<T0, T1>
		where T1 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
					t1Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed1<T, T0, T1, T2>(ref T forEach)
		where T : IForEachChunkMixed1<T0, T1, T2>
		where T1 : unmanaged
        where T2 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
					t1Handle,
                    t2Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed1<T, T0, T1, T2, T3>(ref T forEach)
		where T : IForEachChunkMixed1<T0, T1, T2, T3>
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
					t1Handle,
                    t2Handle,
                    t3Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed1<T, T0, T1, T2, T3, T4>(ref T forEach)
		where T : IForEachChunkMixed1<T0, T1, T2, T3, T4>
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
					t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed1<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachChunkMixed1<T0, T1, T2, T3, T4, T5>
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
					t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed1<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachChunkMixed1<T0, T1, T2, T3, T4, T5, T6>
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
					t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed1<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachChunkMixed1<T0, T1, T2, T3, T4, T5, T6, T7>
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
					t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed1<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachChunkMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8>
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
					t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle,
                    t8Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed1<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachChunkMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
					t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle,
                    t8Handle,
                    t9Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed2<T, T0, T1, T2>(ref T forEach)
		where T : IForEachChunkMixed2<T0, T1, T2>
		where T2 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
					t2Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed2<T, T0, T1, T2, T3>(ref T forEach)
		where T : IForEachChunkMixed2<T0, T1, T2, T3>
		where T2 : unmanaged
        where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
					t2Handle,
                    t3Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed2<T, T0, T1, T2, T3, T4>(ref T forEach)
		where T : IForEachChunkMixed2<T0, T1, T2, T3, T4>
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
					t2Handle,
                    t3Handle,
                    t4Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed2<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachChunkMixed2<T0, T1, T2, T3, T4, T5>
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
					t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed2<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachChunkMixed2<T0, T1, T2, T3, T4, T5, T6>
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
					t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed2<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachChunkMixed2<T0, T1, T2, T3, T4, T5, T6, T7>
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
					t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed2<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachChunkMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8>
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
					t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle,
                    t8Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed2<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachChunkMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
					t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle,
                    t8Handle,
                    t9Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed3<T, T0, T1, T2, T3>(ref T forEach)
		where T : IForEachChunkMixed3<T0, T1, T2, T3>
		where T3 : unmanaged
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
				var t3Handle = chunk.GetBufferHandle(offsets.T3);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
					t3Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed3<T, T0, T1, T2, T3, T4>(ref T forEach)
		where T : IForEachChunkMixed3<T0, T1, T2, T3, T4>
		where T3 : unmanaged
        where T4 : unmanaged
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
				var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
					t3Handle,
                    t4Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed3<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachChunkMixed3<T0, T1, T2, T3, T4, T5>
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
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
				var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
					t3Handle,
                    t4Handle,
                    t5Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed3<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachChunkMixed3<T0, T1, T2, T3, T4, T5, T6>
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
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
				var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
					t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed3<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachChunkMixed3<T0, T1, T2, T3, T4, T5, T6, T7>
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
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
				var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
					t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed3<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachChunkMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8>
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
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
				var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
					t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle,
                    t8Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed3<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachChunkMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
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
				var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
					t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle,
                    t8Handle,
                    t9Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed4<T, T0, T1, T2, T3, T4>(ref T forEach)
		where T : IForEachChunkMixed4<T0, T1, T2, T3, T4>
		where T4 : unmanaged
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
				var t4Handle = chunk.GetBufferHandle(offsets.T4);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
					t4Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed4<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachChunkMixed4<T0, T1, T2, T3, T4, T5>
		where T4 : unmanaged
        where T5 : unmanaged
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
				var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
					t4Handle,
                    t5Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed4<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachChunkMixed4<T0, T1, T2, T3, T4, T5, T6>
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
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
				var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
					t4Handle,
                    t5Handle,
                    t6Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed4<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachChunkMixed4<T0, T1, T2, T3, T4, T5, T6, T7>
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
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
				var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
					t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed4<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachChunkMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8>
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
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
				var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
					t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle,
                    t8Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed4<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachChunkMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
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
				var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
					t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle,
                    t8Handle,
                    t9Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed5<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachChunkMixed5<T0, T1, T2, T3, T4, T5>
		where T5 : unmanaged
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
				var t5Handle = chunk.GetBufferHandle(offsets.T5);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
					t5Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed5<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachChunkMixed5<T0, T1, T2, T3, T4, T5, T6>
		where T5 : unmanaged
        where T6 : unmanaged
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
				var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
					t5Handle,
                    t6Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed5<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachChunkMixed5<T0, T1, T2, T3, T4, T5, T6, T7>
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
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
				var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
					t5Handle,
                    t6Handle,
                    t7Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed5<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachChunkMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8>
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
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
				var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
					t5Handle,
                    t6Handle,
                    t7Handle,
                    t8Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed5<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachChunkMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
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
				var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
					t5Handle,
                    t6Handle,
                    t7Handle,
                    t8Handle,
                    t9Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed6<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachChunkMixed6<T0, T1, T2, T3, T4, T5, T6>
		where T6 : unmanaged
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
				var t6Handle = chunk.GetBufferHandle(offsets.T6);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
					t6Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed6<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachChunkMixed6<T0, T1, T2, T3, T4, T5, T6, T7>
		where T6 : unmanaged
        where T7 : unmanaged
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
				var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
					t6Handle,
                    t7Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed6<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachChunkMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8>
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
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
				var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
					t6Handle,
                    t7Handle,
                    t8Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed6<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachChunkMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
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
				var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
					t6Handle,
                    t7Handle,
                    t8Handle,
                    t9Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed7<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachChunkMixed7<T0, T1, T2, T3, T4, T5, T6, T7>
		where T7 : unmanaged
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
				var t7Handle = chunk.GetBufferHandle(offsets.T7);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
					t7Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed7<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachChunkMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8>
		where T7 : unmanaged
        where T8 : unmanaged
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
				var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
					t7Handle,
                    t8Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed7<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachChunkMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
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
				var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
					t7Handle,
                    t8Handle,
                    t9Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed8<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachChunkMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8>
		where T8 : unmanaged
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
				var t8Handle = chunk.GetBufferHandle(offsets.T8);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle,
					t8Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed8<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachChunkMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
		where T8 : unmanaged
        where T9 : unmanaged
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
				var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle,
					t8Handle,
                    t9Handle
				);
			}
		}
	}
	/// <inheritdoc cref="InlineChunk{T, T0}(ref T)"/>
	public void InlineChunkMixed9<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachChunkMixed9<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
		where T9 : unmanaged
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
				var t9Handle = chunk.GetBufferHandle(offsets.T9);
				forEach.ForEach(
					chunk.EntityCount,
					t0Handle,
                    t1Handle,
                    t2Handle,
                    t3Handle,
                    t4Handle,
                    t5Handle,
                    t6Handle,
                    t7Handle,
                    t8Handle,
					t9Handle
				);
			}
		}
	}
}