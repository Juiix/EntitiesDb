using System;
using System.Runtime.CompilerServices;

namespace EntitiesDb;

/// <summary>
/// Entity id -> command buffer entity index. Entity ids are dense, so a paged array beats hashing,
/// and only pages that hold a buffered entity are allocated.
/// </summary>
internal struct EntityIndexMap
{
	private const int PageBits = 10;
	private const int PageSize = 1 << PageBits;
	private const int PageMask = PageSize - 1;

	/// <summary>
	/// Pages of (entity index + 1); 0 means not registered
	/// </summary>
	private int[]?[] _pages;
	private int _pageCount;

	public EntityIndexMap()
	{
		_pages = [];
	}

	/// <summary>
	/// Wiping every allocated page beats removing <paramref name="entryCount"/> entries one by one once the
	/// pages are reasonably full (a page wipe costs about as much as 64 single removes)
	/// </summary>
	public readonly bool ClearIsCheaperThanRemoving(int entryCount) =>
		_pageCount > 0 && (long)entryCount * 16 >= (long)_pageCount * PageSize;

	/// <summary>
	/// Unregisters every entity, keeping the pages
	/// </summary>
	public readonly void Clear()
	{
		foreach (var page in _pages)
		{
			if (page is not null)
				Array.Clear(page, 0, page.Length);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool TryGet(int entityId, out int entityIndex)
	{
		var pages = _pages;
		var pageIndex = entityId >> PageBits;
		if ((uint)pageIndex < (uint)pages.Length)
		{
			var page = pages[pageIndex];
			if (page is not null)
			{
				var value = page[entityId & PageMask];
				if (value != 0)
				{
					entityIndex = value - 1;
					return true;
				}
			}
		}

		entityIndex = -1;
		return false;
	}

	public void Add(int entityId, int entityIndex)
	{
		var pageIndex = entityId >> PageBits;
		if (pageIndex >= _pages.Length)
		{
			var newLength = Math.Max(4, _pages.Length * 2);
			while (newLength <= pageIndex) newLength *= 2;
			Array.Resize(ref _pages, newLength);
		}

		var page = _pages[pageIndex];
		if (page is null)
		{
			_pages[pageIndex] = page = new int[PageSize];
			_pageCount++;
		}
		page[entityId & PageMask] = entityIndex + 1;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly void Remove(int entityId)
	{
		var pageIndex = entityId >> PageBits;
		if ((uint)pageIndex < (uint)_pages.Length && _pages[pageIndex] is { } page)
			page[entityId & PageMask] = 0;
	}
}
