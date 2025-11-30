using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// Represents an iterator which iterates over a range of indices.
/// </summary>
[SkipLocalsInit]
public readonly ref struct IndexIterator(int length)
{
	private readonly int _length = length;

	/// <summary>
	/// Gets a new <see cref="IndexEnumerator"/>
	/// </summary>
	/// <returns>A new <see cref="IndexEnumerator"/></returns>
	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public IndexEnumerator GetEnumerator()
	{
		return new IndexEnumerator(_length);
	}
}