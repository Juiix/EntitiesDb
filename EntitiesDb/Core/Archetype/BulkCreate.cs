namespace EntitiesDb;

/// <summary>
/// Represents an Archetype paired with ids for bulk operations
/// </summary>
public readonly struct BulkCreate<T0>
{
	public readonly Archetype Archetype;
	public readonly ComponentIds<T0> Ids;

	internal BulkCreate(Archetype archetype, in ComponentIds<T0> ids)
	{
		Archetype = archetype;
		Ids = ids;
	}
}
