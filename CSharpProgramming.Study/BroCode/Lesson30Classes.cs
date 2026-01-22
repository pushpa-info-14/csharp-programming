namespace CSharpProgramming.Study.BroCode
{
	public class Lesson30Classes
	{
		public void Method1()
		{
			// class - A bundle of related code.
			//         Can be used as a blueprint to create objects (OOP)

			var message = new Message();
			message.Hello();
			message.Waiting();
			message.Bye();
		}

		class Message
		{
			public void Hello()
			{
				Console.WriteLine("Hello! Welcome to the program");
			}

			public void Waiting()
			{
				Console.WriteLine("I am waiting for something");
			}

			public void Bye()
			{
				Console.WriteLine("Bye! Thanks for visiting");
			}
		}
	}
}
