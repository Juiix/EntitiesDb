namespace EntitiesDb;

public readonly record struct EntityReference(Archetype Archetype, EntitySlot Slot, int Version);

