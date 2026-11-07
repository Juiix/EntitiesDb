using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// A collection of archetypes
/// </summary>
public sealed partial class ArchetypeCollection
{
	private readonly int _chunkByteSize;
	private Archetype[] _archetypes = ArrayPool<Archetype>.Shared.Rent(64);
	private int _archetypeCount = 0;
	private readonly Dictionary<Signature, Archetype> _archetypeMap = [];

	/// <summary>
	/// <see cref="Archetype.Index"/> -> archetype. Slot 0 stays empty: an entity map entry with archetype
	/// index 0 holds no entity. A trimmed archetype's slot is reused only after it is emptied here.
	/// </summary>
	private ArchetypeSlot[] _slots = new ArchetypeSlot[64];
	private int _nextIndex = 1;
	private readonly Stack<int> _freeIndices = new();
	private readonly int[] _globalChangeVersions;
	private Archetype? _lastArchetype;

	internal ArchetypeCollection(int chunkByteSize, int[] globalChangeVersions)
	{
		_chunkByteSize = chunkByteSize;
		_globalChangeVersions = globalChangeVersions;
	}

	/// <summary>
	/// A version number representing the archetype list version
	/// </summary>
	/// <remarks>
	/// When this number changes, Queries should rematch archetypes
	/// </remarks>
	internal int Version { get; private set; }

	/// <summary>
	/// The archetype at <paramref name="index"/>, an <see cref="Archetype.Index"/> read from a live entity
	/// map entry (so the slot is in range and filled)
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ref ArchetypeSlot SlotAt(int index) => ref ArrayAccess.At(_slots, index);

	internal void ChunkArrayReplaced(Archetype archetype) =>
		_slots[archetype.Index].Chunks = archetype.ChunkArray;

	public Span<Archetype> AsSpan() => _archetypes.AsSpan(0, _archetypeCount);

	/// <summary>
	/// Gets an existing <see cref="Archetype"> with a matching signature, returns null if no matching <see cref="Archetype"/> is found
	/// </summary>
	/// <param name="signature"></param>
	/// <returns></returns>
	public Archetype? GetArchetype(in Signature signature)
	{
		return _archetypeMap.TryGetValue(signature, out var archetype)
			? archetype
			: null;
	}

	/// <summary>
	/// Clears all entities in archetypes
	/// </summary>
	internal void Clear()
	{
		foreach (var archetype in _archetypes.AsSpan(0, _archetypeCount))
			archetype.Clear();
    }

	/// <summary>
	/// Gets an existing or Creates a new <see cref="Archetype"/> for the given <see cref="Signature"/>
	/// </summary>
	/// <remarks>
	/// Structural changes come in runs against the same archetype (spawning a batch, adding a component
	/// to every match), so the last archetype resolved answers before the dictionary is consulted.
	/// </remarks>
	/// <param name="signature">The signature of the <see cref="Archetype"/> to get</param>
	/// <returns>An <see cref="Archetype"/> for <paramref name="signature"/></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal Archetype GetOrCreateArchetype(in Signature signature)
	{
		var last = _lastArchetype;
		if (last is not null && last.Signature == signature)
			return last;
		return GetOrCreateArchetypeSlow(in signature);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Archetype GetOrCreateArchetypeSlow(in Signature signature)
	{
		if (!_archetypeMap.TryGetValue(signature, out var archetype))
			archetype = CreateArchetype(in signature);
		_lastArchetype = archetype;
		return archetype;
	}

	/// <summary>
	/// The archetype reached by adding component <paramref name="id"/> to <paramref name="source"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal Archetype GetAddArchetype(Archetype source, int id, in Signature added)
	{
		return source.GetAddEdge(id) ?? ResolveAddEdge(source, id, in added);
	}

	/// <summary>
	/// The archetype reached by removing component <paramref name="id"/> from <paramref name="source"/>
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal Archetype GetRemoveArchetype(Archetype source, int id, in Signature removed)
	{
		return source.GetRemoveEdge(id) ?? ResolveRemoveEdge(source, id, in removed);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Archetype ResolveAddEdge(Archetype source, int id, in Signature added)
	{
		var archetype = GetOrCreateArchetype(source.Signature.Or(in added));
		source.SetAddEdge(id, archetype);
		return archetype;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Archetype ResolveRemoveEdge(Archetype source, int id, in Signature removed)
	{
		var archetype = GetOrCreateArchetype(source.Signature.AndNot(in removed));
		source.SetRemoveEdge(id, archetype);
		return archetype;
	}

	private Archetype CreateArchetype(in Signature signature)
	{
		var componentTypes = ArchetypeUtils.BuildComponentTypes(in signature, out var unmanagedCount);
		var managedSpan = componentTypes.AsSpan(unmanagedCount);
		var arrayFactories = ArchetypeUtils.CompileArrayFactories(managedSpan);

		var archetype = new Archetype(signature, componentTypes, arrayFactories, unmanagedCount, _chunkByteSize, _globalChangeVersions);
		if (_archetypeCount >= _archetypes.Length)
		{
			var newArr = ArrayPool<Archetype>.Shared.Rent(_archetypes.Length * 2);
			Array.Copy(_archetypes, newArr, _archetypeCount);
			Array.Clear(_archetypes, 0, _archetypeCount);
			ArrayPool<Archetype>.Shared.Return(_archetypes);
			_archetypes = newArr;
		}
		_archetypes[_archetypeCount++] = archetype;
		_archetypeMap.Add(signature, archetype);

		var index = _freeIndices.Count > 0 ? _freeIndices.Pop() : _nextIndex++;
		if (index >= _slots.Length)
			Array.Resize(ref _slots, _slots.Length * 2);
		archetype.Attach(this, index);
		_slots[index] = new ArchetypeSlot(archetype);
		Version++;
		return archetype;
	}

	/// <summary>
	/// Trims excess empty chunks and archetypes
	/// </summary>
	internal void TrimExcess()
	{
		var removedAny = false;
		for (int i = _archetypeCount - 1; i >= 0; i--)
		{
			var archetype = _archetypes[i];
			if (archetype.EntityCount == 0)
			{
				archetype.Dispose();
				if (i < --_archetypeCount)
				{
					_archetypes[i] = _archetypes[_archetypeCount];
				}
				_archetypes[_archetypeCount] = null!;
				_archetypeMap.Remove(archetype.Signature);
				_slots[archetype.Index] = default; // empty: no entity map entry names it
				_freeIndices.Push(archetype.Index);
				archetype.Detach();
				removedAny = true;
				continue;
			}

			archetype.TrimExcess();
		}

		if (removedAny)
		{
			// cached lookups may point at a dropped archetype
			_lastArchetype = null;
			foreach (var archetype in _archetypes.AsSpan(0, _archetypeCount))
				archetype.ClearEdges();
		}
	}

	/// <summary>
	/// Disposes Archetype resources
	/// </summary>
	internal void Dispose()
	{
		foreach (var archetype in _archetypes.AsSpan(0, _archetypeCount))
		{
			archetype.Dispose();
		}
		Array.Clear(_archetypes, 0, _archetypeCount);
		_archetypeCount = 0;
		_lastArchetype = null;
		foreach (var archetype in _archetypes.AsSpan(0, _archetypeCount))
			archetype.Detach();
		Array.Clear(_slots, 0, _slots.Length);
		_nextIndex = 1;
		_freeIndices.Clear();
	}
}
