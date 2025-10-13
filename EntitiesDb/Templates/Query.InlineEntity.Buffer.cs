
namespace EntitiesDb;

public partial class Query
{
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1>
		where T0 : unmanaged
        where T1 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2>
		where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3>
		where T0 : unmanaged
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
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3, T4>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3, T4>
		where T0 : unmanaged
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
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3, T4, T5>
		where T0 : unmanaged
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
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index],
                        t5Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3, T4, T5, T6>
		where T0 : unmanaged
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
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index],
                        t5Handle[index],
                        t6Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3, T4, T5, T6, T7>
		where T0 : unmanaged
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
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index],
                        t5Handle[index],
                        t6Handle[index],
                        t7Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index],
                        t5Handle[index],
                        t6Handle[index],
                        t7Handle[index],
                        t8Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index],
                        t5Handle[index],
                        t6Handle[index],
                        t7Handle[index],
                        t8Handle[index],
                        t9Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
                var t10Handle = chunk.GetBufferHandle(offsets.T10);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index],
                        t5Handle[index],
                        t6Handle[index],
                        t7Handle[index],
                        t8Handle[index],
                        t9Handle[index],
                        t10Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
                var t10Handle = chunk.GetBufferHandle(offsets.T10);
                var t11Handle = chunk.GetBufferHandle(offsets.T11);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index],
                        t5Handle[index],
                        t6Handle[index],
                        t7Handle[index],
                        t8Handle[index],
                        t9Handle[index],
                        t10Handle[index],
                        t11Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
                var t10Handle = chunk.GetBufferHandle(offsets.T10);
                var t11Handle = chunk.GetBufferHandle(offsets.T11);
                var t12Handle = chunk.GetBufferHandle(offsets.T12);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index],
                        t5Handle[index],
                        t6Handle[index],
                        t7Handle[index],
                        t8Handle[index],
                        t9Handle[index],
                        t10Handle[index],
                        t11Handle[index],
                        t12Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
                var t10Handle = chunk.GetBufferHandle(offsets.T10);
                var t11Handle = chunk.GetBufferHandle(offsets.T11);
                var t12Handle = chunk.GetBufferHandle(offsets.T12);
                var t13Handle = chunk.GetBufferHandle(offsets.T13);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index],
                        t5Handle[index],
                        t6Handle[index],
                        t7Handle[index],
                        t8Handle[index],
                        t9Handle[index],
                        t10Handle[index],
                        t11Handle[index],
                        t12Handle[index],
                        t13Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
                var t10Handle = chunk.GetBufferHandle(offsets.T10);
                var t11Handle = chunk.GetBufferHandle(offsets.T11);
                var t12Handle = chunk.GetBufferHandle(offsets.T12);
                var t13Handle = chunk.GetBufferHandle(offsets.T13);
                var t14Handle = chunk.GetBufferHandle(offsets.T14);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index],
                        t5Handle[index],
                        t6Handle[index],
                        t7Handle[index],
                        t8Handle[index],
                        t9Handle[index],
                        t10Handle[index],
                        t11Handle[index],
                        t12Handle[index],
                        t13Handle[index],
                        t14Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntityBuffer{T, T0}(ref T)"/>
	public void InlineEntityBuffer<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref T forEach)
		where T : IForEachEntityBuffer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
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
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetBufferHandle(offsets.T0);
                var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
                var t9Handle = chunk.GetBufferHandle(offsets.T9);
                var t10Handle = chunk.GetBufferHandle(offsets.T10);
                var t11Handle = chunk.GetBufferHandle(offsets.T11);
                var t12Handle = chunk.GetBufferHandle(offsets.T12);
                var t13Handle = chunk.GetBufferHandle(offsets.T13);
                var t14Handle = chunk.GetBufferHandle(offsets.T14);
                var t15Handle = chunk.GetBufferHandle(offsets.T15);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						t0Handle[index],
                        t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index],
                        t5Handle[index],
                        t6Handle[index],
                        t7Handle[index],
                        t8Handle[index],
                        t9Handle[index],
                        t10Handle[index],
                        t11Handle[index],
                        t12Handle[index],
                        t13Handle[index],
                        t14Handle[index],
                        t15Handle[index]
					);
				}
			}
		}
	}
}