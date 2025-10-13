namespace EntitiesDb;

public interface IChunkJob
{
	void Enter(Archetype archetype);
	void ForEach(in Chunk chunk);
}
