using System.Runtime.CompilerServices;
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
		ChangeVersions.Observe(globalChangeVersions, id, version);
	}

	public int Id { get; }
	public int Version => InternalVersion;
	public int[] GlobalChangeVersions { get; }

	public void Reset()
	{
		var version = Volatile.Read(ref GlobalChangeVersions[Id]);
		InternalVersion = version;
		ChangeVersions.Observe(GlobalChangeVersions, Id, version);
	}

	/// <summary>
	/// Consumes a changed chunk's version: this filter's version becomes at least <paramref name="chunkVersion"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal void Observe(int chunkVersion)
	{
		ChangeVersions.InterlockedMax(ref InternalVersion, chunkVersion);
		ChangeVersions.Observe(GlobalChangeVersions, Id, chunkVersion);
	}
}
