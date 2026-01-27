using System.Threading;

namespace EntitiesDb;

public sealed partial class QueryBuilder
{
	private readonly ArchetypeCollection _archetypes;
	private readonly ParallelJobRunner? _parallelRunner;
	private readonly int[] _globalChangeVersions;
	private int _changeFilterId = -1;
	private Signature _all;
	private Signature _any;
	private Signature _none;
	private QueryFilterMode _filterMode;

	internal QueryBuilder(ArchetypeCollection archetypes, ParallelJobRunner? parallelRunner, int[] globalChangeVersions)
	{
		_archetypes = archetypes;
		_parallelRunner = parallelRunner;
		_globalChangeVersions = globalChangeVersions;
	}

	/// <summary>
	/// Clears the current filters and disables ONLY filter
	/// </summary>
	public void Clear()
	{
		_all = default;
		_any = default;
		_none = default;
		_filterMode = QueryFilterMode.All;
	}

	/// <summary>
	/// Builds a <see cref="Query"/> instance based on the previous filter calls.
	/// </summary>
	/// <remarks>
	/// <see cref="Clear"/> is automatically called after building the <see cref="Query"/>
	/// </remarks>
	/// <returns>The built <see cref="Query"/></returns>
	public Query Build()
	{
		var changeVersion = _changeFilterId >= 0 ? Volatile.Read(ref _globalChangeVersions[_changeFilterId]) : -1;
		var changeFilter = _changeFilterId >= 0 ? new ChangeFilter(_changeFilterId, changeVersion) : null;
		var query = new Query(_archetypes, _parallelRunner, new QueryFilter(_all, _any, _none, _filterMode), changeFilter);
		Clear();
		return query;
	}

	/// <summary>
	/// The resulting entities must contain ALL of these components.
	/// </summary>
	/// <remarks>
	/// Overwrites previous ALL filters and disables ONLY filter
	/// </remarks>
	/// <returns>The <see cref="QueryBuilder"/> instance</returns>
	public QueryBuilder WithAll<T>()
	{
		var id = Component<T>.Id;
		_all = Signature.SingleBit(id);
		_filterMode = QueryFilterMode.All;
		return this;
	}

	/// <summary>
	/// The resulting entities must contain ANY of these components.
	/// </summary>
	/// <remarks>
	/// Overwrites previous ANY filters and disables ONLY filter
	/// </remarks>
	/// <returns>The <see cref="QueryBuilder"/> instance</returns>
	public QueryBuilder WithAny<T>()
	{
		var id = Component<T>.Id;
		_any = Signature.SingleBit(id);
		_filterMode = QueryFilterMode.All;
		return this;
	}

	/// <summary>
	/// The resulting entities must contain NONE of these components.
	/// </summary>
	/// <remarks>
	/// Overwrites previous NONE filters and disables ONLY filter
	/// </remarks>
	/// <returns>The <see cref="QueryBuilder"/> instance</returns>
	public QueryBuilder WithNone<T>()
	{
		var id = Component<T>.Id;
		_none = Signature.SingleBit(id);
		_filterMode = QueryFilterMode.All;
		return this;
	}

	/// <summary>
	/// The resulting entities must contain ONLY these components.
	/// </summary>
	/// <remarks>
	/// Overwrites previous ONLY filters and disables ALL / ANY / NONE filters
	/// </remarks>
	/// <returns>The <see cref="QueryBuilder"/> instance</returns>
	public QueryBuilder WithOnly<T>()
	{
		var id = Component<T>.Id;
		_all = Signature.SingleBit(id);
		_any = Signature.Empty;
		_none = Signature.Empty;
		_filterMode = QueryFilterMode.Only;
		return this;
	}

	/// <summary>
	/// The resulting entities MAY have changed on component <typeparamref name="T"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <returns></returns>
	public QueryBuilder WithChangeFilter<T>()
	{
		var id = Component<T>.Id;
		_changeFilterId = id;
		return this;
	}
}
