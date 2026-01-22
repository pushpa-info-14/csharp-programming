namespace CSharpProgramming.Study.BroCode
{
	public class Lesson15ForLoops
	{
		public void Method1()
		{
			// for loop - Repeats some code a FINITE amount of times

			for (var i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
			}

			for (var i = 9; i >= 0; i--)
			{
				Console.WriteLine(i);
			}
		}
	}
}
