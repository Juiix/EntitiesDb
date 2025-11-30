using System;
using System.Buffers;
using System.Collections.Generic;

namespace EntitiesDb;

/// <summary>
/// A collection of archetypes
/// </summary>
public sealed partial class ArchetypeCollection
{
	private readonly ComponentRegistry _componentRegistry;
	private readonly int _chunkByteSize;
	private Archetype[] _archetypes = ArrayPool<Archetype>.Shared.Rent(64);
	private int _archetypeCount = 0;
	private readonly Dictionary<Signature, Archetype> _archetypeMap = [];
	private readonly int[] _globalChangeVersions;

	internal ArchetypeCollection(ComponentRegistry componentRegistry, int chunkByteSize, int[] globalChangeVersions)
	{
		_componentRegistry = componentRegistry;
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
	/// Gets an existing or Creates a new <see cref="Archetype"/> for the given <see cref="Signature"/>
	/// </summary>
	/// <param name="signature">The signature of the <see cref="Archetype"/> to get</param>
	/// <returns>An <see cref="Archetype"/> for <paramref name="signature"/></returns>
	internal Archetype GetOrCreateArchetype(in Signature signature)
	{
		if (_archetypeMap.TryGetValue(signature, out var archetype))
			return archetype;

		var componentTypes = ArchetypeUtils.BuildComponentTypes(_componentRegistry, in signature, out var unmanagedCount);
		var managedSpan = componentTypes.AsSpan(unmanagedCount);
		var arrayFactories = ArchetypeUtils.CompileArrayFactories(managedSpan, _componentRegistry);

		archetype = new Archetype(signature, componentTypes, arrayFactories, unmanagedCount, _chunkByteSize, _globalChangeVersions);
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
		Version++;
		return archetype;
	}

	/// <summary>
	/// Trims excess empty chunks and archetypes
	/// </summary>
	internal void TrimExcess()
	{
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
				continue;
			}

			archetype.TrimExcess();
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
	}
}
