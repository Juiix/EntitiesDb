namespace EntitiesDb;

public interface IForEach
{
	void ForEach();
}
public interface IForEachEntity
{
	void ForEach(Entity entity);
}
public interface IForEachChunk
{
	void ForEach(int length);
}
public interface IForEachChunkEntity
{
	void ForEach(int length, ReadOnlyHandle<Entity> entities);
}