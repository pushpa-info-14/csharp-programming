namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O6_Prototype.Examples;

public class ConfigurationTemplates
{
	// Prototype - IConfigurationPrototype Interface
	public interface IConfigurationPrototype
	{
		IConfigurationPrototype Clone();
	}

	// Concrete Prototype - Configuration Class
	public class Configuration : IConfigurationPrototype
	{
		public string DatabaseConnectionString { get; set; }

		public int Timeout { get; set; }

		public bool EnableLogging { get; set; }

		public string ModuleName { get; set; }

		public IConfigurationPrototype Clone()
		{
			return new Configuration
			{
				DatabaseConnectionString = DatabaseConnectionString,
				Timeout = Timeout,
				EnableLogging = EnableLogging,
				// ModuleName can be set separately after cloning
				ModuleName = string.Empty
			};
		}

		public void Display()
		{
			Console.WriteLine($"Configuration for {ModuleName}:");
			Console.WriteLine($"DB Connection: {DatabaseConnectionString} | Timeout: {Timeout}s | Logging: {EnableLogging}\n");
		}
	}

	// Client Code
	public static void Test()
	{
		// Base configuration template prepared by the IT team
		var baseConfig = new Configuration
		{
			DatabaseConnectionString = "Server=myServer;Database=myDB;User Id=myUser;Password=myPass;",
			Timeout = 30,
			EnableLogging = true,
			ModuleName = "Base Configuration"
		};

		Console.WriteLine("Base Configuration:");
		baseConfig.Display();

		// Now, for a specific module called "PaymentProcessing", we want a similar configuration but with a longer timeout
		var paymentConfig = (Configuration)baseConfig.Clone();
		paymentConfig.Timeout = 60;
		paymentConfig.ModuleName = "PaymentProcessing";

		Console.WriteLine("Payment Processing Module Configuration:");
		paymentConfig.Display();
	}
}
