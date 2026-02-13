using System.Threading;

namespace EntitiesDb;

public class ChangeFilter
{
	internal int InternalVersion;

	internal ChangeFilter(int id, int version, int[] globalChangeVersions)
	{
		Id = id;
		InternalVersion = version;
		GlobalChangeVersions = globalChangeVersions;
	}

	public int Id { get; }
	public int Version => InternalVersion;
	public int[] GlobalChangeVersions { get; }

	public void Reset()
	{
		InternalVersion = Volatile.Read(ref GlobalChangeVersions[Id]);
	}
}