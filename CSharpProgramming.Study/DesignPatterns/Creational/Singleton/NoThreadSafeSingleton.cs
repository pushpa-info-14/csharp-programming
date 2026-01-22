namespace CSharpProgramming.Study.DesignPatterns.Creational.Singleton;

public class NoThreadSafeSingleton
{
	public sealed class Singleton
	{
		// This variable value will be increment by 1 each time the object of the class is created
		private static int _counter = 0;

		// This variable is going to store the Singleton Instance
		private static Singleton _instance;

		// The following Static Method is going to return the Singleton Instance
		public static Singleton GetInstance()
		{
			// If the variable instance is null, then create the Singleton instance 
			// else return the already created singleton instance
			// This version is not thread safe
			if (_instance == null)
			{
				_instance = new Singleton();
			}

			// Return the Singleton Instance
			return _instance;
		}

		// Constructor is Private means, from outside the class we cannot create an instance of this class
		private Singleton()
		{
			// Each Time the Constructor called, increment the Counter value by 1
			_counter++;
			Console.WriteLine("Counter Value " + _counter.ToString());
		}

		// The following can be accessed from outside of the class by using the Singleton Instance
		public void PrintDetails(string message)
		{
			Console.WriteLine(message);
		}
	}

	public static void Test()
	{
		// Call the GetInstance static method to get the Singleton Instance
		var fromTeacher = Singleton.GetInstance();
		fromTeacher.PrintDetails("From Teacher");

		// Call the GetInstance static method to get the Singleton Instance
		var fromStudent = Singleton.GetInstance();
		fromStudent.PrintDetails("From Student");
	}
}
