namespace EntitiesDb;

public interface IJobCoordinator<T>
{
	T Create(int threadIndex);
	void Return(int threadIndex, ref T result);
}
