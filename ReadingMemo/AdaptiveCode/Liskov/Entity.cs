namespace ReadingMemo.AdaptiveCode.Liskov;

internal class Entity
{
    public Guid Id { get; init; }

    public string Name { get; private set; }
}
