using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

internal sealed class EntityMap(int maxEntities)
{
	private const int MinReferenceSize = 1024;

	private readonly int _maxEntities = maxEntities;
	private EntityReference[] _references = ArrayPool<EntityReference>.Shared.Rent(Math.Min(MinReferenceSize, maxEntities));
	private int[] _versions = RentVersions(Math.Min(MinReferenceSize, maxEntities));
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

	/// <summary>
	/// The reference for <paramref name="entityId"/>, or a reference with no archetype when the id is out of
	/// range or dead. Never write through the result without checking its archetype first.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref EntityReference Find(int entityId)
	{
		if ((uint)entityId >= (uint)_count)
			return ref _null;
		return ref ArrayAccess.At(_references, entityId); // _count <= _references.Length
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref EntityReference TryGetReference(int entityId, out bool found)
	{
		if ((uint)entityId >= (uint)_count)
		{
			found = false;
			return ref _null;
		}

		ref var entityReference = ref ArrayAccess.At(_references, entityId);
        found = entityReference.Archetype != null;
		return ref entityReference;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Move(int entityId, in EntitySlot slot)
	{
		// only the slot changes; rewriting the whole reference would cost a GC write barrier
		_references[entityId].Slot = slot;
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
		Array.Copy(_references, newRefs, _references.Length);
		ArrayPool<EntityReference>.Shared.Return(_references, true);
		_references = newRefs;

		if (newLen > _versions.Length)
		{
			var newVersions = RentVersions(newLen);
			Array.Copy(_versions, newVersions, _versions.Length);
			ArrayPool<int>.Shared.Return(_versions);
			_versions = newVersions;
		}
	}

	public void TrimExcess(bool keepVersions = true)
	{
		// Drop trailing dead ids (also handles an empty map, e.g. right after Clear()).
		var liveCount = _count;
		while (liveCount > 0 && _references[liveCount - 1].Archetype == null)
			liveCount--;

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
			var newVersions = RentVersions(newCapacity);
			Array.Copy(_versions, newVersions, Math.Min(_versions.Length, newCapacity));
			ArrayPool<int>.Shared.Return(_versions);
			_versions = newVersions;
		}
	}

	internal void Dispose()
	{
		// Find skips the array bounds check on the strength of _count: no id may stay in range
		_count = 0;
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

	/// <summary>
	/// Rents a version array with every slot at 0. ArrayPool&lt;int&gt;.Shared is the whole process's: an
	/// array comes back as its last user left it (this map's own bumped versions, or anyone else's
	/// ints), and a fresh id must start at version 0.
	/// </summary>
	private static int[] RentVersions(int length)
	{
		var versions = ArrayPool<int>.Shared.Rent(length);
		Array.Clear(versions, 0, versions.Length);
		return versions;
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
