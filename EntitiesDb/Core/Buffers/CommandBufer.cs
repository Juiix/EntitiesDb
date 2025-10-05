

using EntitiesDb;

public sealed partial class CommandBuffer
{
    private readonly ComponentRegistry _componentRegistry;
    private readonly ArchetypeCollection _archetypes;

    internal CommandBuffer(ComponentRegistry componentRegistry)
    {
        _componentRegistry = componentRegistry;
        _archetypes = new(componentRegistry, 1024);
    }

    
}