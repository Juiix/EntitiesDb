
namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0>(int index, in Offsets<T0> offsets, in T0? t0Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1>(int index, in Offsets<T0, T1> offsets, in T0? t0Component = default, in T1? t1Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2>(int index, in Offsets<T0, T1, T2> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3>(int index, in Offsets<T0, T1, T2, T3> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		if (!ComponentMeta<T0>.IsZeroSize) Write(index, offsets.T0) = t0Component;
        else MarkChanged(offsets.T0.Id.Value);
        if (!ComponentMeta<T1>.IsZeroSize) Write(index, offsets.T1) = t1Component;
        else MarkChanged(offsets.T1.Id.Value);
        if (!ComponentMeta<T2>.IsZeroSize) Write(index, offsets.T2) = t2Component;
        else MarkChanged(offsets.T2.Id.Value);
        if (!ComponentMeta<T3>.IsZeroSize) Write(index, offsets.T3) = t3Component;
        else MarkChanged(offsets.T3.Id.Value);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in Offsets<T0, T1, T2, T3, T4> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
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
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in Offsets<T0, T1, T2, T3, T4, T5> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
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
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
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
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
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
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
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
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
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
        if (!ComponentMeta<T9>.IsZeroSize) Write(index, offsets.T9) = t9Component;
        else MarkChanged(offsets.T9.Id.Value);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
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
        if (!ComponentMeta<T9>.IsZeroSize) Write(index, offsets.T9) = t9Component;
        else MarkChanged(offsets.T9.Id.Value);
        if (!ComponentMeta<T10>.IsZeroSize) Write(index, offsets.T10) = t10Component;
        else MarkChanged(offsets.T10.Id.Value);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
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
        if (!ComponentMeta<T9>.IsZeroSize) Write(index, offsets.T9) = t9Component;
        else MarkChanged(offsets.T9.Id.Value);
        if (!ComponentMeta<T10>.IsZeroSize) Write(index, offsets.T10) = t10Component;
        else MarkChanged(offsets.T10.Id.Value);
        if (!ComponentMeta<T11>.IsZeroSize) Write(index, offsets.T11) = t11Component;
        else MarkChanged(offsets.T11.Id.Value);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
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
        if (!ComponentMeta<T9>.IsZeroSize) Write(index, offsets.T9) = t9Component;
        else MarkChanged(offsets.T9.Id.Value);
        if (!ComponentMeta<T10>.IsZeroSize) Write(index, offsets.T10) = t10Component;
        else MarkChanged(offsets.T10.Id.Value);
        if (!ComponentMeta<T11>.IsZeroSize) Write(index, offsets.T11) = t11Component;
        else MarkChanged(offsets.T11.Id.Value);
        if (!ComponentMeta<T12>.IsZeroSize) Write(index, offsets.T12) = t12Component;
        else MarkChanged(offsets.T12.Id.Value);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
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
        if (!ComponentMeta<T9>.IsZeroSize) Write(index, offsets.T9) = t9Component;
        else MarkChanged(offsets.T9.Id.Value);
        if (!ComponentMeta<T10>.IsZeroSize) Write(index, offsets.T10) = t10Component;
        else MarkChanged(offsets.T10.Id.Value);
        if (!ComponentMeta<T11>.IsZeroSize) Write(index, offsets.T11) = t11Component;
        else MarkChanged(offsets.T11.Id.Value);
        if (!ComponentMeta<T12>.IsZeroSize) Write(index, offsets.T12) = t12Component;
        else MarkChanged(offsets.T12.Id.Value);
        if (!ComponentMeta<T13>.IsZeroSize) Write(index, offsets.T13) = t13Component;
        else MarkChanged(offsets.T13.Id.Value);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
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
        if (!ComponentMeta<T9>.IsZeroSize) Write(index, offsets.T9) = t9Component;
        else MarkChanged(offsets.T9.Id.Value);
        if (!ComponentMeta<T10>.IsZeroSize) Write(index, offsets.T10) = t10Component;
        else MarkChanged(offsets.T10.Id.Value);
        if (!ComponentMeta<T11>.IsZeroSize) Write(index, offsets.T11) = t11Component;
        else MarkChanged(offsets.T11.Id.Value);
        if (!ComponentMeta<T12>.IsZeroSize) Write(index, offsets.T12) = t12Component;
        else MarkChanged(offsets.T12.Id.Value);
        if (!ComponentMeta<T13>.IsZeroSize) Write(index, offsets.T13) = t13Component;
        else MarkChanged(offsets.T13.Id.Value);
        if (!ComponentMeta<T14>.IsZeroSize) Write(index, offsets.T14) = t14Component;
        else MarkChanged(offsets.T14.Id.Value);
	}
	/// <inheritdoc cref="Set{T0}(int, Offset{T0}, in T0?)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int index, in Offsets<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> offsets, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
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
        if (!ComponentMeta<T9>.IsZeroSize) Write(index, offsets.T9) = t9Component;
        else MarkChanged(offsets.T9.Id.Value);
        if (!ComponentMeta<T10>.IsZeroSize) Write(index, offsets.T10) = t10Component;
        else MarkChanged(offsets.T10.Id.Value);
        if (!ComponentMeta<T11>.IsZeroSize) Write(index, offsets.T11) = t11Component;
        else MarkChanged(offsets.T11.Id.Value);
        if (!ComponentMeta<T12>.IsZeroSize) Write(index, offsets.T12) = t12Component;
        else MarkChanged(offsets.T12.Id.Value);
        if (!ComponentMeta<T13>.IsZeroSize) Write(index, offsets.T13) = t13Component;
        else MarkChanged(offsets.T13.Id.Value);
        if (!ComponentMeta<T14>.IsZeroSize) Write(index, offsets.T14) = t14Component;
        else MarkChanged(offsets.T14.Id.Value);
        if (!ComponentMeta<T15>.IsZeroSize) Write(index, offsets.T15) = t15Component;
        else MarkChanged(offsets.T15.Id.Value);
	}
}