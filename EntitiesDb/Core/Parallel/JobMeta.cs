using Schedulers;
using System;
using System.Collections.Generic;

namespace EntitiesDb;

internal static class JobMeta<T> where T : IChunkJob
{
	public static ObjectPool<ChunkJob<T>> JobPool { get; } = new(() => new(), 4096, prefill: 32);
	public static ObjectPool<IJob?[]> ArrayPool { get; } = new(() => new IJob?[Environment.ProcessorCount], 256, prefill: 8);
}
