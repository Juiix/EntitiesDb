using System.Runtime.InteropServices;

namespace EntitiesDb.Core;

// These tests assume a real ComponentBufferHeader exists with:
//  int Size; int InternalCapacity; nint Heap; const int DataOffset;
// Memory layout: [Header ...] then inline storage starting at DataOffset.

public unsafe class ComponentBufferTests
{
	// Tag helpers must match the implementation (Size sign-bit = heap tag)
	private const int HeapTag = unchecked((int)0x8000_0000);
	private const int SizeMask = 0x7FFF_FFFF;

	private static bool IsHeap(ComponentBufferHeader* h) => (h->Size & HeapTag) != 0;
	private static int LogicalSize(ComponentBufferHeader* h) => h->Size & SizeMask;

	// ---------- Test fixture for allocating header + inline region ----------

	private sealed class BufferHandle<T> : IDisposable where T : unmanaged
	{
		public ComponentBufferHeader* Header;
		public IntPtr Owner;   // start of header+inline block

		public BufferHandle(int internalCapacity)
		{
			int headerBytes = ComponentBufferHeader.DataOffset;
			nuint total = (nuint)headerBytes + (nuint)(internalCapacity * sizeof(T));
			Owner = Marshal.AllocHGlobal((IntPtr)total);

			Header = (ComponentBufferHeader*)Owner.ToPointer();
			Header->Size = 0; // tag cleared => inline
			Header->InternalCapacity = internalCapacity;
			// DO NOT write Header->Heap here; it may alias inline bytes
		}

		public ComponentBuffer<T> Buffer => new ComponentBuffer<T>((void*)Header);

		public void Dispose()
		{
			try { Buffer.Clear(); }
			finally
			{
				if (Owner != IntPtr.Zero) Marshal.FreeHGlobal(Owner);
				Owner = IntPtr.Zero;
				Header = null;
			}
		}
	}

	private static void FillSequential(ComponentBuffer<int> buf, int count)
	{
		for (int i = 0; i < count; i++) buf.Add(i);
	}

	// ---------- Basics / inline vs heap ----------

	[Fact]
	public void NewBuffer_Empty_Inline_NoHeapTag()
	{
		using var h = new BufferHandle<int>(internalCapacity: 8);
		Assert.Equal(0, h.Buffer.Length);
		Assert.False(IsHeap(h.Header));
		Assert.Equal(0, LogicalSize(h.Header));
	}

	[Fact]
	public void Add_WithinInlineCapacity_StaysInline_AndReadsBack()
	{
		using var h = new BufferHandle<int>(internalCapacity: 4);

		h.Buffer.Add(10);
		h.Buffer.Add(20);
		h.Buffer.Add(30);
		h.Buffer.Add(40);

		Assert.Equal(4, h.Buffer.Length);
		Assert.False(IsHeap(h.Header)); // still inline

		Assert.Equal(10, h.Buffer[0]);
		Assert.Equal(20, h.Buffer[1]);
		Assert.Equal(30, h.Buffer[2]);
		Assert.Equal(40, h.Buffer[3]);

		// indexer returns by-ref; mutation reflects back
		h.Buffer[2] = 300;
		Assert.Equal(300, h.Buffer[2]);
	}

	[Fact]
	public void Add_BeyondInlineCapacity_PromotesToHeap_PreservesData()
	{
		using var h = new BufferHandle<int>(internalCapacity: 4);

		FillSequential(h.Buffer, 4);
		Assert.False(IsHeap(h.Header));

		// next add causes growth -> heap
		h.Buffer.Add(4);
		Assert.True(IsHeap(h.Header));
		Assert.Equal(5, h.Buffer.Length);

		for (int i = 0; i < 5; i++)
			Assert.Equal(i, h.Buffer[i]);
	}

	// ---------- AddRange ----------

	[Fact]
	public void AddRange_Array_CopiesAndGrows()
	{
		using var h = new BufferHandle<int>(internalCapacity: 4);

		h.Buffer.Add(1);
		h.Buffer.Add(2);

		h.Buffer.AddRange(new[] { 3, 4, 5, 6, 7 });
		Assert.Equal(7, h.Buffer.Length);

		var expected = Enumerable.Range(1, 7).ToArray();
		Assert.Equal(expected, h.Buffer.Span.ToArray());
	}

	[Fact]
	public void AddRange_Span_FromSelf_NoRealloc_Works()
	{
		using var h = new BufferHandle<int>(internalCapacity: 16);

		FillSequential(h.Buffer, 8); // inline cap = 16
		var src = h.Buffer.Span.Slice(0, 3);

		h.Buffer.AddRange(src); // new size = 11 <= 16 -> still inline

		Assert.False(IsHeap(h.Header));
		Assert.Equal(11, h.Buffer.Length);
		var expected = Enumerable.Range(0, 8).Concat(Enumerable.Range(0, 3)).ToArray();
		Assert.Equal(expected, h.Buffer.Span.ToArray());
	}

	// ---------- RemoveAt (stable) ----------

	[Fact]
	public void RemoveAt_OrderPreserving_First_Middle_Last()
	{
		using var h = new BufferHandle<int>(internalCapacity: 8);
		FillSequential(h.Buffer, 6); // [0,1,2,3,4,5]

		h.Buffer.RemoveAt(0);
		Assert.Equal(new[] { 1, 2, 3, 4, 5 }, h.Buffer.Span.ToArray());

		h.Buffer.RemoveAt(2); // remove value 3
		Assert.Equal(new[] { 1, 2, 4, 5 }, h.Buffer.Span.ToArray());

		h.Buffer.RemoveAt(3); // remove last (value 5)
		Assert.Equal(new[] { 1, 2, 4 }, h.Buffer.Span.ToArray());
	}

	// ---------- RemoveAtSwapBack (unstable) ----------

	[Fact]
	public void RemoveAtSwapBack_NotOrderPreserving_SwapsDownLast()
	{
		using var h = new BufferHandle<int>(internalCapacity: 8);
		foreach (var v in new[] { 10, 20, 30, 40, 50 }) h.Buffer.Add(v);

		h.Buffer.RemoveAtSwapBack(1);
		Assert.Equal(4, h.Buffer.Length);
		Assert.Equal(50, h.Buffer[1]); // swapped in
		Assert.True(h.Buffer.Span.ToArray().OrderBy(x => x).SequenceEqual(new[] { 10, 30, 40, 50 }));
	}

	// ---------- Remove (by value) ----------

	[Fact]
	public void Remove_ByValue_RemovesFirstMatch_Stable()
	{
		using var h = new BufferHandle<int>(internalCapacity: 8);
		foreach (var v in new[] { 10, 20, 20, 30 }) h.Buffer.Add(v);

		var removed = h.Buffer.Remove(20);
		Assert.True(removed);
		Assert.Equal(new[] { 10, 20, 30 }, h.Buffer.Span.ToArray());

		// remove value not present
		Assert.False(h.Buffer.Remove(99));
		Assert.Equal(new[] { 10, 20, 30 }, h.Buffer.Span.ToArray());
	}

	// ---------- Clear / shrink ----------

	[Fact]
	public void Clear_FromHeap_MarksInline_AndResetsSize()
	{
		using var h = new BufferHandle<int>(internalCapacity: 4);
		for (int i = 0; i < 5; i++) h.Buffer.Add(i); // promote to heap
		Assert.True(IsHeap(h.Header));

		h.Buffer.Clear();
		Assert.False(IsHeap(h.Header));   // now inline
		Assert.Equal(0, h.Buffer.Length);
		Assert.Equal(0, LogicalSize(h.Header));
	}

	[Fact]
	public void RemoveAt_AtShrinkBoundary_MovesBackInline()
	{
		using var h = new BufferHandle<int>(internalCapacity: 4);
		// size 5 -> heap
		for (int i = 0; i < 5; i++) h.Buffer.Add(i);
		Assert.True(IsHeap(h.Header));

		// removing one yields size=4 == baseCap => inline
		h.Buffer.RemoveAt(4);
		Assert.False(IsHeap(h.Header));
		Assert.Equal(4, h.Buffer.Length);
		Assert.Equal(new[] { 0, 1, 2, 3 }, h.Buffer.Span.ToArray());
	}

	// ---------- Bounds & Get ----------

	[Fact]
	public void Indexer_OutOfRange_Throws()
	{
		using var h = new BufferHandle<int>(internalCapacity: 4);
		h.Buffer.Add(1);

		Assert.Throws<ArgumentOutOfRangeException>(() => { var _ = h.Buffer[-1]; });
		Assert.Throws<ArgumentOutOfRangeException>(() => { var _ = h.Buffer[1]; });
	}

	[Fact]
	public void RemoveAt_OutOfRange_Throws()
	{
		using var h = new BufferHandle<int>(internalCapacity: 4);
		h.Buffer.Add(1);
		Assert.Throws<ArgumentOutOfRangeException>(() => h.Buffer.RemoveAt(-1));
		Assert.Throws<ArgumentOutOfRangeException>(() => h.Buffer.RemoveAt(1));
		Assert.Throws<ArgumentOutOfRangeException>(() => h.Buffer.RemoveAtSwapBack(42));
	}

	[Fact]
	public void Get_ReturnsRef_AndMutatesUnderlying()
	{
		using var h = new BufferHandle<int>(internalCapacity: 4);
		h.Buffer.Add(11);
		h.Buffer.Add(22);

		ref var v = ref h.Buffer.Get(1);
		Assert.Equal(h.Buffer[1], v);

		v = 222;
		Assert.Equal(222, h.Buffer[1]);
	}

	// ---------- Heap/inline overlay regression ----------

	private struct EightBytes
	{
		public long X; // 8 bytes; makes it easy to get non-zero over the Heap-sized region
		public EightBytes(long x) => X = x;
	}

	[Fact]
	public void Inline_HeapOverlay_NonZeroBytes_DoesNotFreeOrCrash()
	{
		// If Header->Heap overlays first inline bytes, writing a non-zero first element
		// must NOT trick the implementation into treating storage as heap.
		using var h = new BufferHandle<EightBytes>(internalCapacity: 4);

		h.Buffer.Add(new EightBytes(0x11223344_55667788)); // non-zero first 8 bytes
		Assert.False(IsHeap(h.Header)); // still inline

		// This would have caused a bogus free in the old implementation.
		h.Buffer.Clear();
		Assert.False(IsHeap(h.Header));
		Assert.Equal(0, h.Buffer.Length);

		// Still usable after Clear
		h.Buffer.Add(new EightBytes(42));
		Assert.False(IsHeap(h.Header));
		Assert.Equal(1, h.Buffer.Length);
		Assert.Equal(42, h.Buffer[0].X);
	}

	// ---------- Large struct & realloc stress ----------

	private struct Big
	{
		public long A, B, C, D;
		public Big(long i) { A = i; B = i + 1; C = i + 2; D = i + 3; }
	}

	[Fact]
	public void BigStruct_AddRange_And_Remove_Work()
	{
		using var h = new BufferHandle<Big>(internalCapacity: 2);

		var arr = Enumerable.Range(0, 5).Select(i => new Big(i)).ToArray();
		h.Buffer.AddRange(arr);

		Assert.True(IsHeap(h.Header));
		Assert.Equal(5, h.Buffer.Length);
		Assert.Equal(0L, h.Buffer[0].A);
		Assert.Equal(3L, h.Buffer[0].D);

		// Remove middle (stable)
		h.Buffer.RemoveAt(2);
		Assert.Equal(4, h.Buffer.Length);
		Assert.Equal(1L, h.Buffer[1].A);
		Assert.Equal(3L, h.Buffer[2].A); // shifted left
	}

	[Fact]
	public void Reallocation_PreservesData_AcrossManyAdds()
	{
		using var h = new BufferHandle<int>(internalCapacity: 4);
		int N = 1_000;

		for (int i = 0; i < N; i++) h.Buffer.Add(i);

		Assert.Equal(N, h.Buffer.Length);
		Assert.True(IsHeap(h.Header));

		// spot-check
		Assert.Equal(0, h.Buffer[0]);
		Assert.Equal(123, h.Buffer[123]);
		Assert.Equal(999, h.Buffer[999]);
	}
}
