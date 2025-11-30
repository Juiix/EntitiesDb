using System.Runtime.CompilerServices;

namespace EntitiesDb;

[SkipLocalsInit]
public ref struct IndexEnumerator(int length)
{
	private int _index = length;
	private readonly int _length = length;

	/// <summary>
	/// Moves to the next index
	/// </summary>
	/// <returns>True if theres a next index, otherwise false.</returns>
	[SkipLocalsInit]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool MoveNext()
	{
		return unchecked(--_index >= 0);
	}

	/// <summary>
	/// Resets this instance.
	/// </summary>
	public void Reset()
	{
		_index = _length;
	}

	/// <summary>
	/// Returns a reference to the current index.
	/// </summary>
	public readonly int Current
	{
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => _index;
	}
}
