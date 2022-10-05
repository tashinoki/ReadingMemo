namespace ReadingMemo.AdaptiveCode.Liskov;

internal class User: Entity
{
    public string EmailAddress { get; private init; }

    public DateOnly BirthDate { get; private set; }
}
