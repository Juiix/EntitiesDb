namespace EntitiesDb;

public partial class Query
{
	public void ChunkJob<T>(ref T job) where T : IChunkJob
	{
		foreach (var archetype in GetArchetypeIterator())
		{
			job.Enter(archetype);
			foreach (ref readonly var chunk in archetype)
			{
				job.ForEach(in chunk);
			}
		}
	}
}
