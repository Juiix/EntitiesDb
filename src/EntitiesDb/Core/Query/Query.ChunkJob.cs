namespace EntitiesDb;

public partial class Query
{
	public void ChunkJob<T>(ref T job) where T : IChunkJob
	{
		var changeFilter = ChangeFilter;
		var compareVersion = changeFilter?.Version ?? 0;
		foreach (var archetype in EnumerateArchetypes())
		{
			job.Enter(archetype);
			foreach (ref readonly var chunk in archetype.GetChunks(changeFilter, compareVersion))
			{
				job.ForEach(in chunk);
			}
		}
	}
}
