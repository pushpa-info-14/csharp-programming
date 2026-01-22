namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples;

public class ServerDeploymentProgram
{
	public class ServerConfiguration
	{
		public string OperatingSystem { get; set; }

		public string ServerType { get; set; }  // e.g., Web, Database, Cache

		public string Database { get; set; }    // Optional: Database software

		public List<string> Middleware { get; set; } = new();

		public bool HasFirewall { get; set; }

		public void DisplayConfig()
		{
			Console.WriteLine($"OS: {OperatingSystem}");
			Console.WriteLine($"Server Type: {ServerType}");
			Console.WriteLine($"Database: {Database ?? "None"}");
			Console.WriteLine($"Middleware: {string.Join(", ", Middleware)}");
			Console.WriteLine($"Firewall: {(HasFirewall ? "Enabled" : "Disabled")}");
		}
	}

	public abstract class ServerBuilder
	{
		protected ServerConfiguration Configuration { get; } = new();

		public abstract void SetOperatingSystem();

		public abstract void SetServerType();

		public abstract void InstallDatabase();

		public abstract void InstallMiddleware();

		public abstract void EnableFirewall();

		public ServerConfiguration GetConfiguration() => Configuration;
	}

	public class WebServerBuilder : ServerBuilder
	{
		public override void SetOperatingSystem()
		{
			Configuration.OperatingSystem = "Linux";
		}

		public override void SetServerType()
		{
			Configuration.ServerType = "Web";
		}

		public override void InstallDatabase()
		{
			// For this web server, no DB installation
		}

		public override void InstallMiddleware()
		{
			Configuration.Middleware.Add("Nginx");
			Configuration.Middleware.Add("Node.js");
		}

		public override void EnableFirewall()
		{
			Configuration.HasFirewall = true;
		}
	}

	public class ServerDeployment
	{
		public void Deploy(ServerBuilder builder)
		{
			builder.SetOperatingSystem();
			builder.SetServerType();
			builder.InstallDatabase();
			builder.InstallMiddleware();
			builder.EnableFirewall();
		}
	}

	public static void Test()
	{
		var deployment = new ServerDeployment();
		var webServerBuilder = new WebServerBuilder();

		deployment.Deploy(webServerBuilder);

		var serverConfig = webServerBuilder.GetConfiguration();
		serverConfig.DisplayConfig();
	}
}
