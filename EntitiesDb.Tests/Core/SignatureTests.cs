namespace EntitiesDb.Core;

public class SignatureTests
{
	private static Signature FromBits(params int[] ids)
	{
		var s = Signature.Empty;
		foreach (var id in ids)
			s = s.WithSet(id);
		return s;
	}

	// --- Construction helpers -------------------------------------------------

	[Fact]
	public void Empty_IsAllZero()
	{
		var s = Signature.Empty;
		Assert.Equal(0UL, s.W0);
		Assert.Equal(0UL, s.W1);
		Assert.Equal(0UL, s.W2);
		Assert.Equal(0UL, s.W3);
		Assert.True(s.IsEmpty);
		Assert.Equal(0, s.PopCount());
	}

	[Theory]
	[InlineData(0, 0)]
	[InlineData(1, 0)]
	[InlineData(63, 0)]
	[InlineData(64, 1)]
	[InlineData(127, 1)]
	[InlineData(128, 2)]
	[InlineData(191, 2)]
	[InlineData(192, 3)]
	[InlineData(255, 3)]
	public void SingleBit_SetsCorrectWord(int id, int expectedWord)
	{
		var s = Signature.SingleBit(id);
		Assert.Equal(1, s.PopCount());
		Assert.True(s.Test(id));

		// Check only the expected word is non-zero
		var wordValue = 1ul << (id & 63);
		Assert.Equal(expectedWord == 0 ? wordValue : 0UL, expectedWord == 0 ? s.W0 : 0UL);
		Assert.Equal(expectedWord == 1 ? wordValue : 0UL, expectedWord == 1 ? s.W1 : 0UL);
		Assert.Equal(expectedWord == 2 ? wordValue : 0UL, expectedWord == 2 ? s.W2 : 0UL);
		Assert.Equal(expectedWord == 3 ? wordValue : 0UL, expectedWord == 3 ? s.W3 : 0UL);
	}

	[Theory]
	[InlineData(-1)]
	[InlineData(256)]
	[InlineData(10_000)]
	public void SingleBit_OutOfRange_Throws(int id)
	{
		Assert.Throws<ArgumentOutOfRangeException>(() => Signature.SingleBit(id));
	}

	// --- Queries --------------------------------------------------------------

	[Fact]
	public void Test_ReturnsTrueForSetBitsFalseOtherwise()
	{
		var s = FromBits(0, 64, 129, 190, 255);

		Assert.True(s.Test(0));
		Assert.True(s.Test(64));
		Assert.True(s.Test(129));
		Assert.True(s.Test(190));
		Assert.True(s.Test(255));

		Assert.False(s.Test(1));
		Assert.False(s.Test(63));
		Assert.False(s.Test(65));
		Assert.False(s.Test(254));

		// Out-of-range gracefully false
		Assert.False(s.Test(256));
		Assert.False(s.Test(10_000));
		Assert.False(s.Test(-1));
	}

	[Fact]
	public void PopCount_Accurate()
	{
		var s = FromBits(0, 1, 2, 63, 64, 127, 128, 191, 192, 255); // 10 bits
		Assert.Equal(10, s.PopCount());
	}

	// --- Relations ------------------------------------------------------------

	[Fact]
	public void HasAll_SubsetAndSuperset()
	{
		var all = FromBits(0, 1, 64, 129, 255);
		var sub = FromBits(1, 129);

		Assert.True(all.HasAll(sub));
		Assert.True(all.IsSupersetOf(sub));
		Assert.True(sub.IsSubsetOf(all));

		var notSub = FromBits(2, 200);
		Assert.False(all.HasAll(notSub));
		Assert.False(all.IsSupersetOf(notSub));
		Assert.False(notSub.IsSubsetOf(all));
	}

	[Fact]
	public void HasAny_NoneAndSome()
	{
		var a = FromBits(0, 64, 128);
		var b = FromBits(1, 65, 129);
		var c = FromBits(64); // overlaps with a

		Assert.False(a.HasAny(b));
		Assert.True(a.HasNone(b));

		Assert.True(a.HasAny(c));
		Assert.False(a.HasNone(c));
	}

	// --- Bitwise ops & operators ---------------------------------------------

	[Fact]
	public void And_Operator_Equals_Method()
	{
		var a = FromBits(0, 2, 64, 130);
		var b = FromBits(2, 64, 129);

		Assert.Equal(a.And(b), a & b);

		var expected = FromBits(2, 64);
		Assert.Equal(expected, a & b);
	}

	[Fact]
	public void Or_Operator_Equals_Method()
	{
		var a = FromBits(0, 64);
		var b = FromBits(1, 128);

		Assert.Equal(a.Or(b), a | b);

		var expected = FromBits(0, 1, 64, 128);
		Assert.Equal(expected, a | b);
	}

	[Fact]
	public void Xor_Operator_Equals_Method()
	{
		var a = FromBits(0, 64, 128);
		var b = FromBits(64, 129);

		Assert.Equal(a.Xor(b), a ^ b);

		var expected = FromBits(0, 128, 129); // 64 cancels
		Assert.Equal(expected, a ^ b);
	}

	[Fact]
	public void AndNot_Equals_Amp_Of_Not()
	{
		var a = FromBits(0, 1, 64, 128, 129);
		var b = FromBits(1, 129);

		Assert.Equal(a.AndNot(b), a & ~b);

		var expected = FromBits(0, 64, 128);
		Assert.Equal(expected, a.AndNot(b));
	}

	[Fact]
	public void Not_ComplementsAllBits()
	{
		var ids = new[] { 0, 64, 128, 192, 255 };
		var s = FromBits(ids);
		var n = ~s;

		// Complement twice returns original
		Assert.Equal(s, ~n);

		// Original bits must be cleared in complement
		foreach (var id in ids)
			Assert.False(n.Test(id));
	}

	// --- Equality / Hash ------------------------------------------------------

	[Fact]
	public void Equals_And_Operators_Work()
	{
		var a = FromBits(1, 64, 129);
		var b = FromBits(1, 64, 129);
		var c = FromBits(2, 64, 129);

		Assert.True(a.Equals(b));
		Assert.True(a == b);
		Assert.True(a != c);
		Assert.True(a.Equals((object)b));
		Assert.False(a.Equals((object)c));
	}

	[Fact]
	public void GetHashCode_EqualValuesSameHash()
	{
		var a = FromBits(0, 64, 129, 255);
		var b = FromBits(0, 64, 129, 255);

		Assert.Equal(a, b);
		Assert.Equal(a.GetHashCode(), b.GetHashCode());
	}

	// --- Mutators (fluent) ----------------------------------------------------

	[Fact]
	public void WithSet_SetsBit_And_IsImmutable()
	{
		var s = Signature.Empty;
		var s2 = s.WithSet(129);

		Assert.False(s.Test(129)); // original unchanged
		Assert.True(s2.Test(129)); // new has the bit
	}

	[Fact]
	public void WithCleared_ClearsBit_And_IsImmutable()
	{
		var s = FromBits(0, 1, 129);
		var s2 = s.WithCleared(1);

		Assert.True(s.Test(1));      // original unchanged
		Assert.False(s2.Test(1));    // new has it cleared
		Assert.True(s2.Test(0));     // others preserved
		Assert.True(s2.Test(129));
	}

	[Fact]
	public void WithSet_OutOfRange_IsIgnored()
	{
		var s = Signature.Empty.WithSet(9999).WithSet(-5);
		Assert.True(s.IsEmpty);
	}

	[Fact]
	public void WithCleared_OutOfRange_IsIgnored()
	{
		var s = FromBits(0, 5).WithCleared(9999).WithCleared(-7);
		Assert.True(s.Test(0));
		Assert.True(s.Test(5));
	}

	// --- Iteration helper -----------------------------------------------------

	[Fact]
	public void TryGetNextSetBit_Empty_ReturnsFalse()
	{
		var s = Signature.Empty;
		Assert.False(s.TryGetNextSetBit(0, out var idx));
		Assert.Equal(-1, idx);
	}

	[Fact]
	public void TryGetNextSetBit_FindsFirstAtOrAfterStart_InSameWord()
	{
		var s = FromBits(1, 3, 10);

		Assert.True(s.TryGetNextSetBit(0, out var i0));
		Assert.Equal(1, i0);

		Assert.True(s.TryGetNextSetBit(2, out var i1));
		Assert.Equal(3, i1);

		Assert.True(s.TryGetNextSetBit(4, out var i2));
		Assert.Equal(10, i2);
	}

	[Fact]
	public void TryGetNextSetBit_CrossesWordBoundaries()
	{
		var s = FromBits(63, 64, 127, 128, 191, 192, 255);

		Assert.True(s.TryGetNextSetBit(60, out var i0));
		Assert.Equal(63, i0);

		Assert.True(s.TryGetNextSetBit(65, out var i1));
		Assert.Equal(127, i1);

		Assert.True(s.TryGetNextSetBit(129, out var i2));
		Assert.Equal(191, i2);

		Assert.True(s.TryGetNextSetBit(193, out var i3));
		Assert.Equal(255, i3);
	}

	[Fact]
	public void TryGetNextSetBit_StartOnSetBit_ReturnsThatBit()
	{
		var s = FromBits(0, 64, 128);
		Assert.True(s.TryGetNextSetBit(64, out var idx));
		Assert.Equal(64, idx);
	}

	[Fact]
	public void TryGetNextSetBit_StartAfterLast_ReturnsFalse()
	{
		var s = FromBits(10, 20, 30);
		Assert.False(s.TryGetNextSetBit(31, out var idx));
		Assert.Equal(-1, idx);
	}

	[Fact]
	public void TryGetNextSetBit_StartNegative_TreatedAsOutOfRange_ReturnsFalse()
	{
		var s = FromBits(0, 5, 100);
		// (uint)start >= 256 for negatives => returns false
		Assert.False(s.TryGetNextSetBit(-1, out var idx));
		Assert.Equal(-1, idx);
	}

	[Fact]
	public void TryGetNextSetBit_StartAtUpperBound256_ReturnsFalse()
	{
		var s = FromBits(255);
		Assert.False(s.TryGetNextSetBit(256, out var idx));
		Assert.Equal(-1, idx);
	}

	// --- ToString -------------------------------------------------------------

	[Fact]
	public void ToString_HasFourWordsSeparatedByUnderscores()
	{
		var s = FromBits(0, 64, 128, 192, 255);
		var text = s.ToString();

		Assert.StartsWith("[", text);
		Assert.EndsWith("]", text);
		Assert.Equal(3, text.Count(c => c == '_'));

		// ensure at least some 1s present
		Assert.Contains("1", text);
	}
}
