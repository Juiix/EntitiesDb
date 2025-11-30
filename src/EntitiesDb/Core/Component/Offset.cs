namespace EntitiesDb;

public readonly struct Offset<T>
{
	public readonly short Value;
	public readonly Id<T> Id;

	public Offset(short value, Id<T> id)
	{
		Value = value;
		Id = id;
	}

	public readonly bool Exists => Value >= 0;
}
