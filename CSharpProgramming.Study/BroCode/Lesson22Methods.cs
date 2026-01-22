namespace CSharpProgramming.Study.BroCode
{
	public class Lesson22Methods
	{
		public void Method1()
		{
			// method - Performs a section of code, whenever it is called "invoked".
			//          Let's reuse code without writing it multiple times.

			SingHappyBirthday("Pushpa");
		}

		public void SingHappyBirthday(string name)
		{
			Console.WriteLine("Happy birthday to you!");
			Console.WriteLine("Happy birthday to you!");
			Console.WriteLine("Happy birthday dear " + name);
			Console.WriteLine("Happy birthday to you!");
			Console.WriteLine();
		}
	}
}
