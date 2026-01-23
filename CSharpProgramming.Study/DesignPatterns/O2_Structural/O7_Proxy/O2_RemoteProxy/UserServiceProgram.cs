namespace CSharpProgramming.Study.DesignPatterns.O2_Structural.O7_Proxy.O2_RemoteProxy;

public class UserServiceProgram
{
	public interface IUserService
	{
		string GetUserName(int userId);
	}

	public class RealUserService : IUserService
	{
		public string GetUserName(int userId)
		{
			// In a real-world scenario, this might pull data from a database.
			return $"User_{userId}";
		}
	}

	public class RemoteUserServiceProxy : IUserService
	{
		public string GetUserName(int userId)
		{
			// Simulate a remote call to the real service
			return RemoteMethodCall(userId);
		}

		private static string RemoteMethodCall(int userId)
		{
			// In a real-world scenario, this would involve networking code
			// that communicates with the remote service.
			// For simplicity, we'll simulate a remote call here.
			var remoteService = new RealUserService();
			return remoteService.GetUserName(userId);
		}
	}

	public static void Test()
	{
		var userService = new RemoteUserServiceProxy();
		var userName = userService.GetUserName(1);
		Console.WriteLine($"Received username: {userName}");
	}
}
