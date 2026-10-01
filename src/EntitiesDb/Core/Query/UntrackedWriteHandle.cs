using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace EntitiesDb;

/// <summary>
/// A write handle that leaves its chunk unmarked: unlike <see cref="WriteHandle{T}"/>, taking it doesn't bump
/// the chunk's change version, and writes through it stay invisible to change filters until
/// <see cref="MarkChanged"/> is called. A job can then write a tracked component in every chunk it
/// visits and still report only the chunks it actually modified.
/// </summary>
#if NETSTANDARD2_1
public readonly ref struct UntrackedWriteHandle<T>
{
	internal readonly Ref<T> _first;
	private readonly int[]? _localVersions; // null when the component isn't [TrackChanges]
	private readonly int[] _globalVersions;
	private readonly int _id;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal UntrackedWriteHandle(ref T first, int[]? localVersions, int[] globalVersions, int id)
	{
		_first = new Ref<T>(ref first);
		_localVersions = localVersions;
		_globalVersions = globalVersions;
		_id = id;
	}

	public ref T this[int index]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => ref Unsafe.Add(ref _first.Value, index);
	}

	public Span<T> AsSpan(int length) => MemoryMarshal.CreateSpan(ref _first.Value, length);

	/// <summary>Marks the chunk changed for <typeparamref name="T"/> (nothing for a component without [TrackChanges]).</summary>
	[ChunkChange]
	public void MarkChanged()
	{
		if (_localVersions != null)
			_localVersions[_id] = Interlocked.Increment(ref _globalVersions[_id]);
	}
}
#else
public readonly ref struct UntrackedWriteHandle<T>
{
	internal readonly ref T _first;
	private readonly int[]? _localVersions; // null when the component isn't [TrackChanges]
	private readonly int[] _globalVersions;
	private readonly int _id;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal UntrackedWriteHandle(ref T first, int[]? localVersions, int[] globalVersions, int id)
	{
		_first = ref first;
		_localVersions = localVersions;
		_globalVersions = globalVersions;
		_id = id;
	}

	public ref T this[int index]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => ref Unsafe.Add(ref _first, index);
	}

	public Span<T> AsSpan(int length) => MemoryMarshal.CreateSpan(ref _first, length);

	/// <summary>Marks the chunk changed for <typeparamref name="T"/> (nothing for a component without [TrackChanges]).</summary>
	[ChunkChange]
	public void MarkChanged()
	{
		if (_localVersions != null)
			_localVersions[_id] = Interlocked.Increment(ref _globalVersions[_id]);
	}
}
#endif
