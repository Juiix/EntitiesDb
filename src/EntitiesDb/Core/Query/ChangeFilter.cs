namespace EntitiesDb;

public class ChangeFilter
{
	internal int InternalVersion;

	internal ChangeFilter(int id, int version)
	{
		Id = id;
		InternalVersion = version;
	}

	public int Id { get; }
	public int Version => InternalVersion;
}

public sealed class ChangeFilter<T> : ChangeFilter
{
	internal ChangeFilter(int id, int version) : base(id, version)
	{

	}
}
