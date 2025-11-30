namespace EntitiesDb;

/// <summary>
/// Represents an Archetype paired with ids for bulk operations
/// </summary>
public readonly struct BulkCreate<T0>
{
	public readonly Archetype Archetype;
	public readonly Offsets<T0> Offsets;

	internal BulkCreate(Archetype archetype, in Offsets<T0> offsets)
	{
		Archetype = archetype;
		Offsets = offsets;
	}
}
