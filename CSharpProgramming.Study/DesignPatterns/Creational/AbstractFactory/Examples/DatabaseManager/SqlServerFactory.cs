namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.DatabaseManager;

public class SqlServerFactory : IDatabaseFactory
{
    public ICommand CreateCommand() => new SqlServerCommand();
    public IConnection CreateConnection() => new SqlServerConnection();
}