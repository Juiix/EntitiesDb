using System.Runtime.CompilerServices;
using System.Threading;

namespace EntitiesDb;

/// <summary>
/// Change-version bookkeeping shared by chunks and change filters.
/// </summary>
/// <remarks>
/// <para>
/// A database's version array holds two rows of <see cref="ComponentRegistry.MaxComponents"/> entries:
/// <c>[id]</c> is component <c>id</c>'s global change version, and <c>[ObservedOffset + id]</c> is the
/// newest version any of its change filters has consumed (by being built, by <see cref="ChangeFilter.Reset"/>,
/// or by visiting a changed chunk). Every filter's version is at most that observed version.
/// </para>
/// <para>
/// A chunk whose version is newer than the observed version is therefore already reported as changed by
/// every filter, so marking it again needs no new version, and no interlocked increment. A loop that
/// writes many entities of one chunk between two filter passes bumps the global version once.
/// </para>
/// </remarks>
internal static class ChangeVersions
{
	/// <summary>
	/// Start of the observed-version row
	/// </summary>
	public const int ObservedOffset = ComponentRegistry.MaxComponents;

	/// <summary>
	/// A zeroed version array for a new database
	/// </summary>
	public static int[] Create() => new int[2 * ComponentRegistry.MaxComponents];

	/// <summary>
	/// Marks a chunk changed for component <paramref name="id"/>
	/// </summary>
	/// <param name="localVersions">The chunk's change versions</param>
	/// <param name="versions">The database's version array (see <see cref="ChangeVersions"/>)</param>
	/// <param name="id">The component id</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Mark(int[] localVersions, int[] versions, int id)
	{
		// newer than anything a filter has consumed: every filter already sees this chunk as changed
		if (unchecked(localVersions[id] - Volatile.Read(ref versions[ObservedOffset + id])) > 0)
			return;
		localVersions[id] = Interlocked.Increment(ref versions[id]);
	}

	/// <summary>
	/// Records that a change filter for component <paramref name="id"/> consumed <paramref name="version"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Observe(int[] versions, int id, int version) =>
		InterlockedMax(ref versions[ObservedOffset + id], version);

	/// <summary>
	/// Raises <paramref name="location"/> to <paramref name="value"/> unless it is already at least as new
	/// (wrap-safe), without a write when nothing changes
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void InterlockedMax(ref int location, int value)
	{
		unchecked
		{
			int current = Volatile.Read(ref location);
			while (value - current > 0)
			{
				var seen = Interlocked.CompareExchange(ref location, value, current);
				if (seen == current) return;
				current = seen;
			}
		}
	}
}
