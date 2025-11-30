using System;

namespace EntitiesDb;

public static class JobMeta
{
	internal static ObjectPool<SpanList<ChunkRange>> RangesPool { get; } = new(() => new(256), Environment.ProcessorCount, prefill: Environment.ProcessorCount);

	public static void Prefill<T>() where T : IChunkJob
	{
		var jobPool = JobMeta<T>.JobPool;
		var arrayPool = JobMeta<T>.ArrayPool;
	}
}
internal static class JobMeta<T> where T : IChunkJob
{
	public static ObjectPool<ChunkJob<T>> JobPool { get; } = new(() => new(), Environment.ProcessorCount * 16, prefill: Environment.ProcessorCount * 4);
	public static ObjectPool<IJob?[]> ArrayPool { get; } = new(() => new IJob?[Environment.ProcessorCount], Environment.ProcessorCount, prefill: Environment.ProcessorCount);
}
