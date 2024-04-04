namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.LoggingSystem
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Console: " + message);
        }
    }
}
