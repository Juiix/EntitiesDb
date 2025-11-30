
using System;

namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1>(int index, in Offsets<T0, T1> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default)
		where T1 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
		WriteBuffer(index, offsets.T1).Set(t1Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2>(int index, in Offsets<T0, T1, T2> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
		WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3>(int index, in Offsets<T0, T1, T2, T3> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
		WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in Offsets<T0, T1, T2, T3, T4> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
		WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
		WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
		WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
		WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
		WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, ReadOnlySpan<T1> t1Components = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0>();
		ComponentMeta.AssertBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
		WriteBuffer(index, offsets.T1).Set(t1Components);
        WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2>(int index, in Offsets<T0, T1, T2> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default)
		where T2 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
		WriteBuffer(index, offsets.T2).Set(t2Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3>(int index, in Offsets<T0, T1, T2, T3> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
		WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in Offsets<T0, T1, T2, T3, T4> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
		WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
		WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
		WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
		WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
		WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, ReadOnlySpan<T2> t2Components = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1>();
		ComponentMeta.AssertBuffered<T2, T3, T4, T5, T6, T7, T8, T9>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
		WriteBuffer(index, offsets.T2).Set(t2Components);
        WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3>(int index, in Offsets<T0, T1, T2, T3> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default)
		where T3 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
		WriteBuffer(index, offsets.T3).Set(t3Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in Offsets<T0, T1, T2, T3, T4> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
		WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
		WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
		WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
		WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
		WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, ReadOnlySpan<T3> t3Components = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2>();
		ComponentMeta.AssertBuffered<T3, T4, T5, T6, T7, T8, T9>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
		WriteBuffer(index, offsets.T3).Set(t3Components);
        WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in Offsets<T0, T1, T2, T3, T4> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default)
		where T4 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
		WriteBuffer(index, offsets.T4).Set(t4Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
		WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
		WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
		WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
		WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, ReadOnlySpan<T4> t4Components = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3>();
		ComponentMeta.AssertBuffered<T4, T5, T6, T7, T8, T9>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
		WriteBuffer(index, offsets.T4).Set(t4Components);
        WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default)
		where T5 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
		WriteBuffer(index, offsets.T5).Set(t5Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
		WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
		WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
		WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, ReadOnlySpan<T5> t5Components = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4>();
		ComponentMeta.AssertBuffered<T5, T6, T7, T8, T9>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
		WriteBuffer(index, offsets.T5).Set(t5Components);
        WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default)
		where T6 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
        if (!ComponentMeta<T5>.IsZeroSize) Write(index, offsets.T5) = t5Component;
        else MarkChanged(offsets.T5.Id.Value);
		WriteBuffer(index, offsets.T6).Set(t6Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
        if (!ComponentMeta<T5>.IsZeroSize) Write(index, offsets.T5) = t5Component;
        else MarkChanged(offsets.T5.Id.Value);
		WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
        if (!ComponentMeta<T5>.IsZeroSize) Write(index, offsets.T5) = t5Component;
        else MarkChanged(offsets.T5.Id.Value);
		WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, ReadOnlySpan<T6> t6Components = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5>();
		ComponentMeta.AssertBuffered<T6, T7, T8, T9>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
        if (!ComponentMeta<T5>.IsZeroSize) Write(index, offsets.T5) = t5Component;
        else MarkChanged(offsets.T5.Id.Value);
		WriteBuffer(index, offsets.T6).Set(t6Components);
        WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default)
		where T7 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
        if (!ComponentMeta<T5>.IsZeroSize) Write(index, offsets.T5) = t5Component;
        else MarkChanged(offsets.T5.Id.Value);
        if (!ComponentMeta<T6>.IsZeroSize) Write(index, offsets.T6) = t6Component;
        else MarkChanged(offsets.T6.Id.Value);
		WriteBuffer(index, offsets.T7).Set(t7Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
        if (!ComponentMeta<T5>.IsZeroSize) Write(index, offsets.T5) = t5Component;
        else MarkChanged(offsets.T5.Id.Value);
        if (!ComponentMeta<T6>.IsZeroSize) Write(index, offsets.T6) = t6Component;
        else MarkChanged(offsets.T6.Id.Value);
		WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, ReadOnlySpan<T7> t7Components = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6>();
		ComponentMeta.AssertBuffered<T7, T8, T9>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
        if (!ComponentMeta<T5>.IsZeroSize) Write(index, offsets.T5) = t5Component;
        else MarkChanged(offsets.T5.Id.Value);
        if (!ComponentMeta<T6>.IsZeroSize) Write(index, offsets.T6) = t6Component;
        else MarkChanged(offsets.T6.Id.Value);
		WriteBuffer(index, offsets.T7).Set(t7Components);
        WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default)
		where T8 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
        if (!ComponentMeta<T5>.IsZeroSize) Write(index, offsets.T5) = t5Component;
        else MarkChanged(offsets.T5.Id.Value);
        if (!ComponentMeta<T6>.IsZeroSize) Write(index, offsets.T6) = t6Component;
        else MarkChanged(offsets.T6.Id.Value);
        if (!ComponentMeta<T7>.IsZeroSize) Write(index, offsets.T7) = t7Component;
        else MarkChanged(offsets.T7.Id.Value);
		WriteBuffer(index, offsets.T8).Set(t8Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, ReadOnlySpan<T8> t8Components = default, ReadOnlySpan<T9> t9Components = default)
		where T8 : unmanaged
        where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7>();
		ComponentMeta.AssertBuffered<T8, T9>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
        if (!ComponentMeta<T5>.IsZeroSize) Write(index, offsets.T5) = t5Component;
        else MarkChanged(offsets.T5.Id.Value);
        if (!ComponentMeta<T6>.IsZeroSize) Write(index, offsets.T6) = t6Component;
        else MarkChanged(offsets.T6.Id.Value);
        if (!ComponentMeta<T7>.IsZeroSize) Write(index, offsets.T7) = t7Component;
        else MarkChanged(offsets.T7.Id.Value);
		WriteBuffer(index, offsets.T8).Set(t8Components);
        WriteBuffer(index, offsets.T9).Set(t9Components);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, ReadOnlySpan<T9> t9Components = default)
		where T9 : unmanaged
	{
		ComponentMeta.AssertNotBuffered<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
		ComponentMeta.AssertBuffered<T9>();
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
        if (!ComponentMeta<T4>.IsZeroSize) Write(index, offsets.T4) = t4Component;
        else MarkChanged(offsets.T4.Id.Value);
        if (!ComponentMeta<T5>.IsZeroSize) Write(index, offsets.T5) = t5Component;
        else MarkChanged(offsets.T5.Id.Value);
        if (!ComponentMeta<T6>.IsZeroSize) Write(index, offsets.T6) = t6Component;
        else MarkChanged(offsets.T6.Id.Value);
        if (!ComponentMeta<T7>.IsZeroSize) Write(index, offsets.T7) = t7Component;
        else MarkChanged(offsets.T7.Id.Value);
        if (!ComponentMeta<T8>.IsZeroSize) Write(index, offsets.T8) = t8Component;
        else MarkChanged(offsets.T8.Id.Value);
		WriteBuffer(index, offsets.T9).Set(t9Components);
	}
}