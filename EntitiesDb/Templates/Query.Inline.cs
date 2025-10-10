
namespace EntitiesDb;

public partial class Query
{
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1>
	{
		var ids = _componentRegistry.GetIds<T0, T1>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
			foreach (var index in chunk)
			{
				forEach.ForEach(
					ref t0Handle[index],
                    ref t1Handle[index]
				);
			}
		}
	}
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
			foreach (var index in chunk)
			{
				forEach.ForEach(
					ref t0Handle[index],
                    ref t1Handle[index],
                    ref t2Handle[index]
				);
			}
		}
	}
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
			foreach (var index in chunk)
			{
				forEach.ForEach(
					ref t0Handle[index],
                    ref t1Handle[index],
                    ref t2Handle[index],
                    ref t3Handle[index]
				);
			}
		}
	}
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
			foreach (var index in chunk)
			{
				forEach.ForEach(
					ref t0Handle[index],
                    ref t1Handle[index],
                    ref t2Handle[index],
                    ref t3Handle[index],
                    ref t4Handle[index]
				);
			}
		}
	}
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
            var t12Handle = chunk.GetHandle(ids.T12);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
            var t12Handle = chunk.GetHandle(ids.T12);
            var t13Handle = chunk.GetHandle(ids.T13);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
            var t12Handle = chunk.GetHandle(ids.T12);
            var t13Handle = chunk.GetHandle(ids.T13);
            var t14Handle = chunk.GetHandle(ids.T14);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
            var t12Handle = chunk.GetHandle(ids.T12);
            var t13Handle = chunk.GetHandle(ids.T13);
            var t14Handle = chunk.GetHandle(ids.T14);
            var t15Handle = chunk.GetHandle(ids.T15);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
            var t12Handle = chunk.GetHandle(ids.T12);
            var t13Handle = chunk.GetHandle(ids.T13);
            var t14Handle = chunk.GetHandle(ids.T14);
            var t15Handle = chunk.GetHandle(ids.T15);
            var t16Handle = chunk.GetHandle(ids.T16);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
                    ref t15Handle[index],
                    ref t16Handle[index]
				);
			}
		}
	}
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
            var t12Handle = chunk.GetHandle(ids.T12);
            var t13Handle = chunk.GetHandle(ids.T13);
            var t14Handle = chunk.GetHandle(ids.T14);
            var t15Handle = chunk.GetHandle(ids.T15);
            var t16Handle = chunk.GetHandle(ids.T16);
            var t17Handle = chunk.GetHandle(ids.T17);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
                    ref t15Handle[index],
                    ref t16Handle[index],
                    ref t17Handle[index]
				);
			}
		}
	}
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
            var t12Handle = chunk.GetHandle(ids.T12);
            var t13Handle = chunk.GetHandle(ids.T13);
            var t14Handle = chunk.GetHandle(ids.T14);
            var t15Handle = chunk.GetHandle(ids.T15);
            var t16Handle = chunk.GetHandle(ids.T16);
            var t17Handle = chunk.GetHandle(ids.T17);
            var t18Handle = chunk.GetHandle(ids.T18);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
                    ref t15Handle[index],
                    ref t16Handle[index],
                    ref t17Handle[index],
                    ref t18Handle[index]
				);
			}
		}
	}
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
            var t12Handle = chunk.GetHandle(ids.T12);
            var t13Handle = chunk.GetHandle(ids.T13);
            var t14Handle = chunk.GetHandle(ids.T14);
            var t15Handle = chunk.GetHandle(ids.T15);
            var t16Handle = chunk.GetHandle(ids.T16);
            var t17Handle = chunk.GetHandle(ids.T17);
            var t18Handle = chunk.GetHandle(ids.T18);
            var t19Handle = chunk.GetHandle(ids.T19);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
                    ref t15Handle[index],
                    ref t16Handle[index],
                    ref t17Handle[index],
                    ref t18Handle[index],
                    ref t19Handle[index]
				);
			}
		}
	}
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
            var t12Handle = chunk.GetHandle(ids.T12);
            var t13Handle = chunk.GetHandle(ids.T13);
            var t14Handle = chunk.GetHandle(ids.T14);
            var t15Handle = chunk.GetHandle(ids.T15);
            var t16Handle = chunk.GetHandle(ids.T16);
            var t17Handle = chunk.GetHandle(ids.T17);
            var t18Handle = chunk.GetHandle(ids.T18);
            var t19Handle = chunk.GetHandle(ids.T19);
            var t20Handle = chunk.GetHandle(ids.T20);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
                    ref t15Handle[index],
                    ref t16Handle[index],
                    ref t17Handle[index],
                    ref t18Handle[index],
                    ref t19Handle[index],
                    ref t20Handle[index]
				);
			}
		}
	}
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
            var t12Handle = chunk.GetHandle(ids.T12);
            var t13Handle = chunk.GetHandle(ids.T13);
            var t14Handle = chunk.GetHandle(ids.T14);
            var t15Handle = chunk.GetHandle(ids.T15);
            var t16Handle = chunk.GetHandle(ids.T16);
            var t17Handle = chunk.GetHandle(ids.T17);
            var t18Handle = chunk.GetHandle(ids.T18);
            var t19Handle = chunk.GetHandle(ids.T19);
            var t20Handle = chunk.GetHandle(ids.T20);
            var t21Handle = chunk.GetHandle(ids.T21);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
                    ref t15Handle[index],
                    ref t16Handle[index],
                    ref t17Handle[index],
                    ref t18Handle[index],
                    ref t19Handle[index],
                    ref t20Handle[index],
                    ref t21Handle[index]
				);
			}
		}
	}
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
            var t12Handle = chunk.GetHandle(ids.T12);
            var t13Handle = chunk.GetHandle(ids.T13);
            var t14Handle = chunk.GetHandle(ids.T14);
            var t15Handle = chunk.GetHandle(ids.T15);
            var t16Handle = chunk.GetHandle(ids.T16);
            var t17Handle = chunk.GetHandle(ids.T17);
            var t18Handle = chunk.GetHandle(ids.T18);
            var t19Handle = chunk.GetHandle(ids.T19);
            var t20Handle = chunk.GetHandle(ids.T20);
            var t21Handle = chunk.GetHandle(ids.T21);
            var t22Handle = chunk.GetHandle(ids.T22);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
                    ref t15Handle[index],
                    ref t16Handle[index],
                    ref t17Handle[index],
                    ref t18Handle[index],
                    ref t19Handle[index],
                    ref t20Handle[index],
                    ref t21Handle[index],
                    ref t22Handle[index]
				);
			}
		}
	}
	/// <inheritdoc cref="Inline{TForEach, T0}(ref TForEach)"/>
	public void Inline<TForEach, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ref TForEach forEach)
		where TForEach : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>();
		foreach (ref readonly var chunk in GetChunkIterator())
		{
			var t0Handle = chunk.GetHandle(ids.T0);
            var t1Handle = chunk.GetHandle(ids.T1);
            var t2Handle = chunk.GetHandle(ids.T2);
            var t3Handle = chunk.GetHandle(ids.T3);
            var t4Handle = chunk.GetHandle(ids.T4);
            var t5Handle = chunk.GetHandle(ids.T5);
            var t6Handle = chunk.GetHandle(ids.T6);
            var t7Handle = chunk.GetHandle(ids.T7);
            var t8Handle = chunk.GetHandle(ids.T8);
            var t9Handle = chunk.GetHandle(ids.T9);
            var t10Handle = chunk.GetHandle(ids.T10);
            var t11Handle = chunk.GetHandle(ids.T11);
            var t12Handle = chunk.GetHandle(ids.T12);
            var t13Handle = chunk.GetHandle(ids.T13);
            var t14Handle = chunk.GetHandle(ids.T14);
            var t15Handle = chunk.GetHandle(ids.T15);
            var t16Handle = chunk.GetHandle(ids.T16);
            var t17Handle = chunk.GetHandle(ids.T17);
            var t18Handle = chunk.GetHandle(ids.T18);
            var t19Handle = chunk.GetHandle(ids.T19);
            var t20Handle = chunk.GetHandle(ids.T20);
            var t21Handle = chunk.GetHandle(ids.T21);
            var t22Handle = chunk.GetHandle(ids.T22);
            var t23Handle = chunk.GetHandle(ids.T23);
			foreach (var index in chunk)
			{
				forEach.ForEach(
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
                    ref t15Handle[index],
                    ref t16Handle[index],
                    ref t17Handle[index],
                    ref t18Handle[index],
                    ref t19Handle[index],
                    ref t20Handle[index],
                    ref t21Handle[index],
                    ref t22Handle[index],
                    ref t23Handle[index]
				);
			}
		}
	}
}