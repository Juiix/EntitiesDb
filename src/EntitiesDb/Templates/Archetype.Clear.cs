
namespace EntitiesDb;

public partial class Archetype
{
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1>(in EntitySlot slot, in Ids<T0, T1> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2>(in EntitySlot slot, in Ids<T0, T1, T2> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3>(in EntitySlot slot, in Ids<T0, T1, T2, T3> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
        if (ComponentMeta<T4>.IsBuffered) chunk.ClearBuffer<T4>(slot.Index, offsets.T4);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
        if (ComponentMeta<T4>.IsBuffered) chunk.ClearBuffer<T4>(slot.Index, offsets.T4);
        if (ComponentMeta<T5>.IsBuffered) chunk.ClearBuffer<T5>(slot.Index, offsets.T5);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
        if (ComponentMeta<T4>.IsBuffered) chunk.ClearBuffer<T4>(slot.Index, offsets.T4);
        if (ComponentMeta<T5>.IsBuffered) chunk.ClearBuffer<T5>(slot.Index, offsets.T5);
        if (ComponentMeta<T6>.IsBuffered) chunk.ClearBuffer<T6>(slot.Index, offsets.T6);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
        if (ComponentMeta<T4>.IsBuffered) chunk.ClearBuffer<T4>(slot.Index, offsets.T4);
        if (ComponentMeta<T5>.IsBuffered) chunk.ClearBuffer<T5>(slot.Index, offsets.T5);
        if (ComponentMeta<T6>.IsBuffered) chunk.ClearBuffer<T6>(slot.Index, offsets.T6);
        if (ComponentMeta<T7>.IsBuffered) chunk.ClearBuffer<T7>(slot.Index, offsets.T7);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
        if (ComponentMeta<T4>.IsBuffered) chunk.ClearBuffer<T4>(slot.Index, offsets.T4);
        if (ComponentMeta<T5>.IsBuffered) chunk.ClearBuffer<T5>(slot.Index, offsets.T5);
        if (ComponentMeta<T6>.IsBuffered) chunk.ClearBuffer<T6>(slot.Index, offsets.T6);
        if (ComponentMeta<T7>.IsBuffered) chunk.ClearBuffer<T7>(slot.Index, offsets.T7);
        if (ComponentMeta<T8>.IsBuffered) chunk.ClearBuffer<T8>(slot.Index, offsets.T8);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
        if (ComponentMeta<T4>.IsBuffered) chunk.ClearBuffer<T4>(slot.Index, offsets.T4);
        if (ComponentMeta<T5>.IsBuffered) chunk.ClearBuffer<T5>(slot.Index, offsets.T5);
        if (ComponentMeta<T6>.IsBuffered) chunk.ClearBuffer<T6>(slot.Index, offsets.T6);
        if (ComponentMeta<T7>.IsBuffered) chunk.ClearBuffer<T7>(slot.Index, offsets.T7);
        if (ComponentMeta<T8>.IsBuffered) chunk.ClearBuffer<T8>(slot.Index, offsets.T8);
        if (ComponentMeta<T9>.IsBuffered) chunk.ClearBuffer<T9>(slot.Index, offsets.T9);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
        if (ComponentMeta<T4>.IsBuffered) chunk.ClearBuffer<T4>(slot.Index, offsets.T4);
        if (ComponentMeta<T5>.IsBuffered) chunk.ClearBuffer<T5>(slot.Index, offsets.T5);
        if (ComponentMeta<T6>.IsBuffered) chunk.ClearBuffer<T6>(slot.Index, offsets.T6);
        if (ComponentMeta<T7>.IsBuffered) chunk.ClearBuffer<T7>(slot.Index, offsets.T7);
        if (ComponentMeta<T8>.IsBuffered) chunk.ClearBuffer<T8>(slot.Index, offsets.T8);
        if (ComponentMeta<T9>.IsBuffered) chunk.ClearBuffer<T9>(slot.Index, offsets.T9);
        if (ComponentMeta<T10>.IsBuffered) chunk.ClearBuffer<T10>(slot.Index, offsets.T10);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
        if (ComponentMeta<T4>.IsBuffered) chunk.ClearBuffer<T4>(slot.Index, offsets.T4);
        if (ComponentMeta<T5>.IsBuffered) chunk.ClearBuffer<T5>(slot.Index, offsets.T5);
        if (ComponentMeta<T6>.IsBuffered) chunk.ClearBuffer<T6>(slot.Index, offsets.T6);
        if (ComponentMeta<T7>.IsBuffered) chunk.ClearBuffer<T7>(slot.Index, offsets.T7);
        if (ComponentMeta<T8>.IsBuffered) chunk.ClearBuffer<T8>(slot.Index, offsets.T8);
        if (ComponentMeta<T9>.IsBuffered) chunk.ClearBuffer<T9>(slot.Index, offsets.T9);
        if (ComponentMeta<T10>.IsBuffered) chunk.ClearBuffer<T10>(slot.Index, offsets.T10);
        if (ComponentMeta<T11>.IsBuffered) chunk.ClearBuffer<T11>(slot.Index, offsets.T11);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
        if (ComponentMeta<T4>.IsBuffered) chunk.ClearBuffer<T4>(slot.Index, offsets.T4);
        if (ComponentMeta<T5>.IsBuffered) chunk.ClearBuffer<T5>(slot.Index, offsets.T5);
        if (ComponentMeta<T6>.IsBuffered) chunk.ClearBuffer<T6>(slot.Index, offsets.T6);
        if (ComponentMeta<T7>.IsBuffered) chunk.ClearBuffer<T7>(slot.Index, offsets.T7);
        if (ComponentMeta<T8>.IsBuffered) chunk.ClearBuffer<T8>(slot.Index, offsets.T8);
        if (ComponentMeta<T9>.IsBuffered) chunk.ClearBuffer<T9>(slot.Index, offsets.T9);
        if (ComponentMeta<T10>.IsBuffered) chunk.ClearBuffer<T10>(slot.Index, offsets.T10);
        if (ComponentMeta<T11>.IsBuffered) chunk.ClearBuffer<T11>(slot.Index, offsets.T11);
        if (ComponentMeta<T12>.IsBuffered) chunk.ClearBuffer<T12>(slot.Index, offsets.T12);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
        if (ComponentMeta<T4>.IsBuffered) chunk.ClearBuffer<T4>(slot.Index, offsets.T4);
        if (ComponentMeta<T5>.IsBuffered) chunk.ClearBuffer<T5>(slot.Index, offsets.T5);
        if (ComponentMeta<T6>.IsBuffered) chunk.ClearBuffer<T6>(slot.Index, offsets.T6);
        if (ComponentMeta<T7>.IsBuffered) chunk.ClearBuffer<T7>(slot.Index, offsets.T7);
        if (ComponentMeta<T8>.IsBuffered) chunk.ClearBuffer<T8>(slot.Index, offsets.T8);
        if (ComponentMeta<T9>.IsBuffered) chunk.ClearBuffer<T9>(slot.Index, offsets.T9);
        if (ComponentMeta<T10>.IsBuffered) chunk.ClearBuffer<T10>(slot.Index, offsets.T10);
        if (ComponentMeta<T11>.IsBuffered) chunk.ClearBuffer<T11>(slot.Index, offsets.T11);
        if (ComponentMeta<T12>.IsBuffered) chunk.ClearBuffer<T12>(slot.Index, offsets.T12);
        if (ComponentMeta<T13>.IsBuffered) chunk.ClearBuffer<T13>(slot.Index, offsets.T13);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
        if (ComponentMeta<T4>.IsBuffered) chunk.ClearBuffer<T4>(slot.Index, offsets.T4);
        if (ComponentMeta<T5>.IsBuffered) chunk.ClearBuffer<T5>(slot.Index, offsets.T5);
        if (ComponentMeta<T6>.IsBuffered) chunk.ClearBuffer<T6>(slot.Index, offsets.T6);
        if (ComponentMeta<T7>.IsBuffered) chunk.ClearBuffer<T7>(slot.Index, offsets.T7);
        if (ComponentMeta<T8>.IsBuffered) chunk.ClearBuffer<T8>(slot.Index, offsets.T8);
        if (ComponentMeta<T9>.IsBuffered) chunk.ClearBuffer<T9>(slot.Index, offsets.T9);
        if (ComponentMeta<T10>.IsBuffered) chunk.ClearBuffer<T10>(slot.Index, offsets.T10);
        if (ComponentMeta<T11>.IsBuffered) chunk.ClearBuffer<T11>(slot.Index, offsets.T11);
        if (ComponentMeta<T12>.IsBuffered) chunk.ClearBuffer<T12>(slot.Index, offsets.T12);
        if (ComponentMeta<T13>.IsBuffered) chunk.ClearBuffer<T13>(slot.Index, offsets.T13);
        if (ComponentMeta<T14>.IsBuffered) chunk.ClearBuffer<T14>(slot.Index, offsets.T14);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids)
	{
		ref var chunk = ref _chunks[slot.ChunkIndex];
		var offsets = GetOffsets(in ids);
		if (ComponentMeta<T0>.IsBuffered) chunk.ClearBuffer<T0>(slot.Index, offsets.T0);
        if (ComponentMeta<T1>.IsBuffered) chunk.ClearBuffer<T1>(slot.Index, offsets.T1);
        if (ComponentMeta<T2>.IsBuffered) chunk.ClearBuffer<T2>(slot.Index, offsets.T2);
        if (ComponentMeta<T3>.IsBuffered) chunk.ClearBuffer<T3>(slot.Index, offsets.T3);
        if (ComponentMeta<T4>.IsBuffered) chunk.ClearBuffer<T4>(slot.Index, offsets.T4);
        if (ComponentMeta<T5>.IsBuffered) chunk.ClearBuffer<T5>(slot.Index, offsets.T5);
        if (ComponentMeta<T6>.IsBuffered) chunk.ClearBuffer<T6>(slot.Index, offsets.T6);
        if (ComponentMeta<T7>.IsBuffered) chunk.ClearBuffer<T7>(slot.Index, offsets.T7);
        if (ComponentMeta<T8>.IsBuffered) chunk.ClearBuffer<T8>(slot.Index, offsets.T8);
        if (ComponentMeta<T9>.IsBuffered) chunk.ClearBuffer<T9>(slot.Index, offsets.T9);
        if (ComponentMeta<T10>.IsBuffered) chunk.ClearBuffer<T10>(slot.Index, offsets.T10);
        if (ComponentMeta<T11>.IsBuffered) chunk.ClearBuffer<T11>(slot.Index, offsets.T11);
        if (ComponentMeta<T12>.IsBuffered) chunk.ClearBuffer<T12>(slot.Index, offsets.T12);
        if (ComponentMeta<T13>.IsBuffered) chunk.ClearBuffer<T13>(slot.Index, offsets.T13);
        if (ComponentMeta<T14>.IsBuffered) chunk.ClearBuffer<T14>(slot.Index, offsets.T14);
        if (ComponentMeta<T15>.IsBuffered) chunk.ClearBuffer<T15>(slot.Index, offsets.T15);
	}
}