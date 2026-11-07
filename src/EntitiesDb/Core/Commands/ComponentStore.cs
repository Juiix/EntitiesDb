using System;
using System.Buffers;
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

	/// <summary>
	/// Sizes to rent again after <see cref="Clear"/> handed large arrays back to the pool
	/// </summary>
	private int _entityHint;
	private int _valueHint;

	/// <summary>
	/// Arrays at least this large (the large object heap's threshold) go back to the pool at
	/// <see cref="Clear"/>: a buffer built per batch then reuses them instead of allocating them again
	/// </summary>
	private const int PooledBytes = 85_000;

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

		// pooled arrays: only the entity map must start zeroed; values and append flags are always
		// written before they are read
		_entityMap = RentZeroed(initialCapacity);
		_appendMode = ArrayPool<bool>.Shared.Rent(initialCapacity);
		if (_isUnmanaged)
		{
			_bytes = ArrayPool<byte>.Shared.Rent(initialCapacity * Math.Max(_stride, 1));
			_capacity = _bytes.Length / Math.Max(_stride, 1);
			_managed = Array.Empty<byte>();
		}
		else
		{
			_bytes = [];
			_managed = arrayFactory.Invoke(initialCapacity);
			_capacity = initialCapacity;
		}
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

		if ((long)_entityMap.Length * sizeof(int) >= PooledBytes || _bytes.Length >= PooledBytes)
			ReleaseArrays();
	}

	/// <summary>
	/// Hands the pooled arrays back (empty store); the next registration rents them at their old size
	/// </summary>
	private void ReleaseArrays()
	{
		_entityHint = Math.Max(_entityHint, _entityMap.Length);
		ArrayPool<int>.Shared.Return(_entityMap);
		ArrayPool<bool>.Shared.Return(_appendMode);
		_entityMap = [];
		_appendMode = [];
		if (_isUnmanaged)
		{
			_valueHint = Math.Max(_valueHint, _capacity);
			if (_bytes.Length != 0)
				ArrayPool<byte>.Shared.Return(_bytes);
			_bytes = [];
			_capacity = 0;
		}
	}

	private static int[] RentZeroed(int length)
	{
		var array = ArrayPool<int>.Shared.Rent(length);
		Array.Clear(array, 0, array.Length);
		return array;
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
		var newCapacity = Math.Max(4, Math.Max(_capacity, _valueHint));
		while (newCapacity < capacity) newCapacity *= 2;

		if (_isUnmanaged)
		{
			var stride = Math.Max(_stride, 1);
			var newBytes = ArrayPool<byte>.Shared.Rent(stride * newCapacity);
			// Register counts the new value before growing: copy only what the old array holds
			_bytes.AsSpan(0, Math.Min(_bytes.Length, _count * _stride)).CopyTo(newBytes);
			if (_bytes.Length != 0)
				ArrayPool<byte>.Shared.Return(_bytes);
			_bytes = newBytes;
			_capacity = newBytes.Length / stride;
		}
		else
		{
			var newArray = _arrayFactory.Invoke(newCapacity);
			Array.Copy(_managed, newArray, _managed.Length);
			_managed = newArray;
			_capacity = newCapacity;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GrowEntityMap(int capacity)
	{
		var newCapacity = Math.Max(4, Math.Max(_entityMap.Length, _entityHint));
		while (newCapacity < capacity) newCapacity *= 2;

		var entityMap = RentZeroed(newCapacity);
		_entityMap.AsSpan(0, Math.Min(_entityMap.Length, _entityHighWater)).CopyTo(entityMap);
		var appendMode = ArrayPool<bool>.Shared.Rent(entityMap.Length);
		_appendMode.AsSpan(0, Math.Min(_appendMode.Length, _entityHighWater)).CopyTo(appendMode);
		if (_entityMap.Length != 0)
		{
			ArrayPool<int>.Shared.Return(_entityMap);
			ArrayPool<bool>.Shared.Return(_appendMode);
		}
		_entityMap = entityMap;
		_appendMode = appendMode;
	}
}
