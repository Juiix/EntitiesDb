
using System;

namespace EntitiesDb;

public partial class Query
{
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed1<T, T0, T1>(ref T forEach)
		where T : IForEachEntityMixed1<T0, T1>
		where T1 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
						t1Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed1<T, T0, T1, T2>(ref T forEach)
		where T : IForEachEntityMixed1<T0, T1, T2>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
						t1Handle[index],
                        t2Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed1<T, T0, T1, T2, T3>(ref T forEach)
		where T : IForEachEntityMixed1<T0, T1, T2, T3>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
						t1Handle[index],
                        t2Handle[index],
                        t3Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed1<T, T0, T1, T2, T3, T4>(ref T forEach)
		where T : IForEachEntityMixed1<T0, T1, T2, T3, T4>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
						t1Handle[index],
                        t2Handle[index],
                        t3Handle[index],
                        t4Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed1<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachEntityMixed1<T0, T1, T2, T3, T4, T5>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
				var t1Handle = chunk.GetBufferHandle(offsets.T1);
                var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed1<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachEntityMixed1<T0, T1, T2, T3, T4, T5, T6>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
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
						ref t0Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed1<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachEntityMixed1<T0, T1, T2, T3, T4, T5, T6, T7>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
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
						ref t0Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed1<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachEntityMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
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
						ref t0Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed1<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachEntityMixed1<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed2<T, T0, T1, T2>(ref T forEach)
		where T : IForEachEntityMixed2<T0, T1, T2>
		where T2 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
						t2Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed2<T, T0, T1, T2, T3>(ref T forEach)
		where T : IForEachEntityMixed2<T0, T1, T2, T3>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
						t2Handle[index],
                        t3Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed2<T, T0, T1, T2, T3, T4>(ref T forEach)
		where T : IForEachEntityMixed2<T0, T1, T2, T3, T4>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
						t2Handle[index],
                        t3Handle[index],
                        t4Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed2<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachEntityMixed2<T0, T1, T2, T3, T4, T5>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
						t2Handle[index],
                        t3Handle[index],
                        t4Handle[index],
                        t5Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed2<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachEntityMixed2<T0, T1, T2, T3, T4, T5, T6>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				var t2Handle = chunk.GetBufferHandle(offsets.T2);
                var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed2<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachEntityMixed2<T0, T1, T2, T3, T4, T5, T6, T7>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
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
						ref t0Handle[index],
                        ref t1Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed2<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachEntityMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
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
						ref t0Handle[index],
                        ref t1Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed2<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachEntityMixed2<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed3<T, T0, T1, T2, T3>(ref T forEach)
		where T : IForEachEntityMixed3<T0, T1, T2, T3>
		where T3 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
				var t3Handle = chunk.GetBufferHandle(offsets.T3);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
						t3Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed3<T, T0, T1, T2, T3, T4>(ref T forEach)
		where T : IForEachEntityMixed3<T0, T1, T2, T3, T4>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
				var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
						t3Handle[index],
                        t4Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed3<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachEntityMixed3<T0, T1, T2, T3, T4, T5>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
				var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
						t3Handle[index],
                        t4Handle[index],
                        t5Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed3<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachEntityMixed3<T0, T1, T2, T3, T4, T5, T6>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
				var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
						t3Handle[index],
                        t4Handle[index],
                        t5Handle[index],
                        t6Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed3<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachEntityMixed3<T0, T1, T2, T3, T4, T5, T6, T7>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
				var t3Handle = chunk.GetBufferHandle(offsets.T3);
                var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed3<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachEntityMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
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
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed3<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachEntityMixed3<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed4<T, T0, T1, T2, T3, T4>(ref T forEach)
		where T : IForEachEntityMixed4<T0, T1, T2, T3, T4>
		where T4 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
				var t4Handle = chunk.GetBufferHandle(offsets.T4);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
						t4Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed4<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachEntityMixed4<T0, T1, T2, T3, T4, T5>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
				var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
						t4Handle[index],
                        t5Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed4<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachEntityMixed4<T0, T1, T2, T3, T4, T5, T6>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
				var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
						t4Handle[index],
                        t5Handle[index],
                        t6Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed4<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachEntityMixed4<T0, T1, T2, T3, T4, T5, T6, T7>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
				var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
						t4Handle[index],
                        t5Handle[index],
                        t6Handle[index],
                        t7Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed4<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachEntityMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
				var t4Handle = chunk.GetBufferHandle(offsets.T4);
                var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed4<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachEntityMixed4<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed5<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachEntityMixed5<T0, T1, T2, T3, T4, T5>
		where T5 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
				var t5Handle = chunk.GetBufferHandle(offsets.T5);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
						t5Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed5<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachEntityMixed5<T0, T1, T2, T3, T4, T5, T6>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
				var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
						t5Handle[index],
                        t6Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed5<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachEntityMixed5<T0, T1, T2, T3, T4, T5, T6, T7>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
				var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
						t5Handle[index],
                        t6Handle[index],
                        t7Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed5<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachEntityMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
				var t5Handle = chunk.GetBufferHandle(offsets.T5);
                var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
						t5Handle[index],
                        t6Handle[index],
                        t7Handle[index],
                        t8Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed5<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachEntityMixed5<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
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
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed6<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachEntityMixed6<T0, T1, T2, T3, T4, T5, T6>
		where T6 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
				var t6Handle = chunk.GetBufferHandle(offsets.T6);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
                        ref t5Handle[index],
						t6Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed6<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachEntityMixed6<T0, T1, T2, T3, T4, T5, T6, T7>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
				var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
                        ref t5Handle[index],
						t6Handle[index],
                        t7Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed6<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachEntityMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
				var t6Handle = chunk.GetBufferHandle(offsets.T6);
                var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
                        ref t5Handle[index],
						t6Handle[index],
                        t7Handle[index],
                        t8Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed6<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachEntityMixed6<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
                        ref t5Handle[index],
						t6Handle[index],
                        t7Handle[index],
                        t8Handle[index],
                        t9Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed7<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachEntityMixed7<T0, T1, T2, T3, T4, T5, T6, T7>
		where T7 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
				var t7Handle = chunk.GetBufferHandle(offsets.T7);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
                        ref t5Handle[index],
                        ref t6Handle[index],
						t7Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed7<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachEntityMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
				var t7Handle = chunk.GetBufferHandle(offsets.T7);
                var t8Handle = chunk.GetBufferHandle(offsets.T8);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
                        ref t5Handle[index],
                        ref t6Handle[index],
						t7Handle[index],
                        t8Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed7<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachEntityMixed7<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
                        ref t5Handle[index],
                        ref t6Handle[index],
						t7Handle[index],
                        t8Handle[index],
                        t9Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed8<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachEntityMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8>
		where T8 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
                var t2Handle = chunk.GetHandle(offsets.T2);
                var t3Handle = chunk.GetHandle(offsets.T3);
                var t4Handle = chunk.GetHandle(offsets.T4);
                var t5Handle = chunk.GetHandle(offsets.T5);
                var t6Handle = chunk.GetHandle(offsets.T6);
                var t7Handle = chunk.GetHandle(offsets.T7);
				var t8Handle = chunk.GetBufferHandle(offsets.T8);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
                        ref t5Handle[index],
                        ref t6Handle[index],
                        ref t7Handle[index],
						t8Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed8<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachEntityMixed8<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
                        ref t5Handle[index],
                        ref t6Handle[index],
                        ref t7Handle[index],
						t8Handle[index],
                        t9Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntityMixed9<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachEntityMixed9<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
		where T9 : unmanaged
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
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
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
                        ref t5Handle[index],
                        ref t6Handle[index],
                        ref t7Handle[index],
                        ref t8Handle[index],
						t9Handle[index]
					);
				}
			}
		}
	}
}