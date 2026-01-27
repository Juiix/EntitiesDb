namespace EntitiesDb;

public interface IChunkJob
{
	void ForEach(in Chunk chunk);
}