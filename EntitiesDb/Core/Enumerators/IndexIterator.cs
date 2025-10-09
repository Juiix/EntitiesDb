namespace EntitiesDb;

/// <summary>
/// Represents an iterator which iterates over a range of indices.
/// </summary>
public readonly ref struct IndexIterator(int length)
{
	private readonly int _length = length;

	/// <summary>
	/// Gets a new <see cref="IndexEnumerator"/>
	/// </summary>
	/// <returns>A new <see cref="IndexEnumerator"/></returns>
	public IndexEnumerator GetEnumerator()
	{
		return new IndexEnumerator(_length);
	}
}