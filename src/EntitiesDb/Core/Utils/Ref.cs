using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EntitiesDb;

#if NETSTANDARD2_1

/// <summary>
/// The <see langword="struct"/> strct
/// can store a reference to a value of a specified type.
/// </summary>
/// <typeparam name="T">The type of value to reference.</typeparam>
public readonly ref struct Ref<T>
{
	/// <summary>
	/// The 1-length <see cref="Span{T}"/> instance used to track the target <typeparamref name="T"/> value.
	/// </summary>
	internal readonly Span<T> Span;

	public bool IsEmpty => Span.IsEmpty;

	/// <summary>
	/// Initializes a new instance of the <see cref="Ref{T}"/> struct.
	/// </summary>
	/// <param name="value">The reference to the target <typeparamref name="T"/> value.</param>

	public Ref(ref T value)
	{
		this.Span = MemoryMarshal.CreateSpan(ref value, 1);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Ref{T}"/> struct.
	/// </summary>
	/// <param name="pointer">The pointer to the target value.</param>

	public unsafe Ref(void* pointer)
		: this(ref Unsafe.AsRef<T>(pointer))
	{
	}

	/// <summary>
	/// Gets the <typeparamref name="T"/> reference represented by the current <see cref="Ref{T}"/> instance.
	/// </summary>
	public ref T Value
	{

		get => ref MemoryMarshal.GetReference(this.Span);
	}

	/// <summary>
	/// Implicitly gets the <typeparamref name="T"/> value from a given <see cref="Ref{T}"/> instance.
	/// </summary>
	/// <param name="reference">The input <see cref="Ref{T}"/> instance.</param>

	public static implicit operator T(Ref<T> reference)
	{
		return reference.Value;
	}
}
#endif