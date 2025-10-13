
namespace EntitiesDb;

public partial class Query
{
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1>
	{
		var ids = _componentRegistry.GetIds<T0, T1>();
		var job = new ForEachJob<T, T0, T1>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2>();
		var job = new ForEachJob<T, T0, T1, T2>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3>();
		var job = new ForEachJob<T, T0, T1, T2, T3>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3, T4>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3, T4>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4>();
		var job = new ForEachJob<T, T0, T1, T2, T3, T4>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3, T4, T5>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3, T4, T5>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5>();
		var job = new ForEachJob<T, T0, T1, T2, T3, T4, T5>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3, T4, T5, T6>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3, T4, T5, T6>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6>();
		var job = new ForEachJob<T, T0, T1, T2, T3, T4, T5, T6>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3, T4, T5, T6, T7>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7>();
		var job = new ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		var job = new ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		var job = new ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
		var job = new ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
		var job = new ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
		var job = new ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>();
		var job = new ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>();
		var job = new ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
	/// <inheritdoc cref="Inline{T, T0}(ref T)"/>
	public void InlineParallel<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
	{
		var ids = _componentRegistry.GetIds<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>();
		var job = new ForEachJob<T, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
}