namespace EntitiesDb;

internal struct ForEachJob<T>(in T forEach) : IChunkJob
	where T : IForEach
{
	private readonly T _forEach = forEach;

	public void Enter(Archetype archetype)
	{

	}

	public void ForEach(in Chunk chunk)
	{
		foreach (var index in chunk)
		{
			_forEach.ForEach();
		}
	}
}
internal struct ForEachEntityJob<T>(in T forEach) : IChunkJob
	where T : IForEachEntity
{
	private readonly T _forEach = forEach;

	public void Enter(Archetype archetype)
	{

	}

	public void ForEach(in Chunk chunk)
	{
		var entities = chunk.GetEntityHandle();
		foreach (var index in chunk)
		{
			_forEach.ForEach(entities[index]);
		}
	}
}

internal struct ForEachChunkJob<T>(in T forEach) : IChunkJob
	where T : IForEachChunk
{
	private readonly T _forEach = forEach;

	public void Enter(Archetype archetype)
	{

	}

	public void ForEach(in Chunk chunk)
	{
		_forEach.ForEach(chunk.EntityCount);
	}
}

internal struct ForEachChunkEntityJob<T>(in T forEach) : IChunkJob
	where T : IForEachChunkEntity
{
	private readonly T _forEach = forEach;

	public void Enter(Archetype archetype)
	{

	}

	public void ForEach(in Chunk chunk)
	{
		var entities = chunk.GetEntityHandle();
		_forEach.ForEach(chunk.EntityCount, entities);
	}
}