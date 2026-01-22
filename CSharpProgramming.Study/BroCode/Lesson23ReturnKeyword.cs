namespace CSharpProgramming.Study.BroCode
{
	public class Lesson23ReturnKeyword
	{
		public void Method1()
		{
			// return - Returns data back to the place where a method is invoked.

			Console.WriteLine(Multiply(8, 7));
		}

		public double Multiply(double x, double y)
		{
			return x * y;
		}
	}
}
