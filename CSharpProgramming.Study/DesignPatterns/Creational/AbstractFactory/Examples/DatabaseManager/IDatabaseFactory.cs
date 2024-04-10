namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.DatabaseManager;

public interface IDatabaseFactory
{
    ICommand CreateCommand();
    IConnection CreateConnection();
}