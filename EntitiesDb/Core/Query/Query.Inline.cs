namespace EntitiesDb;

public partial class Query
{
	/// <summary>
	/// Executes an inline ForEach query
	/// </summary>
	public void Inline<T>(ref T forEach)
		where T : IForEach
	{
		foreach (var archetype in GetArchetypeIterator())
		{
			foreach (ref readonly var chunk in archetype)
			{
				foreach (var _ in chunk)
				{
					forEach.ForEach();
				}
			}
		}
	}

	/// <summary>
	/// Executes an inline ForEach query
	/// </summary>
	public void Inline<T, T0>(ref T forEach)
		where T : IForEach<T0>
	{
		var id = _componentRegistry.GetId<T0>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offset = archetype.GetOffset(id);
			foreach (ref readonly var chunk in archetype)
			{
				var handle = chunk.GetHandle(offset);
				foreach (var index in chunk)
				{
					forEach.ForEach(ref handle[index]);
				}
			}
		}
	}

	/// <summary>
	/// Executes an inline ForEach query
	/// </summary>
	public void InlineBuffer<T, T0>(ref T forEach)
		where T : IForEachBuffer<T0>
		where T0 : unmanaged
	{
		var id = _componentRegistry.GetId<T0>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offset = archetype.GetOffset(id);
			foreach (ref readonly var chunk in archetype)
			{
				var handle = chunk.GetBufferHandle(offset);
				foreach (var index in chunk)
				{
					forEach.ForEach(handle[index]);
				}
			}
		}
	}

	/// <summary>
	/// Executes an inline ForEach query with Entity
	/// </summary>
	public void InlineEntity<T>(ref T forEach)
		where T : IForEachEntity
	{
		foreach (var archetype in GetArchetypeIterator())
		{
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				foreach (var index in chunk)
				{
					forEach.ForEach(entities[index]);
				}
			}
		}
	}

	/// <summary>
	/// Executes an inline ForEach query with Entity
	/// </summary>
	public void InlineEntity<T, T0>(ref T forEach)
		where T : IForEachEntity<T0>
	{
		var id = _componentRegistry.GetId<T0>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offset = archetype.GetOffset(id);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var handle = chunk.GetHandle(offset);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						ref handle[index]
					);
				}
			}
		}
	}

	/// <summary>
	/// Executes an inline ForEach query with Entity
	/// </summary>
	public void InlineEntityBuffer<T, T0>(ref T forEach)
		where T : IForEachEntityBuffer<T0>
		where T0 : unmanaged
	{
		var id = _componentRegistry.GetId<T0>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offset = archetype.GetOffset(id);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var handle = chunk.GetBufferHandle(offset);
				foreach (var index in chunk)
				{
					forEach.ForEach(
						entities[index],
						handle[index]
					);
				}
			}
		}
	}

	/// <summary>
	/// Executes an inline ForEach chunk query
	/// </summary>
	public void InlineChunk<T>(ref T forEach)
		where T : IForEachChunk
	{
		foreach (var archetype in GetArchetypeIterator())
		{
			foreach (ref readonly var chunk in archetype)
			{
				forEach.ForEach(
					chunk.EntityCount
				);
			}
		}
	}

	/// <summary>
	/// Executes an inline ForEach chunk query
	/// </summary>
	public void InlineChunk<T, T0>(ref T forEach)
		where T : IForEachChunk<T0>
	{
		var id = _componentRegistry.GetId<T0>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offset = archetype.GetOffset(id);
			foreach (ref readonly var chunk in archetype)
			{
				var handle = chunk.GetHandle(offset);
				forEach.ForEach(
					chunk.EntityCount,
					handle
				);
			}
		}
	}

	/// <summary>
	/// Executes an inline ForEach chunk query
	/// </summary>
	public void InlineChunkBuffer<T, T0>(ref T forEach)
		where T : IForEachChunkBuffer<T0>
		where T0 : unmanaged
	{
		var id = _componentRegistry.GetId<T0>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offset = archetype.GetOffset(id);
			foreach (ref readonly var chunk in archetype)
			{
				var handle = chunk.GetBufferHandle(offset);
				forEach.ForEach(
					chunk.EntityCount,
					handle
				);
			}
		}
	}

	/// <summary>
	/// Executes an inline ForEach chunk query
	/// </summary>
	public void InlineChunkEntity<T>(ref T forEach)
		where T : IForEachChunkEntity
	{
		foreach (var archetype in GetArchetypeIterator())
		{
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				forEach.ForEach(
					chunk.EntityCount,
					entities
				);
			}
		}
	}

	/// <summary>
	/// Executes an inline ForEach chunk query
	/// </summary>
	public void InlineChunkEntity<T, T0>(ref T forEach)
		where T : IForEachChunkEntity<T0>
	{
		var id = _componentRegistry.GetId<T0>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offset = archetype.GetOffset(id);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var handle = chunk.GetHandle(offset);
				forEach.ForEach(
					chunk.EntityCount,
					entities,
					handle
				);
			}
		}
	}

	/// <summary>
	/// Executes an inline ForEach chunk query
	/// </summary>
	public void InlineChunkEntityBuffer<T, T0>(ref T forEach)
		where T : IForEachChunkEntityBuffer<T0>
		where T0 : unmanaged
	{
		var id = _componentRegistry.GetId<T0>();
		foreach (var archetype in GetArchetypeIterator())
		{
			var offset = archetype.GetOffset(id);
			foreach (ref readonly var chunk in archetype)
			{
				var entities = chunk.GetEntityHandle();
				var handle = chunk.GetBufferHandle(offset);
				forEach.ForEach(
					chunk.EntityCount,
					entities,
					handle
				);
			}
		}
	}

	/// <summary>
	/// Executes an inline ForEach chunk query
	/// </summary>
	public void InlineChunkJob<T>(ref T forEach)
		where T : IChunkJob
	{
		foreach (var archetype in GetArchetypeIterator())
		{
			forEach.Enter(archetype);
			foreach (ref readonly var chunk in archetype)
			{
				forEach.ForEach(in chunk);
			}
		}
	}
}
