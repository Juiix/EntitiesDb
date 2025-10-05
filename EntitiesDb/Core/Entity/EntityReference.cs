namespace EntitiesDb;

internal readonly struct EntityReference(Archetype archetype, EntitySlot slot, int version)
{
    public readonly Archetype Archetype = archetype;
    public readonly EntitySlot Slot = slot;
    public readonly int Version = version;
}

