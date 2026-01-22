namespace CSharpProgramming.Study.DesignPatterns.Creational.Singleton.Examples;

public class SystemInformationGathererProgram
{
	public sealed class SystemInfoGatherer
	{
		// Static instance for Singleton
		private static readonly SystemInfoGatherer Instance = new();

		// Properties representing system information
		public string OsVersion { get; }

		public string MachineName { get; }

		public int ProcessorCount { get; }

		// ... Other system-related properties ...

		// Private constructor to prevent external instantiation and gather system info
		private SystemInfoGatherer()
		{
			OsVersion = Environment.OSVersion.ToString();
			MachineName = Environment.MachineName;
			ProcessorCount = Environment.ProcessorCount;
			// ... Gather other system information ...
		}

		// Public property to access the Singleton instance
		public static SystemInfoGatherer GetInstance()
		{
			return Instance;
		}
	}

	// Client Code
	public static void Test()
	{
		// Access system information from any part of the application
		var os = SystemInfoGatherer.GetInstance().OsVersion;
		Console.WriteLine(os);
	}
}
