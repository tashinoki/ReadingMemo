namespace ReadingMemo.AdaptiveCode.Liskov;

internal class User: Entity
{
    public Guid Id { get; init; }

    public string Name { get; private set; }
}
