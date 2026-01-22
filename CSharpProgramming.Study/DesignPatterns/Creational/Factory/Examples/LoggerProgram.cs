namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples;

public class LoggerProgram
{
	public interface ILogger
	{
		void Log(string message);
	}

	public class ConsoleLogger : ILogger
	{
		public void Log(string message)
		{
			Console.WriteLine("Console: " + message);
		}
	}

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

	public static class LoggerFactory
	{
		public static ILogger CreateLogger(string type)
		{
			switch (type.ToLower())
			{
				case "console":
					return new ConsoleLogger();
				case "file":
					return new FileLogger("log.txt");
				// For simplicity, file path is hard-coded
				// You can extend here with other logger types
				default:
					throw new ArgumentException("Invalid logger type");
			}
		}
	}

	public static void Test()
	{
		var logger = LoggerFactory.CreateLogger("console");
		logger.Log("This is a console log!");

		logger = LoggerFactory.CreateLogger("file");
		logger.Log("This message is written to a file.");

		// The beauty of this approach is that the client code remains unchanged
		// even if we introduce new logger types in the future.
	}
}
