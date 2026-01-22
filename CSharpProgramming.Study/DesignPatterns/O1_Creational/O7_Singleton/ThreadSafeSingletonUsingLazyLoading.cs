namespace CSharpProgramming.Study.DesignPatterns.O1_Creational.O7_Singleton;

public class ThreadSafeSingletonUsingLazyLoading
{
	public sealed class Singleton
	{
		// This variable value will be increment by 1 each time the object of the class is created
		private static int _counter = 0;

		// The private static instance ensures lazy initialization.
		private static readonly Lazy<Singleton> Instance = new(() => new Singleton());

		// The following Static Method is going to return the Singleton Instance
		public static Singleton GetInstance()
		{
			return Instance.Value;
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
		Parallel.Invoke(PrintTeacherDetails, PrintStudentDetails);
	}

	private static void PrintTeacherDetails()
	{
		var fromTeacher = Singleton.GetInstance();
		fromTeacher.PrintDetails("From Teacher");
	}

	private static void PrintStudentDetails()
	{
		var fromStudent = Singleton.GetInstance();
		fromStudent.PrintDetails("From Student");
	}
}
