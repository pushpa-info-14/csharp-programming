namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.DatabaseManager;

public class SqlServerCommand : ICommand
{
    public void Execute(string query)
    {
        Console.WriteLine($"SQL Server executing command: {query}");
    }
}