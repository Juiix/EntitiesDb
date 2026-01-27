
namespace EntitiesDb;

public partial struct Chunk
{
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1>(int index, in T0? t0Component = default, in T1? t1Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
        Write<T7>(index) = t7Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
        Write<T7>(index) = t7Component;
        Write<T8>(index) = t8Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
        Write<T7>(index) = t7Component;
        Write<T8>(index) = t8Component;
        Write<T9>(index) = t9Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
        Write<T7>(index) = t7Component;
        Write<T8>(index) = t8Component;
        Write<T9>(index) = t9Component;
        Write<T10>(index) = t10Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
        Write<T7>(index) = t7Component;
        Write<T8>(index) = t8Component;
        Write<T9>(index) = t9Component;
        Write<T10>(index) = t10Component;
        Write<T11>(index) = t11Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
        Write<T7>(index) = t7Component;
        Write<T8>(index) = t8Component;
        Write<T9>(index) = t9Component;
        Write<T10>(index) = t10Component;
        Write<T11>(index) = t11Component;
        Write<T12>(index) = t12Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
        Write<T7>(index) = t7Component;
        Write<T8>(index) = t8Component;
        Write<T9>(index) = t9Component;
        Write<T10>(index) = t10Component;
        Write<T11>(index) = t11Component;
        Write<T12>(index) = t12Component;
        Write<T13>(index) = t13Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
        Write<T7>(index) = t7Component;
        Write<T8>(index) = t8Component;
        Write<T9>(index) = t9Component;
        Write<T10>(index) = t10Component;
        Write<T11>(index) = t11Component;
        Write<T12>(index) = t12Component;
        Write<T13>(index) = t13Component;
        Write<T14>(index) = t14Component;
	}
	/// <inheritdoc cref="Set{T0}(int, in T0)"/>
	[ChunkChange]
	public readonly void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(int index, in T0? t0Component = default, in T1? t1Component = default, in T2? t2Component = default, in T3? t3Component = default, in T4? t4Component = default, in T5? t5Component = default, in T6? t6Component = default, in T7? t7Component = default, in T8? t8Component = default, in T9? t9Component = default, in T10? t10Component = default, in T11? t11Component = default, in T12? t12Component = default, in T13? t13Component = default, in T14? t14Component = default, in T15? t15Component = default)
	{
		Write<T0>(index) = t0Component;
        Write<T1>(index) = t1Component;
        Write<T2>(index) = t2Component;
        Write<T3>(index) = t3Component;
        Write<T4>(index) = t4Component;
        Write<T5>(index) = t5Component;
        Write<T6>(index) = t6Component;
        Write<T7>(index) = t7Component;
        Write<T8>(index) = t8Component;
        Write<T9>(index) = t9Component;
        Write<T10>(index) = t10Component;
        Write<T11>(index) = t11Component;
        Write<T12>(index) = t12Component;
        Write<T13>(index) = t13Component;
        Write<T14>(index) = t14Component;
        Write<T15>(index) = t15Component;
	}
}