using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EntitiesDb.Core;

public sealed unsafe class ReadBufferTests
{
	// --------------------- BufferHandle for tests -------------------------
	private sealed class BufferHandle<T> : IDisposable where T : unmanaged
	{
		public BufferHeader* Header;
		public IntPtr Owner; // start of header + inline block

		public unsafe BufferHandle()
		{
			int headerBytes = BufferHeader.DataOffset;
			nuint total = (nuint)headerBytes + (nuint)(ComponentMeta<BufferedInt>.InternalCapacity * sizeof(T));
			Owner = Marshal.AllocHGlobal((IntPtr)total);
			Header = (BufferHeader*)Owner.ToPointer();
		}

		public unsafe WriteBuffer<T> Buffer => new((void*)Header);

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

	[Buffered(4)] private record struct BufferedInt(int Value);

	// ------------------------ Helpers ------------------------------------
	private static ReadOnlySpan<BufferedInt> Seq(params int[] xs) => Arr(xs);
	private static BufferedInt[] Arr(params int[] xs) => xs.Select(x => new BufferedInt(x)).ToArray();

	// Throw-path helpers that DO NOT capture ref structs:
	private static void TouchIndexer(BufferHandle<BufferedInt> h, int index)
	{
		var ro = h.Buffer.AsReadOnly();
		var _ = ro[index]; // throws for OOR
	}

	private static void CopyToInto(BufferHandle<BufferedInt> h, int destLen)
	{
		var ro = h.Buffer.AsReadOnly();
		var dst = new BufferedInt[destLen];
		ro.CopyTo(dst); // throws if dst too small
	}

	// ------------------------- Tests --------------------------------------

	[Fact]
	public unsafe void Empty_Init_ZeroLength_NoCrash()
	{
		using var h = new BufferHandle<BufferedInt>();
		var buf = h.Buffer;
		buf.Init(ReadOnlySpan<BufferedInt>.Empty);

		var ro = buf.AsReadOnly();

		Assert.Equal(0, ro.Length);
		Assert.Equal(0, ro.Span.Length);
		Assert.True(ro.IsEmpty());
	}

	[Fact]
	public unsafe void Length_Span_Indexer_Basic()
	{
		using var h = new BufferHandle<BufferedInt>();
		var buf = h.Buffer;
		buf.Init(Seq(1, 2, 3, 4));

		var ro = buf.AsReadOnly();

		Assert.Equal(4, ro.Length);
		Assert.Equal(Arr([1, 2, 3, 4]), ro.Span.ToArray());
		Assert.Equal(1, ro[0].Value);
		Assert.Equal(4, ro[3].Value);
	}

	[Fact]
	public unsafe void Contains_And_IndexOf_Work()
	{
		using var h = new BufferHandle<BufferedInt>();
		var buf = h.Buffer;
		buf.Init(Seq(10, 20, 30));

		var ro = buf.AsReadOnly();

		Assert.True(ro.Contains(new BufferedInt(10)));
		Assert.False(ro.Contains(new BufferedInt(25)));
		Assert.Equal(1, ro.IndexOf(new BufferedInt(20)));
		Assert.Equal(-1, ro.IndexOf(new BufferedInt(99)));
	}

	[Fact]
	public unsafe void CopyTo_And_TryCopyTo_And_ToArray()
	{
		using var h = new BufferHandle<BufferedInt>();
		var buf = h.Buffer;
		buf.Init(Seq(7, 8, 9));

		var ro = buf.AsReadOnly();

		var dst = new BufferedInt[3];
		ro.CopyTo(dst);
		Assert.Equal(Arr(new[] { 7, 8, 9 }), dst);

		var small = new BufferedInt[2];
		Assert.False(ro.TryCopyTo(small));

		bool threw = false;
		try { CopyToInto(h, destLen: 2); }
		catch (ArgumentException) { threw = true; }
		Assert.True(threw);

		Assert.Equal(Arr(new[] { 7, 8, 9 }), ro.ToArray());
	}

	[Fact]
	public unsafe void GetPinnableReference_Empty_ReturnsNullRef()
	{
		using var h = new BufferHandle<BufferedInt>();
		var buf = h.Buffer;
		buf.Init(ReadOnlySpan<BufferedInt>.Empty);

		var ro = buf.AsReadOnly();

		ref readonly BufferedInt r = ref ro.GetPinnableReference();
		Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in r)));
	}

	[Fact]
	public unsafe void GetPinnableReference_NonEmpty_IsPinnable()
	{
		using var h = new BufferHandle<BufferedInt>();
		var buf = h.Buffer;
		buf.Init(Seq(42));

		var ro = buf.AsReadOnly();

		ref readonly BufferedInt r = ref ro.GetPinnableReference();
		Assert.False(Unsafe.IsNullRef(ref Unsafe.AsRef(in r)));

		fixed (BufferedInt* p = &Unsafe.AsRef(in r))
		{
			Assert.Equal(new BufferedInt(42), *p);
		}
	}

	[Fact]
	public unsafe void Enumerator_Iterates_InOrder()
	{
		using var h = new BufferHandle<BufferedInt>();
		var buf = h.Buffer;
		buf.Init(Seq(5, 6, 7, 8, 9));

		var ro = buf.AsReadOnly();

		int i = 0;
		int[] expect = { 5, 6, 7, 8, 9 };
		foreach (ref readonly var v in ro)
		{
			Assert.Equal(new BufferedInt(expect[i++]), v);
		}
		Assert.Equal(expect.Length, i);
	}

	[Fact]
	public unsafe void ReadOnlyView_Reflects_AddedElements()
	{
		using var h = new BufferHandle<BufferedInt>();
		var buf = h.Buffer;
		buf.Init(Seq(1, 2));
		var ro = buf.AsReadOnly();

		Assert.Equal(2, ro.Length);
		Assert.Equal(Arr(new[] { 1, 2 }), ro.ToArray());

		buf.Add(new BufferedInt(3));
		buf.Add(new BufferedInt(4));

		Assert.Equal(4, ro.Length);
		Assert.Equal(Arr(new[] { 1, 2, 3, 4 }), ro.ToArray());
	}

	[Fact]
	public unsafe void StoragePromotionAndDemotion_AreTransparentToReadOnly()
	{
		using var h = new BufferHandle<BufferedInt>();
		var buf = h.Buffer;
		buf.Init(Seq(100, 200));
		var ro = buf.AsReadOnly();

		// Start inline
		Assert.Equal(2, ro.Length);
		Assert.Equal(Arr(new[] { 100, 200 }), ro.ToArray());

		// Promote to heap
		buf.AddRange(Seq(300, 400, 500));
		Assert.Equal(5, ro.Length);
		Assert.Equal(Arr(new[] { 100, 200, 300, 400, 500 }), ro.ToArray());

		// Clear (demotes to inline)
		buf.Clear();
		Assert.Equal(0, ro.Length);

		// Small growth (stays inline)
		buf.Add(new BufferedInt(7));
		buf.Add(new BufferedInt(8));
		Assert.Equal(2, ro.Length);
		Assert.Equal(Arr(new[] { 7, 8 }), ro.ToArray());
	}

	[Fact]
	public unsafe void Indexer_OutOfRange_Throws_UsingHandleHelpers()
	{
		using var h = new BufferHandle<BufferedInt>();
		var buf = h.Buffer;
		buf.Init(Seq(1, 2, 3));

		bool threwLower = false, threwUpper = false;
		try { TouchIndexer(h, -1); }
		catch (ArgumentOutOfRangeException) { threwLower = true; }

		try { TouchIndexer(h, 3); }
		catch (ArgumentOutOfRangeException) { threwUpper = true; }

		Assert.True(threwLower);
		Assert.True(threwUpper);
	}
}
