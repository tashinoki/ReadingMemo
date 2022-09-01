namespace LegacyCode.FactoryMethod;

internal class LegacySuperClass
{
    private readonly SomeClassAccessServer _someClassAccessServer;
    private readonly SomeClassAccessDatabase _someClassAccessDatabase;

    public LegacySuperClass()
    {
        //_someClassAccessServer = new SomeClassAccessServer();
        //_someClassAccessDatabase = new SomeClassAccessDatabase();

        _someClassAccessServer = CreateServer();
        _someClassAccessDatabase = CreateDatabase();
    }

    protected SomeClassAccessServer CreateServer()
        => new SomeClassAccessServer();

    protected SomeClassAccessDatabase CreateDatabase()
        => new SomeClassAccessDatabase();
}

internal class SomeClassAccessServer
{
    public SomeClassAccessServer()
    {}
}

internal class SomeClassAccessDatabase
{
    public SomeClassAccessDatabase()
    {}
}