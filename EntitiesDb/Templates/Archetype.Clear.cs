
namespace EntitiesDb;

public partial class Archetype
{
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1>(in EntitySlot slot, in Ids<T0, T1> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2>(in EntitySlot slot, in Ids<T0, T1, T2> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3>(in EntitySlot slot, in Ids<T0, T1, T2, T3> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
        if (ComponentMeta<T12>.IsBuffered) ClearBuffer<T12>(in slot, ids.T12);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
        if (ComponentMeta<T12>.IsBuffered) ClearBuffer<T12>(in slot, ids.T12);
        if (ComponentMeta<T13>.IsBuffered) ClearBuffer<T13>(in slot, ids.T13);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
        if (ComponentMeta<T12>.IsBuffered) ClearBuffer<T12>(in slot, ids.T12);
        if (ComponentMeta<T13>.IsBuffered) ClearBuffer<T13>(in slot, ids.T13);
        if (ComponentMeta<T14>.IsBuffered) ClearBuffer<T14>(in slot, ids.T14);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
        if (ComponentMeta<T12>.IsBuffered) ClearBuffer<T12>(in slot, ids.T12);
        if (ComponentMeta<T13>.IsBuffered) ClearBuffer<T13>(in slot, ids.T13);
        if (ComponentMeta<T14>.IsBuffered) ClearBuffer<T14>(in slot, ids.T14);
        if (ComponentMeta<T15>.IsBuffered) ClearBuffer<T15>(in slot, ids.T15);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
        if (ComponentMeta<T12>.IsBuffered) ClearBuffer<T12>(in slot, ids.T12);
        if (ComponentMeta<T13>.IsBuffered) ClearBuffer<T13>(in slot, ids.T13);
        if (ComponentMeta<T14>.IsBuffered) ClearBuffer<T14>(in slot, ids.T14);
        if (ComponentMeta<T15>.IsBuffered) ClearBuffer<T15>(in slot, ids.T15);
        if (ComponentMeta<T16>.IsBuffered) ClearBuffer<T16>(in slot, ids.T16);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
        if (ComponentMeta<T12>.IsBuffered) ClearBuffer<T12>(in slot, ids.T12);
        if (ComponentMeta<T13>.IsBuffered) ClearBuffer<T13>(in slot, ids.T13);
        if (ComponentMeta<T14>.IsBuffered) ClearBuffer<T14>(in slot, ids.T14);
        if (ComponentMeta<T15>.IsBuffered) ClearBuffer<T15>(in slot, ids.T15);
        if (ComponentMeta<T16>.IsBuffered) ClearBuffer<T16>(in slot, ids.T16);
        if (ComponentMeta<T17>.IsBuffered) ClearBuffer<T17>(in slot, ids.T17);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
        if (ComponentMeta<T12>.IsBuffered) ClearBuffer<T12>(in slot, ids.T12);
        if (ComponentMeta<T13>.IsBuffered) ClearBuffer<T13>(in slot, ids.T13);
        if (ComponentMeta<T14>.IsBuffered) ClearBuffer<T14>(in slot, ids.T14);
        if (ComponentMeta<T15>.IsBuffered) ClearBuffer<T15>(in slot, ids.T15);
        if (ComponentMeta<T16>.IsBuffered) ClearBuffer<T16>(in slot, ids.T16);
        if (ComponentMeta<T17>.IsBuffered) ClearBuffer<T17>(in slot, ids.T17);
        if (ComponentMeta<T18>.IsBuffered) ClearBuffer<T18>(in slot, ids.T18);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
        if (ComponentMeta<T12>.IsBuffered) ClearBuffer<T12>(in slot, ids.T12);
        if (ComponentMeta<T13>.IsBuffered) ClearBuffer<T13>(in slot, ids.T13);
        if (ComponentMeta<T14>.IsBuffered) ClearBuffer<T14>(in slot, ids.T14);
        if (ComponentMeta<T15>.IsBuffered) ClearBuffer<T15>(in slot, ids.T15);
        if (ComponentMeta<T16>.IsBuffered) ClearBuffer<T16>(in slot, ids.T16);
        if (ComponentMeta<T17>.IsBuffered) ClearBuffer<T17>(in slot, ids.T17);
        if (ComponentMeta<T18>.IsBuffered) ClearBuffer<T18>(in slot, ids.T18);
        if (ComponentMeta<T19>.IsBuffered) ClearBuffer<T19>(in slot, ids.T19);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
        if (ComponentMeta<T12>.IsBuffered) ClearBuffer<T12>(in slot, ids.T12);
        if (ComponentMeta<T13>.IsBuffered) ClearBuffer<T13>(in slot, ids.T13);
        if (ComponentMeta<T14>.IsBuffered) ClearBuffer<T14>(in slot, ids.T14);
        if (ComponentMeta<T15>.IsBuffered) ClearBuffer<T15>(in slot, ids.T15);
        if (ComponentMeta<T16>.IsBuffered) ClearBuffer<T16>(in slot, ids.T16);
        if (ComponentMeta<T17>.IsBuffered) ClearBuffer<T17>(in slot, ids.T17);
        if (ComponentMeta<T18>.IsBuffered) ClearBuffer<T18>(in slot, ids.T18);
        if (ComponentMeta<T19>.IsBuffered) ClearBuffer<T19>(in slot, ids.T19);
        if (ComponentMeta<T20>.IsBuffered) ClearBuffer<T20>(in slot, ids.T20);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
        if (ComponentMeta<T12>.IsBuffered) ClearBuffer<T12>(in slot, ids.T12);
        if (ComponentMeta<T13>.IsBuffered) ClearBuffer<T13>(in slot, ids.T13);
        if (ComponentMeta<T14>.IsBuffered) ClearBuffer<T14>(in slot, ids.T14);
        if (ComponentMeta<T15>.IsBuffered) ClearBuffer<T15>(in slot, ids.T15);
        if (ComponentMeta<T16>.IsBuffered) ClearBuffer<T16>(in slot, ids.T16);
        if (ComponentMeta<T17>.IsBuffered) ClearBuffer<T17>(in slot, ids.T17);
        if (ComponentMeta<T18>.IsBuffered) ClearBuffer<T18>(in slot, ids.T18);
        if (ComponentMeta<T19>.IsBuffered) ClearBuffer<T19>(in slot, ids.T19);
        if (ComponentMeta<T20>.IsBuffered) ClearBuffer<T20>(in slot, ids.T20);
        if (ComponentMeta<T21>.IsBuffered) ClearBuffer<T21>(in slot, ids.T21);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
        if (ComponentMeta<T12>.IsBuffered) ClearBuffer<T12>(in slot, ids.T12);
        if (ComponentMeta<T13>.IsBuffered) ClearBuffer<T13>(in slot, ids.T13);
        if (ComponentMeta<T14>.IsBuffered) ClearBuffer<T14>(in slot, ids.T14);
        if (ComponentMeta<T15>.IsBuffered) ClearBuffer<T15>(in slot, ids.T15);
        if (ComponentMeta<T16>.IsBuffered) ClearBuffer<T16>(in slot, ids.T16);
        if (ComponentMeta<T17>.IsBuffered) ClearBuffer<T17>(in slot, ids.T17);
        if (ComponentMeta<T18>.IsBuffered) ClearBuffer<T18>(in slot, ids.T18);
        if (ComponentMeta<T19>.IsBuffered) ClearBuffer<T19>(in slot, ids.T19);
        if (ComponentMeta<T20>.IsBuffered) ClearBuffer<T20>(in slot, ids.T20);
        if (ComponentMeta<T21>.IsBuffered) ClearBuffer<T21>(in slot, ids.T21);
        if (ComponentMeta<T22>.IsBuffered) ClearBuffer<T22>(in slot, ids.T22);
	}
	/// <inheritdoc cref="Clear{T0}(in EntitySlot, in Ids{T0})"/>
	internal void Clear<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in EntitySlot slot, in Ids<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> ids)
	{
		if (ComponentMeta<T0>.IsBuffered) ClearBuffer<T0>(in slot, ids.T0);
        if (ComponentMeta<T1>.IsBuffered) ClearBuffer<T1>(in slot, ids.T1);
        if (ComponentMeta<T2>.IsBuffered) ClearBuffer<T2>(in slot, ids.T2);
        if (ComponentMeta<T3>.IsBuffered) ClearBuffer<T3>(in slot, ids.T3);
        if (ComponentMeta<T4>.IsBuffered) ClearBuffer<T4>(in slot, ids.T4);
        if (ComponentMeta<T5>.IsBuffered) ClearBuffer<T5>(in slot, ids.T5);
        if (ComponentMeta<T6>.IsBuffered) ClearBuffer<T6>(in slot, ids.T6);
        if (ComponentMeta<T7>.IsBuffered) ClearBuffer<T7>(in slot, ids.T7);
        if (ComponentMeta<T8>.IsBuffered) ClearBuffer<T8>(in slot, ids.T8);
        if (ComponentMeta<T9>.IsBuffered) ClearBuffer<T9>(in slot, ids.T9);
        if (ComponentMeta<T10>.IsBuffered) ClearBuffer<T10>(in slot, ids.T10);
        if (ComponentMeta<T11>.IsBuffered) ClearBuffer<T11>(in slot, ids.T11);
        if (ComponentMeta<T12>.IsBuffered) ClearBuffer<T12>(in slot, ids.T12);
        if (ComponentMeta<T13>.IsBuffered) ClearBuffer<T13>(in slot, ids.T13);
        if (ComponentMeta<T14>.IsBuffered) ClearBuffer<T14>(in slot, ids.T14);
        if (ComponentMeta<T15>.IsBuffered) ClearBuffer<T15>(in slot, ids.T15);
        if (ComponentMeta<T16>.IsBuffered) ClearBuffer<T16>(in slot, ids.T16);
        if (ComponentMeta<T17>.IsBuffered) ClearBuffer<T17>(in slot, ids.T17);
        if (ComponentMeta<T18>.IsBuffered) ClearBuffer<T18>(in slot, ids.T18);
        if (ComponentMeta<T19>.IsBuffered) ClearBuffer<T19>(in slot, ids.T19);
        if (ComponentMeta<T20>.IsBuffered) ClearBuffer<T20>(in slot, ids.T20);
        if (ComponentMeta<T21>.IsBuffered) ClearBuffer<T21>(in slot, ids.T21);
        if (ComponentMeta<T22>.IsBuffered) ClearBuffer<T22>(in slot, ids.T22);
        if (ComponentMeta<T23>.IsBuffered) ClearBuffer<T23>(in slot, ids.T23);
	}
}