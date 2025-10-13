using System;

namespace EntitiesDb;

public struct EntityDatabaseOptions(int chunkByteSize = 16384, int maxEntities = int.MaxValue, int parallelThreads = -1)
{
	public int ChunkByteSize { get; set; } = chunkByteSize;
	public int MaxEntities { get; set; } = maxEntities;
	public int ParallelThreads { get; set; } = parallelThreads;
}
