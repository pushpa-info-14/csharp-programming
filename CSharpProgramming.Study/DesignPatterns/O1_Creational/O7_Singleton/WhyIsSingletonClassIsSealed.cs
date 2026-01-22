namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O7_Singleton;

public class WhyIsSingletonClassIsSealed
{
	public class Singleton
	{
		// This variable value will be increment by 1 each time the object of the class is created
		private static int _counter = 0;

		// This variable is going to store the Singleton Instance
		private static Singleton _instance = null;

		// The following Static Method is going to return the Singleton Instance
		public static Singleton GetInstance()
		{
			// If the variable instance is null, then create the Singleton instance 
			// else return the already created singleton instance
			// This version is not thread-safe
			if (_instance == null)
			{
				_instance = new Singleton();
			}

			// Return the Singleton Instance
			return _instance;
		}

		// Constructor is Private means, from outside the class we cannot create an instance of this class
		// But within the class, we can create an instance
		private Singleton()
		{
			// Each Time the Constructor is called, increment the Counter value by 1
			_counter++;
			Console.WriteLine("Counter Value " + _counter.ToString());
		}

		// The following can be accessed from outside of the class by using the Singleton Instance
		public void PrintDetails(string message)
		{
			Console.WriteLine(message);
		}

		// Creating Nested Derived Class inheriting from Singleton Class
		public class DerivedSingleton : Singleton
		{
		}
	}

	// Not possible
	//public class DerivedSingleton : Singleton
	//{
	//}

	public static void Test()
	{
		// Call the GetInstance static method to get the Singleton Instance
		var fromTeacher = Singleton.GetInstance();
		fromTeacher.PrintDetails("From Teacher");

		// Call the GetInstance static method to get the Singleton Instance
		var fromStudent = Singleton.GetInstance();
		fromStudent.PrintDetails("From Student");

		// Instantiating singleton from a Derived class. 
		// This violates Singleton Pattern.
		var derivedObj = new Singleton.DerivedSingleton();
		derivedObj.PrintDetails("From Derived");
	}
}
