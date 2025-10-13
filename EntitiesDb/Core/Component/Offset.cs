namespace EntitiesDb;

public readonly struct Offset<T>(short value)
{
	public readonly short Value = value;
	public readonly bool Exists => Value >= 0;
}
