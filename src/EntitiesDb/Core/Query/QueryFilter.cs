namespace EntitiesDb;

public readonly struct QueryFilter(Signature all, Signature any, Signature none, QueryFilterMode mode = QueryFilterMode.All)
{
	public readonly Signature All = all;
	public readonly Signature Any = any;
	public readonly Signature None = none;
	public readonly QueryFilterMode Mode = mode;
}
