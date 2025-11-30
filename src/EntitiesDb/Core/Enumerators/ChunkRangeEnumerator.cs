using System;

namespace EntitiesDb;

public ref struct ChunkRangeEnumerator
{
	private readonly Span<ChunkRange> _ranges;
	private readonly int _slices;
	private readonly int _sliceSize;
	private readonly int _remainder;
	private int _sliceIndex = -1;
	private int _start = 0;
	private int _end = 0;
	private int _first = 0;
	private int _last = 0;

	public ChunkRangeEnumerator(Span<ChunkRange> ranges, int size, int slices)
	{
		_ranges = ranges;
		_slices = Math.Min(size, slices);
		_sliceSize = size / _slices;
		_remainder = size % _slices;
	}

	public bool MoveNext()
	{
		unchecked
		{
			if (++_sliceIndex >= _slices)
				return false;

			var remaining = _sliceSize + (_sliceIndex < _remainder ? 1 : 0);
			var range = _ranges[_end];

			// remaining in a range
			if (_last >= range.Size)
			{
				_first = 0;
				_start = ++_end;
			}
			else
			{
				_start = _end;
				_first = _last;
				var size = Math.Min(remaining, range.Size - _last);
				remaining -= size;
				if (remaining == 0)
				{
					_last = _first + size;
					return true;
				}
				_end++;
			}

			// range center & end
			while (remaining > 0)
			{
				var offset = _start == _end ? _first : 0;
				range = _ranges[_end];
				if (remaining <= range.Size - offset)
				{
					_last = offset + remaining;
					return true;
				}

				remaining -= range.Size;
				_last = range.Size;
				_end++;
			}
			return true;
		}
	}

	public void Reset()
	{
		_sliceIndex = -1;
		_start = 0;
		_end = 0;
		_first = 0;
		_last = 0;
	}

	/// <summary>
	/// Partitions evenly, spreading remainders across the first slices
	/// <br/>
	/// e.g size=24, slices=5, sliceSize=4
	/// <br/>
	/// 5, 5, 5, 5, 4
	/// </summary>
	public (int Start, int End, int First, int Last) Current
	{
		get => (_start, _end, _first, _last);
	}
}
