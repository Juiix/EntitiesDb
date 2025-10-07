using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EntitiesDb;

/// <summary>
/// A collection of archetypes
/// </summary>
public sealed class ArchetypeCollection
{
	private readonly ComponentRegistry _componentRegistry;
	private readonly int _chunkByteSize;
	private readonly List<Archetype> _archetypes = [];
	private readonly Dictionary<Signature, Archetype> _archetypeMap = [];

	internal ArchetypeCollection(ComponentRegistry componentRegistry, int chunkByteSize)
	{
		_componentRegistry = componentRegistry;
		_chunkByteSize = chunkByteSize;
	}

	/// <summary>
	/// A version number representing the archetype list version
	/// </summary>
	/// <remarks>
	/// When this number changes, Queries should rematch archetypes
	/// </remarks>
	internal int Version { get; private set; }

	public Span<Archetype> AsSpan() => CollectionsMarshal.AsSpan(_archetypes);

	/// <summary>
	/// Gets an existing or Creates a new <see cref="Archetype"/> for the given <see cref="Signature"/>
	/// </summary>
	/// <param name="signature">The signature of the <see cref="Archetype"/> to get</param>
	/// <returns>An <see cref="Archetype"/> for <paramref name="signature"/></returns>
	internal Archetype GetOrCreateArchetype(in Signature signature)
	{
		if (_archetypeMap.TryGetValue(signature, out var archetype))
			return archetype;

		var componentTypes = new ComponentType[signature.PopCount()];
		int unmanagedIndex = 0;
		int managedIndex = componentTypes.Length - 1;
		int nextId = 0;
		while (signature.TryGetNextSetBit(nextId, out var id))
		{
			ref readonly var componentType = ref _componentRegistry.GetComponentType(id);
			if (componentType.IsUnmanaged)
			{
				componentTypes[unmanagedIndex++] = componentType;
			}
			else
			{
				componentTypes[managedIndex--] = componentType;
			}

			nextId = id + 1;
		}

		var managedSpan = componentTypes.AsSpan(unmanagedIndex, componentTypes.Length - unmanagedIndex);
		var arrayFactories = ArchetypeUtils.CompileArrayFactories(managedSpan, _componentRegistry);

		archetype = new Archetype(signature, componentTypes, arrayFactories, unmanagedIndex, _chunkByteSize);
		_archetypes.Add(archetype);
		_archetypeMap.Add(signature, archetype);
		Version++;
		return archetype;
	}
}
