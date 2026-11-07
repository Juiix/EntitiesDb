using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// Buffered values of one component type, indexed by the command buffer's entity index
/// </summary>
internal sealed class ComponentStore
{
	public readonly ComponentType ComponentType;

	/// <summary>
	/// The component type id
	/// </summary>
	public readonly int Id;

	/// <summary>
	/// Writes of this component mark chunks changed
	/// </summary>
	public readonly bool TrackChanges;

	private readonly ArrayFactory _arrayFactory;
	private readonly int _stride;
	private readonly bool _isUnmanaged;
	private readonly bool _isBuffer;

	/// <summary>
	/// entity index -> value index + 1 (0: no value)
	/// </summary>
	private int[] _entityMap;
	private bool[] _appendMode;

	/// <summary>
	/// Highest entity index + 1 registered since the last <see cref="Clear"/>
	/// </summary>
	private int _entityHighWater;

	/// <summary>
	/// Unmanaged values, <see cref="_stride"/> bytes each (buffers keep their header + inline elements)
	/// </summary>
	private byte[] _bytes;

	/// <summary>
	/// Managed values
	/// </summary>
	private Array _managed;

	private int _capacity;
	private int _count;

	public ComponentStore(ComponentType componentType, ArrayFactory arrayFactory, int initialCapacity)
	{
		initialCapacity = Math.Max(initialCapacity, 4);
		ComponentType = componentType;
		_arrayFactory = arrayFactory;
		Id = componentType.Id;
		_stride = componentType.Stride;
		_isUnmanaged = componentType.IsUnmanaged;
		_isBuffer = componentType.IsBuffer;
		TrackChanges = componentType.TrackChanges;
		_capacity = initialCapacity;
		_entityMap = new int[initialCapacity];
		_appendMode = new bool[initialCapacity];
		_bytes = _isUnmanaged ? new byte[initialCapacity * _stride] : [];
		_managed = _isUnmanaged ? Array.Empty<byte>() : arrayFactory.Invoke(initialCapacity);
	}

	/// <summary>
	/// Drops every buffered value, releasing heap blocks held by buffered buffers
	/// </summary>
	public unsafe void Clear()
	{
		if (_isBuffer)
		{
			// values written to a chunk were reset when their heap block changed owner
			fixed (byte* bytes = _bytes)
			{
				for (int i = 0; i < _count; i++)
					DynamicBuffer.Clear(bytes + i * _stride);
			}
		}
		else if (!_isUnmanaged)
		{
			Array.Clear(_managed, 0, _count);
		}

		Array.Clear(_entityMap, 0, _entityHighWater);
		Array.Clear(_appendMode, 0, _entityHighWater);
		_entityHighWater = 0;
		_count = 0;
	}

	/// <summary>
	/// Drops the value buffered for an entity (a later remove cancelled it)
	/// </summary>
	public unsafe void ClearEntityIndex(int entityIndex)
	{
		if ((uint)entityIndex >= (uint)_entityMap.Length) return;
		ref var slot = ref _entityMap[entityIndex];
		if (slot <= 0) return;

		var index = slot - 1;
		if (_isBuffer)
		{
			fixed (byte* src = &_bytes[index * _stride])
				DynamicBuffer.Clear(src);
		}
		else if (!_isUnmanaged)
		{
			Array.Clear(_managed, index, 1);
		}
		slot = 0;
		_appendMode[entityIndex] = false;
	}

	public void SetData<T>(int entityIndex, in T? component)
	{
		var index = Register(entityIndex, out _);
		_appendMode[entityIndex] = false;
		if (_isUnmanaged)
			Unsafe.WriteUnaligned(ref _bytes[index * _stride], component);
		else
			Unsafe.As<T?[]>(_managed)[index] = component;
	}

	public unsafe void SetData<T>(int entityIndex, ReadOnlySpan<T> components) where T : unmanaged
	{
		var index = Register(entityIndex, out var fresh);
		_appendMode[entityIndex] = false;
		fixed (byte* bufferPtr = &_bytes[index * _stride])
		{
			if (!fresh) DynamicBuffer.Clear(bufferPtr); // only clear when we are replacing a previous set buffer
			new WriteBuffer<T>(bufferPtr).Init(components);
		}
	}

	public unsafe void AppendData<T>(int entityIndex, ReadOnlySpan<T> components) where T : unmanaged
	{
		var index = Register(entityIndex, out var fresh);
		fixed (byte* bufferPtr = &_bytes[index * _stride])
		{
			var buffer = new WriteBuffer<T>(bufferPtr);
			if (fresh)
			{
				// first call for this entity — initialize the buffer
				buffer.Init(components);
			}
			else if (!_appendMode[entityIndex])
			{
				// was previously Set mode — clear and re-init with append data
				DynamicBuffer.Clear(bufferPtr);
				buffer.Init(components);
			}
			else
			{
				// already in append mode — accumulate
				buffer.AddRange(components);
			}
		}
		_appendMode[entityIndex] = true;
	}

	/// <summary>
	/// Writes the value buffered for <paramref name="entityIndex"/> into a chunk row and forgets it.
	/// Marking the chunk changed is left to the caller.
	/// </summary>
	/// <param name="entityIndex">The command buffer entity index</param>
	/// <param name="chunk">The chunk holding the target row</param>
	/// <param name="offset">The component's offset in the target archetype</param>
	/// <param name="row">The target row</param>
	/// <param name="freshRow">The row was just created: its bytes are garbage, there is no buffer to append to or release</param>
	/// <returns>If a value was buffered for the entity (and written)</returns>
	public unsafe bool WriteTo(int entityIndex, ref Chunk chunk, int offset, int row, bool freshRow)
	{
		if ((uint)entityIndex >= (uint)_entityMap.Length) return false;
		ref var slot = ref _entityMap[entityIndex];
		if (slot <= 0) return false;
		var index = slot - 1;
		slot = 0;

		if (!_isUnmanaged)
		{
			Array.Copy(_managed, index, chunk.ManagedComponents[offset], row, 1);
			Array.Clear(_managed, index, 1);
			return true;
		}

		var dst = (byte*)chunk.UnmanagedComponents + offset + row * _stride;
		fixed (byte* src = &_bytes[index * _stride])
		{
			if (!_isBuffer)
			{
				ChunkMemory.Copy(dst, src, _stride);
				return true;
			}

			if (_appendMode[entityIndex] && !freshRow)
			{
				// append mode: add source elements to the existing buffer, then release the source
				DynamicBuffer.Append(dst, src, ComponentType.ElementSize, ComponentType.InternalCapacity);
				DynamicBuffer.Clear(src);
			}
			else
			{
				// set mode: replace the buffer; the chunk row takes over the source's heap block
				if (!freshRow) DynamicBuffer.Clear(dst);
				ChunkMemory.Copy(dst, src, _stride);
				DynamicBuffer.Init(src, ComponentType.InternalCapacity);
			}
			_appendMode[entityIndex] = false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private int Register(int entityIndex, out bool fresh)
	{
		if ((uint)entityIndex >= (uint)_entityMap.Length)
			GrowEntityMap(entityIndex + 1);
		if (entityIndex >= _entityHighWater)
			_entityHighWater = entityIndex + 1;

		ref var slot = ref _entityMap[entityIndex];
		if (slot > 0)
		{
			fresh = false;
			return slot - 1;
		}

		fresh = true;
		var index = _count++;
		if (index >= _capacity)
			GrowValues(index + 1);
		slot = index + 1;
		return index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GrowValues(int capacity)
	{
		var newCapacity = _capacity;
		while (newCapacity < capacity) newCapacity *= 2;
		_capacity = newCapacity;

		if (_isUnmanaged)
		{
			var newBytes = new byte[_stride * newCapacity];
			_bytes.CopyTo(newBytes, 0);
			_bytes = newBytes;
		}
		else
		{
			var newArray = _arrayFactory.Invoke(newCapacity);
			Array.Copy(_managed, newArray, _managed.Length);
			_managed = newArray;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GrowEntityMap(int capacity)
	{
		var newCapacity = _entityMap.Length;
		while (newCapacity < capacity) newCapacity *= 2;
		Array.Resize(ref _entityMap, newCapacity);
		Array.Resize(ref _appendMode, newCapacity);
	}
}
