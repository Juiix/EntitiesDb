namespace EntitiesDb;

public interface IParallelAggregate<T>
{
	T Create(int threadIndex);
	void Join(int threadIndex, ref T job);
}
