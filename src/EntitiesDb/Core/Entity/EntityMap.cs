using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

internal sealed class EntityMap(int maxEntities)
{
	private const int MinReferenceSize = 1024;

	private readonly int _maxEntities = maxEntities;
	private EntityReference[] _references = new EntityReference[Math.Min(MinReferenceSize, maxEntities)];
	private int[] _versions = new int[Math.Min(MinReferenceSize, maxEntities)];
	private int _count = 0;

	public int NextEntityId => _count;

	/// <summary>
	/// Adds a new entityId
	/// </summary>
	/// <param name="entityId">The added id</param>
	/// <returns>The new reference</returns>
	/// <exception cref="OutOfMemoryException"></exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref EntityReference Add(out Entity entity)
	{
		if (_count >= _maxEntities)
			throw ThrowHelper.MaxEntitiesReached(_maxEntities);
		var entityId = _count++;
		EnsureCapacity(_count);
		var version = _versions[entityId];
		entity = new Entity(entityId, version);
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

	public void Remove(int entityId, out int version)
	{
		ref var reference = ref GetReference(entityId);
		version = _versions[entityId] = reference.Version;
		reference = default;
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

		if (newLen > _versions.Length)
			Array.Resize(ref _versions, newLen);
	}

	public void TrimExcess(bool keepVersions = true)
	{
		var liveCount = _count;
		do
		{
			if (_references[liveCount - 1].Archetype != null)
				break;
		}
		while (--liveCount > 0);

		_count = liveCount;
		var newCapacity = Math.Min(_maxEntities, Math.Max(MinReferenceSize, NextPow2(Math.Max(1, liveCount))));
		if (newCapacity != _references.Length)
		{
			Array.Resize(ref _references, newCapacity);
		}
		
		if (!keepVersions &&
			newCapacity != _versions.Length)
		{
			Array.Resize(ref _versions, newCapacity);
		}
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
