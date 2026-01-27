namespace EntitiesDb;

public partial class Query
{
	public void ChunkJob<TJob>(ref TJob job)
		where TJob : IChunkJob
	{
		var changeFilter = ChangeFilter;
		var compareVersion = changeFilter?.Version ?? 0;
		foreach (var archetype in EnumerateArchetypes())
		{
			foreach (ref readonly var chunk in archetype.GetChunks(changeFilter, compareVersion))
			{
				job.ForEach(in chunk);
			}
		}
	}
}
