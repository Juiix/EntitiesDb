namespace EntitiesDb;

public readonly struct Id<T>(byte value)
{
	public readonly byte Value = value;
	public static implicit operator Id<T>(byte value) => new(value);
}