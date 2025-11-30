using System;

namespace EntitiesDb;

public readonly ref struct ChunkRangePartitioner(Span<ChunkRange> ranges, int size, int slices)
{
	private readonly Span<ChunkRange> _ranges = ranges;
	private readonly int _size = size;
	private readonly int _slices = slices;

	public ChunkRangeEnumerator GetEnumerator()
	{
		return new ChunkRangeEnumerator(_ranges, _size, _slices);
	}
}
