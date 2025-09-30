using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox;

public enum Mismatch
{
	None,        // arrays are identical
	First,       // mismatch at index 0
	Middle,      // mismatch near the middle
	Last         // mismatch at the final element
}

[MemoryDiagnoser]
[DisassemblyDiagnoser(exportCombinedDisassemblyReport: true, maxDepth: 2)]
public class SeqEqBench
{
	// Try a spread: tiny, a few vectors, many vectors
	[Params(1, 2, 8)]
	public int Length;

	[Params(Mismatch.None)]
	public Mismatch Case;

	private ulong[] _a = Array.Empty<ulong>();
	private ulong[] _b = Array.Empty<ulong>();

	[GlobalSetup]
	public void Setup()
	{
		var rng = new Random(42);
		_a = Enumerable.Range(0, Length).Select(_ => (ulong)rng.Next()).ToArray();
		_b = (ulong[])_a.Clone();

		if (Case != Mismatch.None && Length > 0)
		{
			int idx = Case switch
			{
				Mismatch.First => 0,
				Mismatch.Middle => Length / 2,
				Mismatch.Last => Length - 1,
				_ => 0
			};
			_b[idx] ^= 0xFFFF_FFFFu; // flip to force mismatch
		}
	}

	[Benchmark(Baseline = true)]
	public bool SequenceEqual()
		=> _a.AsSpan().SequenceEqual(_b);

	[Benchmark]
	public bool ScalarLoop()
	{
		var a = _a.AsSpan();
		var b = _b.AsSpan();
		if (a.Length != b.Length) return false;

		for (int i = 0; i < a.Length; i++)
			if (a[i] != b[i]) return false;
		return true;
	}

	[Benchmark]
	public bool Vectorized()
	{
		var a = _a.AsSpan();
		var b = _b.AsSpan();
		if (a.Length != b.Length) return false;

		// Compare full vectors
		var va = MemoryMarshal.Cast<ulong, Vector<ulong>>(a);
		var vb = MemoryMarshal.Cast<ulong, Vector<ulong>>(b);

		for (int i = 0; i < va.Length; i++)
			if (va[i] != vb[i]) return false;

		// Tail
		int tailStart = va.Length * Vector<ulong>.Count;
		for (int i = tailStart; i < a.Length; i++)
			if (a[i] != b[i]) return false;

		return true;
	}
}
