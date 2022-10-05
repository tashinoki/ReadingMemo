namespace ReadingMemo.AdaptiveCode.Liskov.Infrastructure;

internal interface IEntityRepository<out T> where T : Entity
{
    T GetById(Guid id);
}

