using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

internal sealed class EntityMap(int maxEntities)
{
	private readonly int _maxEntities = maxEntities;
	private EntityReference[] _references = new EntityReference[Math.Min(1024, maxEntities)];
	private int _count = 0;

	/// <summary>
	/// Adds a new entityId
	/// </summary>
	/// <param name="entityId">The added id</param>
	/// <returns>The new reference</returns>
	/// <exception cref="OutOfMemoryException"></exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref EntityReference Add(out int entityId)
	{
		if (_count >= _maxEntities)
			throw ThrowHelper.MaxEntitiesReached(_maxEntities);
		entityId = _count++;
		EnsureCapacity(_count);
		return ref GetReference(entityId);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref EntityReference GetReference(int entityId)
	{
		return ref _references[entityId];
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
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

	public void Move(int entityId, in EntitySlot slot)
	{
		ref var entityReference = ref GetReference(entityId);
		entityReference = new EntityReference(entityReference.Archetype, slot, entityReference.Version);
	}

	public void Remove(int entityId)
	{
		GetReference(entityId) = default;
	}

	public void EnsureCapacity(int capacity)
	{
		if (capacity <= _references.Length)
			return;

		if (capacity > _maxEntities)
			throw ThrowHelper.MaxEntitiesReached(_maxEntities);

		// Grow to next power of two, but cap at _maxEntities
		int newLen = NextPow2(capacity);
		if (newLen > _maxEntities) newLen = _maxEntities;

		Array.Resize(ref _references, newLen);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int NextPow2(int v)
	{
		// handles v == 1 => 1, v == 0 shouldn't be passed here
		v--;
		v |= v >> 1;
		v |= v >> 2;
		v |= v >> 4;
		v |= v >> 8;
		v |= v >> 16;
		v++;
		return v < 2 ? 2 : v;
	}
}
