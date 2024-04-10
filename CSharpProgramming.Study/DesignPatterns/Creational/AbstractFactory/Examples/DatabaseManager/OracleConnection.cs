namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.DatabaseManager;

public class OracleConnection : IConnection
{
    public void OpenConnection()
    {
        Console.WriteLine("Oracle connection opened.");
    }
}