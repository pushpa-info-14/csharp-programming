namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.DatabaseManager;

public class SqlServerConnection : IConnection
{
    public void OpenConnection()
    {
        Console.WriteLine("SQL Server connection opened.");
    }
}