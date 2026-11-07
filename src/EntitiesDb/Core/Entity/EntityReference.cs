using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// Where an entity lives. Holds no object references (16 bytes), so the entity map can sit in native
/// memory: growing it allocates nothing on the GC heap and writing an entry needs no GC write barrier.
/// </summary>
internal struct EntityReference(int archetypeIndex, EntitySlot slot, int version)
{
	/// <summary>
	/// <see cref="Archetype.Index"/> of the entity's archetype; 0 when the id holds no entity
	/// </summary>
	public int ArchetypeIndex = archetypeIndex;

	/// <summary>
	/// The entity's row; for a free id, <see cref="NextFree"/> lives here instead
	/// </summary>
	public EntitySlot Slot = slot; // mutable: a swap-back rewrites only the slot

	/// <summary>
	/// The live entity's version; for a free id, the version its next entity gets
	/// </summary>
	public int Version = version;

	/// <summary>
	/// Free ids only: the next free id in recycling order, -1 at the end
	/// </summary>
	public int NextFree
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		readonly get => Slot.Index;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => Slot = new EntitySlot(value, 0);
	}
}
