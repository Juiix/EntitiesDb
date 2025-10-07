using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

internal sealed class EntityMap(int maxEntities)
{
	private const int EntityIdBlockLength = 1024;
	private const int BlockMask = EntityIdBlockLength - 1;
	private const int IndexShift = 5;

	private readonly int _maxEntities = maxEntities;
	private readonly List<EntityReference[]> _blocks = [];
	private int _count = 0;

	/// <summary>
	/// Adds a new entityId
	/// </summary>
	/// <param name="entityId">The added id</param>
	/// <returns>The new reference</returns>
	/// <exception cref="OutOfMemoryException"></exception>
	public ref EntityReference Add(out int entityId)
	{
		if (_count >= _maxEntities)
			throw ThrowHelper.MaxEntitiesReached(_maxEntities);

		entityId = _count++;
		var block = entityId >> IndexShift;
		if (block >= _blocks.Count)
		{
			_blocks.Add(new EntityReference[EntityIdBlockLength]);
		}

		return ref GetReference(entityId);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref EntityReference GetReference(int entityId)
	{
		var block = entityId >> IndexShift;
		var i = entityId & BlockMask;
		return ref _blocks[(int)block][i];
	}

	public void Move(int entityId, in EntitySlot slot)
	{
		ref var entityReference = ref GetReference(entityId);
		entityReference = new EntityReference(entityReference.Archetype, slot, entityReference.Version);
	}

	public void Remove(int entityId)
	{
		GetReference(entityId) = default;
	}

	public ref EntityReference TryGetReference(int entityId, out bool found)
	{
		if (entityId >= _count)
		{
			found = false;
			return ref Unsafe.NullRef<EntityReference>();
		}

		ref var entityReference = ref GetReference(entityId);
		found = entityReference.Archetype != null;
		return ref entityReference;
	}
}
