namespace EntitiesDb;

public readonly struct ParallelOptions(int maxThreads)
{
	public int MaxThreads { get; } = maxThreads;
}
