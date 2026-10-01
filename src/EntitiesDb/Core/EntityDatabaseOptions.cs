namespace EntitiesDb;

/// <summary>
/// Options for creating an <see cref="EntityDatabase"/> instance
/// </summary>
/// <param name="chunkByteSize">Byte-size of entity chunks</param>
/// <param name="maxEntities">Maximum amount of entities that can be created</param>
/// <param name="parallelThreads">How many threads to use for parallel execution, -1 to disable parallel</param>
public readonly struct EntityDatabaseOptions(int chunkByteSize = EntityDatabaseOptions.DefaultChunkByteSize, int maxEntities = int.MaxValue, int parallelThreads = -1)
{
	/// <summary>
	/// The default <see cref="ChunkByteSize"/> (16 KB)
	/// </summary>
	public const int DefaultChunkByteSize = 16384;

	/// <summary>
	/// Default options: 16 KB chunks, unlimited entities, parallel execution disabled
	/// </summary>
	public static EntityDatabaseOptions Default => new();

	/// <summary>
	/// Creates options with default values: 16 KB chunks, unlimited entities, parallel execution disabled
	/// </summary>
	public EntityDatabaseOptions() : this(DefaultChunkByteSize, int.MaxValue, -1) { }

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
