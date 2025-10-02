using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EntitiesDb.Core;

public sealed unsafe class ReadOnlyBufferTests
{
	// --------------------- BufferHandle for tests -------------------------
	private sealed class BufferHandle<T> : IDisposable where T : unmanaged
	{
		public BufferHeader* Header;
		public IntPtr Owner; // start of header + inline block

		public unsafe BufferHandle(int internalCapacity)
		{
			int headerBytes = BufferHeader.DataOffset;
			nuint total = (nuint)headerBytes + (nuint)(internalCapacity * sizeof(T));
			Owner = Marshal.AllocHGlobal((IntPtr)total);

			Header = (BufferHeader*)Owner.ToPointer();
			Header->Size = 0; // tag cleared => inline
			Header->InternalCapacity = internalCapacity;
			// DO NOT write Header->Heap here; it may alias inline bytes
		}

		public unsafe DynamicBuffer<T> Buffer => new((void*)Header);

		public unsafe void Dispose()
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

	// ------------------------ Helpers ------------------------------------
	private static ReadOnlySpan<int> Seq(params int[] xs) => xs;

	// Throw-path helpers that DO NOT capture ref structs:
	private static void TouchIndexer(BufferHandle<int> h, int index)
	{
		var ro = h.Buffer.AsReadOnly();
		var _ = ro[index]; // throws for OOR
	}

	private static void CopyToInto(BufferHandle<int> h, int destLen)
	{
		var ro = h.Buffer.AsReadOnly();
		var dst = new int[destLen];
		ro.CopyTo(dst); // throws if dst too small
	}

	// ------------------------- Tests --------------------------------------

	[Fact]
	public unsafe void Empty_Init_ZeroLength_NoCrash()
	{
		using var h = new BufferHandle<int>(internalCapacity: 4);
		var buf = h.Buffer;
		buf.Init(4, ReadOnlySpan<int>.Empty);

		var ro = buf.AsReadOnly();

		Assert.Equal(0, ro.Length);
		Assert.Equal(0, ro.Span.Length);
		Assert.True(ro.IsEmpty());
	}

	[Fact]
	public unsafe void Length_Span_Indexer_Basic()
	{
		using var h = new BufferHandle<int>(4);
		var buf = h.Buffer;
		buf.Init(4, Seq(1, 2, 3, 4));

		var ro = buf.AsReadOnly();

		Assert.Equal(4, ro.Length);
		Assert.Equal(new[] { 1, 2, 3, 4 }, ro.Span.ToArray());
		Assert.Equal(1, ro[0]);
		Assert.Equal(4, ro[3]);
	}

	[Fact]
	public unsafe void Contains_And_IndexOf_Work()
	{
		using var h = new BufferHandle<int>(2);
		var buf = h.Buffer;
		buf.Init(2, Seq(10, 20, 30));

		var ro = buf.AsReadOnly();

		Assert.True(ro.Contains(10));
		Assert.False(ro.Contains(25));
		Assert.Equal(1, ro.IndexOf(20));
		Assert.Equal(-1, ro.IndexOf(99));
	}

	[Fact]
	public unsafe void CopyTo_And_TryCopyTo_And_ToArray()
	{
		using var h = new BufferHandle<int>(4);
		var buf = h.Buffer;
		buf.Init(4, Seq(7, 8, 9));

		var ro = buf.AsReadOnly();

		var dst = new int[3];
		ro.CopyTo(dst);
		Assert.Equal(new[] { 7, 8, 9 }, dst);

		var small = new int[2];
		Assert.False(ro.TryCopyTo(small));

		bool threw = false;
		try { CopyToInto(h, destLen: 2); }
		catch (ArgumentException) { threw = true; }
		Assert.True(threw);

		Assert.Equal(new[] { 7, 8, 9 }, ro.ToArray());
	}

	[Fact]
	public unsafe void GetPinnableReference_Empty_ReturnsNullRef()
	{
		using var h = new BufferHandle<int>(4);
		var buf = h.Buffer;
		buf.Init(4, ReadOnlySpan<int>.Empty);

		var ro = buf.AsReadOnly();

		ref readonly int r = ref ro.GetPinnableReference();
		Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in r)));
	}

	[Fact]
	public unsafe void GetPinnableReference_NonEmpty_IsPinnable()
	{
		using var h = new BufferHandle<int>(2);
		var buf = h.Buffer;
		buf.Init(2, Seq(42));

		var ro = buf.AsReadOnly();

		ref readonly int r = ref ro.GetPinnableReference();
		Assert.False(Unsafe.IsNullRef(ref Unsafe.AsRef(in r)));

		fixed (int* p = &Unsafe.AsRef(in r))
		{
			Assert.Equal(42, *p);
		}
	}

	[Fact]
	public unsafe void Enumerator_Iterates_InOrder()
	{
		using var h = new BufferHandle<int>(2);
		var buf = h.Buffer;
		buf.Init(2, Seq(5, 6, 7, 8, 9));

		var ro = buf.AsReadOnly();

		int i = 0;
		int[] expect = { 5, 6, 7, 8, 9 };
		foreach (ref readonly var v in ro)
		{
			Assert.Equal(expect[i++], v);
		}
		Assert.Equal(expect.Length, i);
	}

	[Fact]
	public unsafe void ReadOnlyView_Reflects_AddedElements()
	{
		using var h = new BufferHandle<int>(2);
		var buf = h.Buffer;
		buf.Init(2, Seq(1, 2));
		var ro = buf.AsReadOnly();

		Assert.Equal(2, ro.Length);
		Assert.Equal(new[] { 1, 2 }, ro.ToArray());

		buf.Add(3);
		buf.Add(4);

		Assert.Equal(4, ro.Length);
		Assert.Equal(new[] { 1, 2, 3, 4 }, ro.ToArray());
	}

	[Fact]
	public unsafe void StoragePromotionAndDemotion_AreTransparentToReadOnly()
	{
		using var h = new BufferHandle<int>(2);
		var buf = h.Buffer;
		buf.Init(2, Seq(100, 200));
		var ro = buf.AsReadOnly();

		// Start inline
		Assert.Equal(2, ro.Length);
		Assert.Equal(new[] { 100, 200 }, ro.ToArray());

		// Promote to heap
		buf.AddRange(Seq(300, 400, 500));
		Assert.Equal(5, ro.Length);
		Assert.Equal(new[] { 100, 200, 300, 400, 500 }, ro.ToArray());

		// Clear (demotes to inline)
		buf.Clear();
		Assert.Equal(0, ro.Length);

		// Small growth (stays inline)
		buf.Add(7);
		buf.Add(8);
		Assert.Equal(2, ro.Length);
		Assert.Equal(new[] { 7, 8 }, ro.ToArray());
	}

	[Fact]
	public unsafe void Indexer_OutOfRange_Throws_UsingHandleHelpers()
	{
		using var h = new BufferHandle<int>(2);
		var buf = h.Buffer;
		buf.Init(2, Seq(1, 2, 3));

		bool threwLower = false, threwUpper = false;
		try { TouchIndexer(h, -1); }
		catch (ArgumentOutOfRangeException) { threwLower = true; }

		try { TouchIndexer(h, 3); }
		catch (ArgumentOutOfRangeException) { threwUpper = true; }

		Assert.True(threwLower);
		Assert.True(threwUpper);
	}
}
