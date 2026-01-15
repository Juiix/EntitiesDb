namespace EntitiesDb;

internal readonly record struct BufferedEntity(Entity Entity, int SetIndex, int RemoveIndex);