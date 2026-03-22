using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

internal sealed class EntityMap(int maxEntities)
{
	private const int MinReferenceSize = 1024;

	private readonly int _maxEntities = maxEntities;
	private EntityReference[] _references = ArrayPool<EntityReference>.Shared.Rent(Math.Min(MinReferenceSize, maxEntities));
	private int[] _versions = ArrayPool<int>.Shared.Rent(Math.Min(MinReferenceSize, maxEntities));
	private int _count = 0;
	private EntityReference _null;

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
		return ref _references[entityId];
    }

	public void Clear()
	{
		_count = 0;
		Array.Clear(_versions, 0, _versions.Length);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref EntityReference GetReference(int entityId)
	{
		return ref _references[entityId];
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref EntityReference TryGetReference(int entityId, out bool found)
	{
		if ((uint)entityId >= (uint)_count)
		{
			found = false;
			return ref _null;
		}

		ref var entityReference = ref _references[entityId];
        found = entityReference.Archetype != null;
		return ref entityReference;
	}

	public void Move(int entityId, in EntitySlot slot)
	{
		ref var entityReference = ref _references[entityId];
        entityReference = new EntityReference(entityReference.Archetype, slot, entityReference.Version);
	}

	public void Remove(int entityId)
	{
		ref var reference = ref _references[entityId];
        _versions[entityId] = reference.Version + 1;
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

		var newRefs = ArrayPool<EntityReference>.Shared.Rent(newLen);
		Array.Copy(_references, newRefs, _count);
		ArrayPool<EntityReference>.Shared.Return(_references, true);
		_references = newRefs;

		if (newLen > _versions.Length)
		{
			var newVersions = ArrayPool<int>.Shared.Rent(newLen);
			Array.Copy(_versions, newVersions, _versions.Length);
			ArrayPool<int>.Shared.Return(_versions);
			_versions = newVersions;
		}
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
		if (newCapacity < _references.Length)
		{
			var newRefs = ArrayPool<EntityReference>.Shared.Rent(newCapacity);
			Array.Copy(_references, newRefs, liveCount);
			ArrayPool<EntityReference>.Shared.Return(_references, true);
			_references = newRefs;
		}

		if (!keepVersions &&
			newCapacity < _versions.Length)
		{
			var newVersions = ArrayPool<int>.Shared.Rent(newCapacity);
			Array.Copy(_versions, newVersions, Math.Min(_versions.Length, newCapacity));
			ArrayPool<int>.Shared.Return(_versions);
			_versions = newVersions;
		}
	}

	internal void Dispose()
	{
		if (_references.Length > 0)
		{
			ArrayPool<EntityReference>.Shared.Return(_references, true);
			_references = [];
		}
		if (_versions.Length > 0)
		{
			ArrayPool<int>.Shared.Return(_versions);
			_versions = [];
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
