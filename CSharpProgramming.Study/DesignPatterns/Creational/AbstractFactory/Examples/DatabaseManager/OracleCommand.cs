namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.DatabaseManager;

public class OracleCommand : ICommand
{
    public void Execute(string query)
    {
        Console.WriteLine($"Oracle executing command: {query}");
    }
}