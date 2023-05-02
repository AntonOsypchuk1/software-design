namespace Singleton;

public sealed class DatabaseRepository
{
    private static readonly Lazy<DatabaseRepository> _instance = new(() => new DatabaseRepository());

    public static DatabaseRepository Instance => _instance.Value;

    private DatabaseRepository() { }
}