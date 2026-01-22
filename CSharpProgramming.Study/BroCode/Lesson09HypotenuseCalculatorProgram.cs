namespace CSharpProgramming.Study.BroCode
{
	public class Lesson09HypotenuseCalculatorProgram
	{
		public void Method1()
		{
			Console.WriteLine("Enter side A: ");
			var a = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter side B: ");
			var b = Convert.ToDouble(Console.ReadLine());

			var c = Math.Sqrt((a * a) + (b * b));
			Console.WriteLine("The hypotenuse is: " + c);
		}
	}
}
