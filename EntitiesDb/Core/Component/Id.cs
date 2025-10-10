namespace EntitiesDb;

public readonly record struct Id<T>(byte Value)
{
	public static implicit operator Id<T>(byte value) => new(value);
}