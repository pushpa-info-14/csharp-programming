namespace CSharpProgramming.Study.BroCode
{
	public class Lesson13LogicalOperators
	{
		public void Method1()
		{
			// logical operators - Can be used to check if more than 1 condition is true/false

			// && (AND)
			// || (OR)

			var temp = 50;

			if (temp >= 10 && temp <= 25)
			{
				Console.WriteLine("It is warm outside!");
			}
			else if (temp <= -50 || temp >= 50)
			{
				Console.WriteLine("Do not go outside!");
			}
		}
	}
}
