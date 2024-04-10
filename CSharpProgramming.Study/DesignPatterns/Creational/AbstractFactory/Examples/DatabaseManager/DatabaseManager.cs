namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.DatabaseManager;

public class DatabaseManager
{
    private readonly ICommand _command;
    private readonly IConnection _connection;

    public DatabaseManager(IDatabaseFactory factory)
    {
        _command = factory.CreateCommand();
        _connection = factory.CreateConnection();
    }

    public void PerformDatabaseOperations(string query)
    {
        _connection.OpenConnection();
        _command.Execute(query);
    }
}