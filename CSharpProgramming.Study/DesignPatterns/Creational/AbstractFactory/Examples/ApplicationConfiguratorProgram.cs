namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples;

public class ApplicationConfiguratorProgram
{
	// Abstract Products
	public interface INotificationService
	{
		void Notify(string message);
	}

	public interface ISettings
	{
		string GetSetting(string key);
	}

	// Concrete Products for Android
	public class AndroidNotificationService : INotificationService
	{
		public void Notify(string message)
		{
			Console.WriteLine($"Android notification: {message}");
		}
	}

	public class AndroidSettings : ISettings
	{
		public string GetSetting(string key)
		{
			return $"Android setting value for {key}";
		}
	}

	// Concrete Products for Ios
	public class IosNotificationService : INotificationService
	{
		public void Notify(string message)
		{
			Console.WriteLine($"Ios notification: {message}");
		}
	}

	public class IosSettings : ISettings
	{
		public string GetSetting(string key)
		{
			return $"Ios setting value for {key}";
		}
	}

	// Abstract Factory
	public interface IPlatformFactory
	{
		INotificationService CreateNotificationService();

		ISettings CreateSettings();
	}

	// Concrete Factories
	public class AndroidFactory : IPlatformFactory
	{
		public INotificationService CreateNotificationService() => new AndroidNotificationService();

		public ISettings CreateSettings() => new AndroidSettings();
	}

	public class IosFactory : IPlatformFactory
	{
		public INotificationService CreateNotificationService() => new IosNotificationService();

		public ISettings CreateSettings() => new IosSettings();
	}

	// Client Code
	public class ApplicationConfigurator
	{
		private readonly INotificationService _notificationService;
		private readonly ISettings _settings;

		public ApplicationConfigurator(IPlatformFactory factory)
		{
			_notificationService = factory.CreateNotificationService();
			_settings = factory.CreateSettings();
		}

		public void RunSampleOperations()
		{
			string usernameSetting = _settings.GetSetting("Username");
			Console.WriteLine($"Retrieved setting: {usernameSetting}");

			_notificationService.Notify("App started!");
		}
	}

	public static void Test()
	{
		IPlatformFactory platformFactory;

		if (Environment.OSVersion.Platform == PlatformID.Unix) // A simplistic way to distinguish, not accurate for all scenarios
		{
			platformFactory = new IosFactory();
		}
		else
		{
			platformFactory = new AndroidFactory();
		}

		var appConfigurator = new ApplicationConfigurator(platformFactory);
		appConfigurator.RunSampleOperations();
	}
}
