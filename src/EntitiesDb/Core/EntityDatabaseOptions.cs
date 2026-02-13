namespace EntitiesDb;

/// <summary>
/// Options for creating an <see cref="EntityDatabase"/> instance
/// </summary>
/// <param name="chunkByteSize">Byte-size of entity chunks</param>
/// <param name="maxEntities">Maximum amount of entities that can be created</param>
/// <param name="parallelThreads">How many threads to use for parallel execution, -1 to disable parallel</param>
public readonly struct EntityDatabaseOptions(int chunkByteSize = 16384, int maxEntities = int.MaxValue, int parallelThreads = -1)
{
	/// <summary>
	/// Byte-size of entity chunks
	/// </summary>
	public readonly int ChunkByteSize = chunkByteSize;

	/// <summary>
	/// Maximum amount of entities that can be created
	/// </summary>
	public readonly int MaxEntities = maxEntities;

	/// <summary>
	/// How many threads to use for parallel execution, -1 to disable parallel
	/// </summary>
	public readonly int ParallelThreads = parallelThreads;
}
