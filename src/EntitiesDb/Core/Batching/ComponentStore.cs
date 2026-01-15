using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

internal sealed class ComponentStore(ComponentType componentType, ArrayFactory arrayFactory, int initialCapacity)
{
    public readonly ComponentType ComponentType = componentType;
    private readonly ArrayFactory _arrayFactory = arrayFactory;
    private int _capacity = initialCapacity;
    private int[] _entityMap = new int[initialCapacity];

    public Array Components { get; private set; } = componentType.IsUnmanaged ? new byte[initialCapacity * componentType.Stride] : arrayFactory.Invoke(initialCapacity);
    public int Count {get; private set; } = 0;

    public unsafe void Clear()
    {
        if (!ComponentType.IsUnmanaged)
        {
            Array.Clear(Components, 0, Count);
        }
        Count = 0;
    }

    public int GetComponentIndex(int entityIndex)
    {
        if (entityIndex >= _entityMap.Length)
            return -1;
        return _entityMap[entityIndex] - 1;
    }

    public unsafe void SetData<T>(int entityIndex, in T? component)
	{
        EnsureEntityCapacity(entityIndex + 1);
		var (componentIndex, _) = RegisterComponentIndex(entityIndex);
		if (ComponentType.IsUnmanaged)
        {
            var array = GetArray<byte>();
            var span = array.AsSpan();
#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type
		    ref var slot = ref Unsafe.AsRef<T>((T*)Unsafe.AsPointer(ref span[componentIndex * ComponentType.Stride]));
#pragma warning restore CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type
            slot = component;
        }
        else
        {
            var array = GetArray<T?>();
            array[componentIndex] = component;
        }
	}

    public unsafe void SetData<T>(int entityIndex, ReadOnlySpan<T> components) where T : unmanaged
	{
        EnsureEntityCapacity(entityIndex + 1);
        var (componentIndex, init) = RegisterComponentIndex(entityIndex);
		var array = GetArray<byte>();
		fixed (byte* ptr = array)
		{
            var bufferPtr = ptr + componentIndex * ComponentType.Stride;
			if (!init) DynamicBuffer.Clear(bufferPtr); // only clear when we are replacing a previous set buffer
			var buffer = new WriteBuffer<T>(bufferPtr);
			buffer.Init(components);
		}
	}

	private T[] GetArray<T>()
	{
		return (T[])Components;
	}

    private (int, bool) RegisterComponentIndex(int entityIndex)
    {
        ref var componentIndex = ref _entityMap[entityIndex];
        bool init = componentIndex <= 0;
        if (init)
        {
            componentIndex = ++Count;
            EnsureComponentCapacity(componentIndex);
		}
        return (componentIndex - 1, init);
    }

    private void EnsureComponentCapacity(int capacity)
	{
		if (capacity <= _capacity) return;
		var newCapacity = _capacity;
		while (newCapacity < capacity) newCapacity *= 2;
        _capacity = newCapacity;

        if (ComponentType.IsUnmanaged)
        {
            var array = (byte[])Components;
            var newArray = new byte[ComponentType.Stride * newCapacity];
            array.AsSpan(0, Count * ComponentType.Stride).CopyTo(newArray);
            Components = newArray;
        }
        else
        {
            var array = Components;
            var newArray = _arrayFactory.Invoke(newCapacity);
            Array.Copy(array, newArray, Count);
            Components = newArray;
        }
	}

    private void EnsureEntityCapacity(int capacity)
	{
		if (capacity <= _entityMap.Length) return;
		var newCapacity = _entityMap.Length;
		while (newCapacity < capacity) newCapacity *= 2;
        Array.Resize(ref _entityMap, newCapacity);
	}
}