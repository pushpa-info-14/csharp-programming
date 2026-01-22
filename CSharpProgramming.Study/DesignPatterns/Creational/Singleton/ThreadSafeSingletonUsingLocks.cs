namespace CSharpProgramming.Study.DesignPatterns.Creational.Singleton;

public class ThreadSafeSingletonUsingLocks
{
	public sealed class Singleton
	{
		// This variable value will be increment by 1 each time the object of the class is created
		private static int _counter = 0;

		// This variable is going to store the Singleton Instance
		private static Singleton _instance;

		//To use the lock, we need to create one variable
		private static readonly object InstanceLock = new();

		// The following Static Method is going to return the Singleton Instance
		public static Singleton GetInstance()
		{
			// This is thread-safe
			// As long as one thread locks the resource, no other thread can access the resource
			// As long as one thread enters into the Critical Section, 
			// no other threads are allowed to enter the critical section
			lock (InstanceLock)
			{
				// Critical Section Start
				if (_instance == null)
				{
					_instance = new Singleton();
				}
				// Critical Section End
			}

			// Once the thread releases the lock, the other thread allows entering into the critical section
			// But only one thread is allowed to enter the critical section
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
