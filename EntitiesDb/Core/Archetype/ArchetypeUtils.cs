using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

internal unsafe static class ArchetypeUtils
{
	/// <summary>
	/// Builds a <see cref="ComponentType"/> array from a given <see cref="Signature"/>
	/// </summary>
	/// <remarks>
	/// Types are laid with a (unmanaged | managed) split, each group ordered by ascending id
	/// </remarks>
	/// <param name="registry">A component registery to get component types from</param>
	/// <param name="signature">The bitset signature</param>
	/// <param name="unmanagedCount">The output of how many unmanaged types there are (Use as the unmanaged/managed boundary).</param>
	/// <returns>The built component type array</returns>
	public static ComponentType[] BuildComponentTypes(ComponentRegistry registry, in Signature signature, out int unmanagedCount)
	{
		var componentTypes = new ComponentType[signature.PopCount()];
		int unmanagedIndex = 0;
		int managedIndex = componentTypes.Length - 1;
		int nextId = 0;
		while (signature.TryGetNextSetBit(nextId, out var id))
		{
			ref readonly var componentType = ref registry.GetComponentType(id);
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

		// reverse managed components to maintain component id linear order
		componentTypes.AsSpan(unmanagedIndex).Reverse();

		unmanagedCount = unmanagedIndex;
		return componentTypes;
	}

	/// <summary>
	/// Builds an id -> offset lookup array, sized to the max id in the component array
	/// </summary>
	/// <param name="componentTypes">The component types</param>
	/// <param name="unmanagedCount">The unmanaged component count</param>
	/// <param name="chunkCapacity">The chunk entity capacity</param>
	/// <returns>An id -> offset lookup array</returns>
	public static short[] BuildIdOffsetLookup(ReadOnlySpan<ComponentType> componentTypes, int unmanagedCount, int chunkCapacity)
	{
		if (componentTypes.Length == 0)
			return [];

		var idToOffsets = new short[ComponentRegistry.MaxComponents];// CreateTightIdArray<short>(componentTypes, unmanagedCount);
		Array.Fill(idToOffsets, (short)-1);

		// assign unmanaged offsets
		var unmanagedEntitySize = sizeof(Entity);
		foreach (ref readonly var componentType in componentTypes.Slice(0, unmanagedCount))
		{
			idToOffsets[componentType.Id] = (short)(componentType.IsZeroSize ? -1 : unmanagedEntitySize * chunkCapacity);
			unmanagedEntitySize += componentType.Stride;
		}

		// assign managed offsets
		int managedIndex = 0;
		foreach (ref readonly var componentType in componentTypes.Slice(unmanagedCount))
		{
			idToOffsets[componentType.Id] = (short)managedIndex++;
		}

		return idToOffsets;
    }

    /// <summary>
    /// Builds an id -> index lookup array, sized to the max id in the component array
    /// </summary>
    /// <param name="componentTypes">The component types</param>
    /// <returns>An id -> offset lookup array</returns>
    public static int[] BuildIdIndexLookup(ReadOnlySpan<ComponentType> componentTypes, int unmanagedCount)
    {
        if (componentTypes.Length == 0)
            return [];

        var idToIndices = CreateTightIdArray<int>(componentTypes, unmanagedCount);

		int index = 0;
        foreach (ref readonly var componentType in componentTypes)
        {
            idToIndices[componentType.Id] = index++;
        }

        return idToIndices;
    }

    public static int[] BuildChangeVersions(ReadOnlySpan<ComponentType> componentTypes, int[] globalChangeVersions, int unmanagedCount)
	{
		var changeVersions = CreateTightIdArray<int>(componentTypes, unmanagedCount);
		globalChangeVersions.AsSpan(0, changeVersions.Length).CopyTo(changeVersions);
		return changeVersions;
	}

	/// <summary>
	/// Calculates the chunk entity capacity given a span of types and base chunk byte size
	/// </summary>
	/// <param name="componentTypes">The component types</param>
	/// <param name="chunkSize">The desired chunk byte size</param>
	/// <returns></returns>
	public static int CalculateChunkCapacity(ReadOnlySpan<ComponentType> componentTypes, int chunkSize)
	{
		// construct unmanaged offsets & calculate chunk capacity
		var entitySize = sizeof(Entity);
		foreach (ref readonly var componentType in componentTypes)
		{
			entitySize += componentType.ByteSize;
		}

		var chunkCapacity = chunkSize / entitySize;
		return Math.Max(1, chunkCapacity);
	}

	/// <summary>
	/// Calculates the unmanaged byte size of a span of component types
	/// </summary>
	/// <param name="unmanagedComponentTypes"></param>
	/// <returns></returns>
	public static int CalculateUnmanagedSize(ReadOnlySpan<ComponentType> unmanagedComponentTypes)
	{
		// construct unmanaged offsets & calculate chunk capacity
		var entitySize = sizeof(Entity);
		foreach (ref readonly var componentType in unmanagedComponentTypes)
		{
			entitySize += componentType.ByteSize;
		}
		return entitySize;
	}

	/// <summary>
	/// Compiles a array of <see cref="ArrayFactory"/> for each managed component type
	/// </summary>
	/// <param name="managedComponentTypes">Managed component types</param>
	/// <param name="componentRegistry">The component registry</param>
	/// <returns>An array of <see cref="ArrayFactory"/> for each managed type</returns>
	public static ArrayFactory[] CompileArrayFactories(ReadOnlySpan<ComponentType> managedComponentTypes, ComponentRegistry componentRegistry)
	{
		if (managedComponentTypes.Length == 0)
			return [];

		var factories = new ArrayFactory[managedComponentTypes.Length];
		int index = 0;
		foreach (ref readonly var type in managedComponentTypes)
		{
			factories[index++] = componentRegistry.GetArrayFactory(type.Id);
		}
		return factories;
	}

	/// <summary>
	/// Creates component arrays of length <paramref name="entityCount"/> from a given array of factories
	/// </summary>
	/// <param name="factories">Array of factories</param>
	/// <param name="entityCount">The amount of components to create</param>
	/// <returns>An array of component arrays</returns>
	public static Array[] CreateManagedComponentArrays(ArrayFactory[] factories, int entityCount)
	{
		var arrays = new Array[factories.Length];
		int index = 0;
		foreach (ref var type in factories.AsSpan())
		{
			var i = index++;
			arrays[i] = factories[i](entityCount);
		}
		return arrays;
	}

	/// <summary>
	/// Creates an array that is +1 the length of the maximum component id in the give span
	/// </summary>
	/// <typeparam name="T">The type of array to create</typeparam>
	/// <param name="types">The component types</param>
	/// <param name="unmanagedCount">The unmananged count boundary</param>
	/// <returns>Newly created array</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static T[] CreateTightIdArray<T>(ReadOnlySpan<ComponentType> types, int unmanagedCount)
	{
		var maxId = GetMaxId(types, unmanagedCount);
		return new T[maxId + 1];
	}

	/// <summary>
	/// Returns the maximum id in a given list of component types
	/// </summary>
	/// <param name="types">The component types</param>
	/// <param name="unmanagedCount">The unmananged count boundary</param>
	/// <returns>Maximum id in <paramref name="types"/></returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int GetMaxId(ReadOnlySpan<ComponentType> types, int unmanagedCount)
	{
		// component types are ordered by id within (unamanged | managed) regions
		// we only need to check the last of each
		int maxId = Math.Max(types[Math.Max(unmanagedCount - 1, 0)].Id, types[types.Length - 1].Id);
		return maxId;
	}
}
