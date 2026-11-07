using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace EntitiesDb;

/// <summary>
/// Keeps one freed native block per power-of-two size (64 KB to 1 GB) for the next database to take.
/// </summary>
/// <remarks>
/// Large native blocks come straight from the OS: a fresh one costs a page fault per 4 KB on first
/// touch, and freeing hands it back. A program that disposes a database and builds another (tests, a
/// database per match) would pay that again for every entity map. A pooled block is already faulted in.
/// Like <c>ArrayPool&lt;T&gt;.Shared</c>, the pool checks after each gen2 collection and lets go of a
/// block nobody took for a minute, or of every block when memory is short. (Counting collections
/// instead would empty it in a program that forces them, as benchmark harnesses do between runs.)
/// </remarks>
internal static class NativeBlockPool
{
	private const int MinShift = 16; // 64 KB
	private const int MaxShift = 30; // 1 GB

	private static readonly long[] s_blocks = new long[MaxShift + 1]; // addresses; long for Interlocked on every target
	private static readonly int[] s_returnedAt = new int[MaxShift + 1]; // Environment.TickCount at return

	/// <summary>
	/// How long an untaken block stays pooled (tests shorten it)
	/// </summary>
	internal static int IdleMilliseconds = 60_000;
	private static int s_trimmerStarted;

	/// <summary>
	/// A block of <paramref name="bytes"/>, pooled when one of that size is free; contents undefined
	/// </summary>
	public static nint Rent(long bytes)
	{
		var shift = PooledShift(bytes);
		if (shift >= 0)
		{
			var block = Interlocked.Exchange(ref s_blocks[shift], 0L);
			if (block != 0)
				return (nint)block;
		}
		return Marshal.AllocHGlobal((nint)bytes);
	}

	/// <summary>
	/// Gives back a block from <see cref="Rent"/> (or any <see cref="Marshal.AllocHGlobal(nint)"/> block)
	/// of <paramref name="bytes"/>; the caller must not touch it again
	/// </summary>
	public static void Return(nint block, long bytes)
	{
		var shift = PooledShift(bytes);
		if (shift < 0)
		{
			Marshal.FreeHGlobal(block);
			return;
		}

		StartTrimmer();
		Volatile.Write(ref s_returnedAt[shift], Environment.TickCount);
		var previous = Interlocked.Exchange(ref s_blocks[shift], (long)block);
		if (previous != 0)
			Marshal.FreeHGlobal((nint)previous);
	}

	/// <summary>
	/// If a block of <paramref name="bytes"/> is waiting in the pool (tests)
	/// </summary>
	internal static bool IsHolding(long bytes)
	{
		var shift = PooledShift(bytes);
		return shift >= 0 && Volatile.Read(ref s_blocks[shift]) != 0;
	}

	private static int PooledShift(long bytes)
	{
		if (bytes < 1L << MinShift || bytes > 1L << MaxShift || (bytes & (bytes - 1)) != 0)
			return -1;
		int shift = 0;
		while ((1L << shift) < bytes) shift++;
		return shift;
	}

	private static void Trim()
	{
		var now = Environment.TickCount;
		var memoryShort = false;
#if !NETSTANDARD2_1
		var info = GC.GetGCMemoryInfo();
		memoryShort = info.HighMemoryLoadThresholdBytes > 0 && info.MemoryLoadBytes >= info.HighMemoryLoadThresholdBytes;
#endif
		for (int shift = MinShift; shift <= MaxShift; shift++)
		{
			if (Volatile.Read(ref s_blocks[shift]) == 0) continue;
			if (!memoryShort && unchecked(now - Volatile.Read(ref s_returnedAt[shift])) < IdleMilliseconds) continue;
			var block = Interlocked.Exchange(ref s_blocks[shift], 0L);
			if (block != 0)
				Marshal.FreeHGlobal((nint)block);
		}
	}

	private static void StartTrimmer()
	{
		if (Volatile.Read(ref s_trimmerStarted) == 0 && Interlocked.Exchange(ref s_trimmerStarted, 1) == 0)
			_ = new Trimmer();
	}

	/// <summary>
	/// Unreachable from the start and re-registered from its own finalizer: once promoted to gen2 its
	/// finalizer runs after every gen2 collection (the pattern ArrayPool's trimming uses)
	/// </summary>
	private sealed class Trimmer
	{
		~Trimmer()
		{
			if (Environment.HasShutdownStarted)
				return;
			try { Trim(); }
			catch { /* never let a finalizer throw */ }
			GC.ReRegisterForFinalize(this);
		}
	}
}
