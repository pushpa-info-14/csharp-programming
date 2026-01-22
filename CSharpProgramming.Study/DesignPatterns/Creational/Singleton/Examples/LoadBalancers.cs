namespace CSharpProgramming.Study.DesignPatterns.Creational.Singleton.Examples;

public class LoadBalancers
{
	public sealed class LoadBalancer
	{
		// Static instance for Singleton
		private static readonly Lazy<LoadBalancer> Instance = new(() => new LoadBalancer());
		private readonly List<string> _servers = new();
		private readonly Random _random = new();

		// Private constructor to prevent external instantiation and to initialize server list
		private LoadBalancer()
		{
			// Add some server addresses to the list for this example
			_servers.Add("Server1");
			_servers.Add("Server2");
			_servers.Add("Server3");
			_servers.Add("Server4");
			_servers.Add("Server5");
		}

		// Public method to get next server
		public string GetNextServer()
		{
			var index = _random.Next(_servers.Count);
			return _servers[index];
		}

		// Public property to access the Singleton instance
		public static LoadBalancer GetInstance()
		{
			return Instance.Value;
		}
	}

	// Client Code
	public static void Test()
	{
		// Usage:
		// Get the next server to handle a client request
		for (var i = 1; i < 6; i++)
		{
			var server = LoadBalancer.GetInstance().GetNextServer();
			Console.WriteLine($"Redirecting client to: {server}");
		}
	}
}
