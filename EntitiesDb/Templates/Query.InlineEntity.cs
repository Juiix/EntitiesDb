
namespace EntitiesDb;

public partial class Query
{
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1>(ref T forEach)
		where T : IForEachEntity<T0, T1>
	{
		var ids = _componentRegistry.GetIds<T0, T1>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offsets = archetype.GetOffsets(in ids);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var t0Handle = chunk.GetHandle(offsets.T0);
                var t1Handle = chunk.GetHandle(offsets.T1);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2>
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
                var t2Handle = chunk.GetHandle(offsets.T2);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3>
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
                var t3Handle = chunk.GetHandle(offsets.T3);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3, T4>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3, T4>
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
                var t4Handle = chunk.GetHandle(offsets.T4);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3, T4, T5>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3, T4, T5>
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
                var t5Handle = chunk.GetHandle(offsets.T5);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref t0Handle[index],
                        ref t1Handle[index],
                        ref t2Handle[index],
                        ref t3Handle[index],
                        ref t4Handle[index],
                        ref t5Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3, T4, T5, T6>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3, T4, T5, T6>
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
                var t6Handle = chunk.GetHandle(offsets.T6);
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
                        ref t6Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3, T4, T5, T6, T7>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3, T4, T5, T6, T7>
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
                var t7Handle = chunk.GetHandle(offsets.T7);
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
                        ref t7Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
                var t8Handle = chunk.GetHandle(offsets.T8);
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
                        ref t8Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
                var t9Handle = chunk.GetHandle(offsets.T9);
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
                        ref t9Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
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
                var t9Handle = chunk.GetHandle(offsets.T9);
                var t10Handle = chunk.GetHandle(offsets.T10);
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
                        ref t9Handle[index],
                        ref t10Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
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
                var t9Handle = chunk.GetHandle(offsets.T9);
                var t10Handle = chunk.GetHandle(offsets.T10);
                var t11Handle = chunk.GetHandle(offsets.T11);
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
                        ref t9Handle[index],
                        ref t10Handle[index],
                        ref t11Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
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
                var t9Handle = chunk.GetHandle(offsets.T9);
                var t10Handle = chunk.GetHandle(offsets.T10);
                var t11Handle = chunk.GetHandle(offsets.T11);
                var t12Handle = chunk.GetHandle(offsets.T12);
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
                        ref t9Handle[index],
                        ref t10Handle[index],
                        ref t11Handle[index],
                        ref t12Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
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
                var t9Handle = chunk.GetHandle(offsets.T9);
                var t10Handle = chunk.GetHandle(offsets.T10);
                var t11Handle = chunk.GetHandle(offsets.T11);
                var t12Handle = chunk.GetHandle(offsets.T12);
                var t13Handle = chunk.GetHandle(offsets.T13);
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
                        ref t9Handle[index],
                        ref t10Handle[index],
                        ref t11Handle[index],
                        ref t12Handle[index],
                        ref t13Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
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
                var t9Handle = chunk.GetHandle(offsets.T9);
                var t10Handle = chunk.GetHandle(offsets.T10);
                var t11Handle = chunk.GetHandle(offsets.T11);
                var t12Handle = chunk.GetHandle(offsets.T12);
                var t13Handle = chunk.GetHandle(offsets.T13);
                var t14Handle = chunk.GetHandle(offsets.T14);
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
                        ref t9Handle[index],
                        ref t10Handle[index],
                        ref t11Handle[index],
                        ref t12Handle[index],
                        ref t13Handle[index],
                        ref t14Handle[index]
					);
				}
			}
		}
	}
	/// <inheritdoc cref="InlineEntity{T, T0}(ref T)"/>
	public void InlineEntity<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref T forEach)
		where T : IForEachEntity<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
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
                var t9Handle = chunk.GetHandle(offsets.T9);
                var t10Handle = chunk.GetHandle(offsets.T10);
                var t11Handle = chunk.GetHandle(offsets.T11);
                var t12Handle = chunk.GetHandle(offsets.T12);
                var t13Handle = chunk.GetHandle(offsets.T13);
                var t14Handle = chunk.GetHandle(offsets.T14);
                var t15Handle = chunk.GetHandle(offsets.T15);
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
                        ref t9Handle[index],
                        ref t10Handle[index],
                        ref t11Handle[index],
                        ref t12Handle[index],
                        ref t13Handle[index],
                        ref t14Handle[index],
                        ref t15Handle[index]
					);
				}
			}
		}
	}
}