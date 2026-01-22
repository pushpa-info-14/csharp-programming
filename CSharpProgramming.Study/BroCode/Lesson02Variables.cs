namespace CSharpProgramming.Study.BroCode
{
	public class Lesson02Variables
	{
		public void Method1()
		{
			int x; // declaration
			x = 123; // initialization

			int y = 321; // declaration + initialization

			Console.WriteLine(x);
			Console.WriteLine(y);

			int age = 21; // whole integer
			double weight = 83.5; // decimal number
			bool isAlive = true; // true / false
			char symbol = '@';
			string name = "Bro";

			Console.WriteLine("Hello " + name + "!");
			Console.WriteLine("Your age is " + age);
			Console.WriteLine("Your weight is " + weight + "kg");
			Console.WriteLine("Are you alive ? " + isAlive);
			Console.WriteLine("Your symbol is " + symbol);
		}
	}
}
