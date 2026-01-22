namespace CSharpProgramming.Study.BroCode
{
	public class Lesson21ForeachLoop
	{
		public void Method1()
		{
			// foreach loop - A simpler way to iterate over an array, but it is less flexible.

			string[] cars = { "BMW", "Audi", "Mustang", "Corvette" };

			foreach (var car in cars)
			{
				Console.WriteLine(car);
			}
		}
	}
}
