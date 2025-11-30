using System;

namespace EntitiesDb;

public struct RangeEnumerator
{
	private readonly int _slices;
	private readonly int _sliceSize;
	private readonly int _remainder;
	private int _index = -1;

	public RangeEnumerator(int size, int slices)
	{
		_slices = Math.Min(size, slices);
		_sliceSize = size / _slices;
		_remainder = size % _slices;
	}

	public bool MoveNext()
	{
		return unchecked(++_index) < _slices;
	}

	public void Reset()
	{
		_index = -1;
	}

	/// <summary>
	/// Partitions evenly, spreading remainders across the first indices
	/// <br/>
	/// e.g size=24, slices=5, sliceSize=4
	/// <br/>
	/// 5, 5, 5, 5, 4
	/// </summary>
	public (int, int) Current
	{
		get => (_index * _sliceSize + Math.Min(_index, _remainder), _sliceSize + (_index < _remainder ? 1 : 0));
	}
}
