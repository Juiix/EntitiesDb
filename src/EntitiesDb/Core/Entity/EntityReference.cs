using System;

namespace EntitiesDb;

internal struct EntityReference(Archetype archetype, EntitySlot slot, int version)
{
    public readonly Archetype Archetype = archetype;
    public EntitySlot Slot = slot; // mutable: a swap-back rewrites only the slot
    public readonly int Version = version;
}