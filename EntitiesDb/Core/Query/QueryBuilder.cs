namespace EntitiesDb;

public sealed partial class QueryBuilder(ArchetypeCollection archetypes, ComponentRegistry componentRegistry)
{
	private readonly ArchetypeCollection _archetypes = archetypes;
	private readonly ComponentRegistry _componentRegistry = componentRegistry;
	private Signature _all;
	private Signature _any;
	private Signature _none;
	private QueryFilterMode _filterMode;

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
		var query = new Query(_archetypes, new QueryFilter(_all, _any, _none, _filterMode));
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
	public QueryBuilder WithAll<T>() where T : struct
	{
		ref readonly var componentType = ref _componentRegistry.GetComponentType<T>();
		_all = Signature.SingleBit(componentType.Id);
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
	public QueryBuilder WithAny<T>() where T : struct
	{
		ref readonly var componentType = ref _componentRegistry.GetComponentType<T>();
		_any = Signature.SingleBit(componentType.Id);
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
	public QueryBuilder WithNone<T>() where T : struct
	{
		ref readonly var componentType = ref _componentRegistry.GetComponentType<T>();
		_none = Signature.SingleBit(componentType.Id);
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
	public QueryBuilder WithOnly<T>() where T : struct
	{
		ref readonly var componentType = ref _componentRegistry.GetComponentType<T>();
		_all = Signature.SingleBit(componentType.Id);
		_any = Signature.Empty;
		_none = Signature.Empty;
		_filterMode = QueryFilterMode.Only;
		return this;
	}
}
