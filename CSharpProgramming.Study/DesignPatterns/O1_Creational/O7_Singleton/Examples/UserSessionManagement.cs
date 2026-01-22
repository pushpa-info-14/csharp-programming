namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O7_Singleton.Examples;

public class UserSessionManagement
{
	public sealed class UserSession
	{
		// Static instance for Singleton
		private static readonly UserSession Instance = new();

		// Properties to represent session data
		public string Username { get; private set; }

		public string[] Roles { get; private set; }

		// ... Other session-related properties ...

		// Private constructor to prevent external instantiation
		private UserSession() { }

		// Public method to initialize session
		public void Initialize(string username, string[] roles)
		{
			Username = username;
			Roles = roles;
			// ... Initialization of other properties ...
		}

		// Public method to clear session (e.g., on logout)
		public void Clear()
		{
			Username = null;
			Roles = null;
			// ... Clear other properties ...
		}

		// Public property to access the Singleton instance
		public static UserSession GetInstance()
		{
			return Instance;
		}
	}

	// Client Code
	public static void Test()
	{
		// Initialize the session after a user logs in
		UserSession.GetInstance().Initialize("JohnDoe", new[] { "Admin", "User" });

		// Access session information from anywhere in the app
		var currentUser = UserSession.GetInstance().Username;
		Console.WriteLine(currentUser);

		// Clear the session when a user logs out
		UserSession.GetInstance().Clear();
	}
}
