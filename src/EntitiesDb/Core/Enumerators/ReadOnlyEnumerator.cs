using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EntitiesDb;

/// <summary>
/// A backwards enumerator over a range of elements
/// </summary>
/// <typeparam name="T">The type of element</typeparam>
public ref struct ReadOnlyEnumerator<T>
{
	private readonly int _length;
#if NETSTANDARD2_1
	private Ref<T> _ref;
#else
	private ref T _ref;
#endif
	private int _index;

	public ReadOnlyEnumerator(Span<T> span)
	{
#if NETSTANDARD2_1
		_ref = new Ref<T>(ref MemoryMarshal.GetReference(span));
#else
		_ref = ref MemoryMarshal.GetReference(span);
#endif
		_index = _length = span.Length;
	}

	/// <summary>
	/// Moves to the next element
	/// </summary>
	/// <returns>If there are still elements</returns>
	public bool MoveNext()
	{
		return unchecked(--_index) >= 0;
	}

	/// <summary>
	/// Resets back to the start
	/// </summary>
	public void Reset()
	{
		_index = _length;
	}

	/// <summary>
	/// A reference to the current element
	/// </summary>
	public ref readonly T Current
	{
#if NETSTANDARD2_1
		get => ref Unsafe.Add(ref _ref.Value, _index);
#else
		get => ref Unsafe.Add(ref _ref, _index);
#endif
	}
}
