namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.DatabaseManager;

public class OracleFactory : IDatabaseFactory
{
    public ICommand CreateCommand() => new OracleCommand();
    public IConnection CreateConnection() => new OracleConnection();
}