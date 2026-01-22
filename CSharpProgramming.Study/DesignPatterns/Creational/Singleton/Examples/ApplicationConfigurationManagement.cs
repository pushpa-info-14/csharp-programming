using System.Text.Json;

namespace CSharpProgramming.Study.DesignPatterns.Creational.Singleton.Examples;

public class ApplicationConfigurationManagement
{
	public sealed class AppConfig
	{
		// Static instance for Singleton
		private static readonly AppConfig Instance = new();

		// Dictionary to hold configuration data
		private Dictionary<string, string> _settings;

		// Private constructor to prevent external instantiation
		private AppConfig()
		{
			LoadConfiguration();
		}

		// Load configuration data from a file (or database, web service, etc.)
		private void LoadConfiguration()
		{
			var configFileContent = File.ReadAllText("sample-appsettings.json");
			_settings = JsonSerializer.Deserialize<Dictionary<string, string>>(configFileContent)!;
		}

		// Public property to access the Singleton instance
		public static AppConfig GetInstance()
		{
			return Instance;
		}

		// Get a specific setting by key
		public string GetSetting(string key)
		{
			_settings.TryGetValue(key, out var value);
			return value;
		}
	}

	// Client Code
	public static void Test()
	{
		var apiEndpoint = AppConfig.GetInstance().GetSetting("ApiEndpoint");
		Console.WriteLine(apiEndpoint);
	}
}
