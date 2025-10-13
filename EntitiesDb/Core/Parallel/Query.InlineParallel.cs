using System;

namespace EntitiesDb;

public partial class Query
{
	public void InlineParallel<T>(in T forEach, ParallelOptions options = default)
		where T : IForEach
	{
		var job = new ForEachJob<T>(in forEach);
		InlineChunkJobParallel(in job, options);
	}

	public void InlineParallel<T, T0>(in T forEach, ParallelOptions options = default)
		where T : IForEach<T0>
	{
		var ids = _componentRegistry.GetIds<T0>();
		var job = new ForEachJob<T, T0>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}

	public void InlineChunkParallel<T, T0>(in T forEach, ParallelOptions options = default)
		where T : IForEachChunk<T0>
	{
		var ids = _componentRegistry.GetIds<T0>();
		var job = new ForEachChunkJob<T, T0>(in forEach, in ids);
		InlineChunkJobParallel(in job, options);
	}
}
