namespace CSharpProgramming.Study.BroCode
{
	public class Lesson20Arrays
	{
		public void Method1()
		{
			// array - A variable that can store multiple values.
			//         Fixed size.


			string[] cars = { "BMW", "Audi", "Mustang", "Corvette" };

			Console.WriteLine(cars[0]);

			cars[0] = "Tesla";
			Console.WriteLine(cars[0]);

			foreach (var car in cars)
			{
				Console.WriteLine(car);
			}
		}
	}
}
