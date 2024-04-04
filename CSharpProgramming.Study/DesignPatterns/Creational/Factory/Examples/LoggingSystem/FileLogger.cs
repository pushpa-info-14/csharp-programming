namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.LoggingSystem
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            File.AppendAllText(_filePath, "File: " + message + Environment.NewLine);
        }
    }
}
