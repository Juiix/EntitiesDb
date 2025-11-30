namespace EntitiesDb;

public readonly struct RangePartitioner(int size, int slices)
{
	private readonly int _size = size;
	private readonly int _slices = slices;

	public RangeEnumerator GetEnumerator()
	{
		return new RangeEnumerator(_size, _slices);
	}
}
