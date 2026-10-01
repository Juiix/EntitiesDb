using System;

namespace EntitiesDb;

public static class JobMeta
{
	internal static ObjectPool<ChunkJobWork> WorkPool { get; } = new(() => new(), Environment.ProcessorCount, prefill: 2);

	public static void Prefill<T>() where T : IChunkJob
	{
		var jobPool = JobMeta<T>.JobPool;
	}
}
internal static class JobMeta<T> where T : IChunkJob
{
	public static ObjectPool<ChunkJob<T>> JobPool { get; } = new(() => new(), Environment.ProcessorCount * 16, prefill: Environment.ProcessorCount * 4);
}
