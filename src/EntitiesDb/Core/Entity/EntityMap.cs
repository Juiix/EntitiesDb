using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// Entity id -> <see cref="EntityReference"/>, in one native block indexed by id.
/// </summary>
/// <remarks>
/// <para>
/// Entries hold no object references, so the block lives outside the GC heap: growing it never
/// triggers a collection, the GC never scans it, and writing an entry costs no write barrier.
/// </para>
/// <para>
/// Ids are handed out densely. A destroyed id joins a FIFO free list threaded through the free entries
/// and keeps its next version in its entry, so recycling allocates nothing either.
/// </para>
/// <para>
/// Growing copies the block. The replaced block is freed one resize later (or at Clear, TrimExcess or
/// Dispose), so a ref taken just before a growth still points at readable memory rather than freed
/// memory; writes through such a ref are lost, as they were with the managed array this replaced.
/// </para>
/// </remarks>
internal sealed unsafe class EntityMap
{
	private const int MinCapacity = 1024;

	private readonly int _maxEntities;
	private EntityReference* _entries;
	private int _capacity;

	/// <summary>
	/// Ids <c>[0, _count)</c> have been handed out: each is live or on the free list
	/// </summary>
	private int _count;

	/// <summary>
	/// The block the last resize replaced
	/// </summary>
	private EntityReference* _retired;
	private int _retiredCapacity;

	private int _freeHead = -1;
	private int _freeTail = -1;
	private int _freeCount;

	/// <summary>
	/// Versions of ids <c>[_capacity, _capacity + length)</c>, kept by <see cref="TrimExcess"/> and written back
	/// when the block grows over them again
	/// </summary>
	private int[]? _spilledVersions;

	/// <summary>
	/// What <see cref="Find"/> returns for an id out of range: no archetype. Never written.
	/// </summary>
	private EntityReference _null;

	public EntityMap(int maxEntities)
	{
		_maxEntities = maxEntities;
		_capacity = Math.Max(1, Math.Min(MinCapacity, maxEntities));
		_entries = AllocateZeroed(_capacity);
	}

	~EntityMap() => Free();

	/// <summary>
	/// The id a new (not recycled) entity gets next
	/// </summary>
	public int NextEntityId => _count;

	/// <summary>
	/// Ids waiting to be recycled
	/// </summary>
	public int FreeCount => _freeCount;

	/// <summary>
	/// Takes the oldest free id, or a new one, for an entity the caller records in the returned entry
	/// </summary>
	/// <exception cref="EntityException">The map holds <c>maxEntities</c> ids</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref EntityReference Allocate(out Entity entity)
	{
		var id = _freeHead;
		if (id >= 0)
		{
			ref var free = ref _entries[id];
			_freeHead = free.NextFree;
			if (_freeHead < 0) _freeTail = -1;
			_freeCount--;
			entity = new Entity(id, free.Version);
			return ref free;
		}

		id = _count;
		if (id >= _capacity)
			Grow(id + 1);
		_count = id + 1;
		ref var entry = ref _entries[id];
		entity = new Entity(id, entry.Version);
		return ref entry;
	}

	/// <summary>
	/// The entry for <paramref name="entityId"/>, or an entry with no archetype when the id is out of range.
	/// A free id's entry has no archetype either. Check the archetype before writing through the result.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref EntityReference Find(int entityId)
	{
		if ((uint)entityId >= (uint)_count)
			return ref _null;
		return ref _entries[entityId];
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ref EntityReference TryGetReference(int entityId, out bool found)
	{
		ref var entry = ref Find(entityId);
		found = entry.ArchetypeIndex != 0;
		return ref entry;
	}

	/// <summary>
	/// Records a live entity's new row
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Move(int entityId, in EntitySlot slot)
	{
		_entries[entityId].Slot = slot;
	}

	/// <summary>
	/// Frees a live entity's id: its next entity gets the following version, after every id freed before it
	/// </summary>
	public void Remove(int entityId)
	{
		ref var entry = ref _entries[entityId];
		entry.ArchetypeIndex = 0;
		entry.Version = unchecked(entry.Version + 1);
		AppendFree(entityId, ref entry);
	}

	/// <summary>
	/// Forgets every id: new entities start again from id 0, version 0
	/// </summary>
	public void Clear()
	{
		Zero(_entries, _capacity);
		_count = 0;
		ResetFreeList();
		_spilledVersions = null;
		FreeRetired();
	}

	/// <summary>
	/// Makes room for ids up to <paramref name="capacity"/> without growing again
	/// </summary>
	/// <exception cref="EntityException"><paramref name="capacity"/> exceeds <c>maxEntities</c></exception>
	public void EnsureCapacity(int capacity)
	{
		if (capacity > _capacity)
			Grow(capacity);
	}

	/// <summary>
	/// Drops trailing free ids and shrinks the block to fit the rest
	/// </summary>
	/// <param name="keepVersions">Keep the versions of ids past the new end, so entities that later get
	/// those ids don't reuse versions old handles still carry</param>
	public void TrimExcess(bool keepVersions = true)
	{
		var liveCount = _count;
		while (liveCount > 0 && _entries[liveCount - 1].ArchetypeIndex == 0)
			liveCount--;
		if (liveCount < _count)
		{
			_count = liveCount;
			RebuildFreeList(); // free ids past the new end are handed out again only as new ids
		}

		var newCapacity = Math.Min(_maxEntities, Math.Max(MinCapacity, NextPow2(Math.Max(1, liveCount))));
		newCapacity = Math.Max(newCapacity, 1);
		if (newCapacity < _capacity)
		{
			int[]? spilled = null;
			if (keepVersions)
			{
				// versions past the new end: from the block, then from an earlier trim's spill
				var end = _capacity + (_spilledVersions?.Length ?? 0);
				while (end > newCapacity && VersionAt(end - 1) == 0)
					end--;
				if (end > newCapacity)
				{
					spilled = new int[end - newCapacity];
					for (int i = 0; i < spilled.Length; i++)
						spilled[i] = VersionAt(newCapacity + i);
				}
			}
			_spilledVersions = null;
			Resize(newCapacity);
			_spilledVersions = spilled;
		}
		else if (!keepVersions)
		{
			_spilledVersions = null;
		}
		FreeRetired();
	}

	internal void Dispose()
	{
		Free();
		GC.SuppressFinalize(this);
	}

	private void Free()
	{
		// Find trusts _count to keep ids inside the block: none may stay in range
		_count = 0;
		ResetFreeList();
		_spilledVersions = null;
		if (_entries != null)
		{
			ReturnBlock(_entries, _capacity);
			_entries = null;
		}
		_capacity = 0;
		FreeRetired();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Grow(int min)
	{
		if (_entries == null)
			throw new ObjectDisposedException(nameof(EntityDatabase));
		if (min > _maxEntities)
			throw ThrowHelper.MaxEntitiesReached(_maxEntities);

		var newCapacity = (int)Math.Min(_maxEntities, NextPow2Long(min));
		var oldCapacity = _capacity;
		Resize(newCapacity);

		// ids an earlier TrimExcess cut off get their versions back
		if (_spilledVersions is { } spilled)
		{
			var restored = Math.Min(spilled.Length, newCapacity - oldCapacity);
			for (int i = 0; i < restored; i++)
				_entries[oldCapacity + i].Version = spilled[i];
			_spilledVersions = restored == spilled.Length ? null : spilled.AsSpan(restored).ToArray();
		}
	}

	/// <summary>
	/// Moves the entries into a block of <paramref name="newCapacity"/> (new entries zeroed); the old block
	/// is retired, not freed
	/// </summary>
	private void Resize(int newCapacity)
	{
		var entries = AllocateBlock(newCapacity);
		var kept = Math.Min(_capacity, newCapacity);
		Buffer.MemoryCopy(_entries, entries, (long)newCapacity * sizeof(EntityReference), (long)kept * sizeof(EntityReference));
		Zero(entries + kept, newCapacity - kept);

		FreeRetired();
		_retired = _entries;
		_retiredCapacity = _capacity;
		_entries = entries;
		_capacity = newCapacity;
	}

	private int VersionAt(int id) =>
		id < _capacity ? _entries[id].Version : _spilledVersions![id - _capacity];

	private void AppendFree(int entityId, ref EntityReference entry)
	{
		entry.NextFree = -1;
		if (_freeTail >= 0)
			_entries[_freeTail].NextFree = entityId;
		else
			_freeHead = entityId;
		_freeTail = entityId;
		_freeCount++;
	}

	private void ResetFreeList()
	{
		_freeHead = -1;
		_freeTail = -1;
		_freeCount = 0;
	}

	/// <summary>
	/// Relinks the free list without the ids at and past <see cref="_count"/>, keeping its order
	/// </summary>
	private void RebuildFreeList()
	{
		var id = _freeHead;
		ResetFreeList();
		while (id >= 0)
		{
			ref var entry = ref _entries[id];
			var next = entry.NextFree;
			if (id < _count)
				AppendFree(id, ref entry);
			id = next;
		}
	}

	private void FreeRetired()
	{
		if (_retired != null)
		{
			ReturnBlock(_retired, _retiredCapacity);
			_retired = null;
		}
	}

	// blocks come from and go back to a pool shared by every database: a disposed database's map
	// is the next one's, already faulted in

	private static EntityReference* AllocateBlock(int count) =>
		(EntityReference*)NativeBlockPool.Rent((long)count * sizeof(EntityReference));

	private static void ReturnBlock(EntityReference* entries, int count) =>
		NativeBlockPool.Return((nint)entries, (long)count * sizeof(EntityReference));

	private static EntityReference* AllocateZeroed(int count)
	{
		var entries = AllocateBlock(count);
		Zero(entries, count);
		return entries;
	}

	private static void Zero(EntityReference* entries, int count)
	{
		// InitBlock takes a uint byte count: zero in steps well below 4 GB
		const int Step = 1 << 26; // entries (1 GB)
		while (count > 0)
		{
			var n = Math.Min(count, Step);
			Unsafe.InitBlockUnaligned(entries, 0, (uint)(n * sizeof(EntityReference)));
			entries += n;
			count -= n;
		}
	}

	private static int NextPow2(int v) => (int)Math.Min(int.MaxValue, NextPow2Long(v));

	private static long NextPow2Long(long v)
	{
		long p = 2;
		while (p < v) p <<= 1;
		return p;
	}
}
