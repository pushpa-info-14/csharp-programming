namespace CSharpProgramming.Study.BroCode
{
	public class Lesson49MultiThreading
	{
		public void Method1()
		{
			// Thread - An execution path of a program
			//          We can use multiple threads to perform
			//          different tasks of our program at the same time.
			//          Current thread running is "main" thread.
			//          using System.Threading;

			var mainThread = Thread.CurrentThread;
			mainThread.Name = "Main Thread";
			Console.WriteLine(mainThread.Name);

			//CountDown();
			//CountUp();

			//Console.WriteLine(mainThread.Name + " is complete!");

			var thread1 = new Thread(() => CountDown("Timer #1"));
			var thread2 = new Thread(CountUp);
			thread1.Start();
			thread2.Start();
		}

		private void CountDown(string name)
		{
			for (var i = 10; i >= 0; i--)
			{
				Console.WriteLine($"{name}: {i} seconds");
				Thread.Sleep(1000);
			}

			Console.WriteLine($"{name} is complete!");
		}

		private void CountUp()
		{
			for (var i = 0; i <= 10; i++)
			{
				Console.WriteLine($"Timer #2: {i} seconds");
				Thread.Sleep(1000);
			}

			Console.WriteLine("Timer #2 is complete!");
		}
	}
}
