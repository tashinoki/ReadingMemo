namespace ReadingMemo.AdaptiveCode.Liskov.Infrastructure;

internal class UserRepository: IEntityRepository<User>
{
    public User GetById(Guid id)
    {
        return  new User();
    }
}

