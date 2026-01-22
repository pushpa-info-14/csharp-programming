namespace CSharpProgramming.Study.BroCode
{
	public class Lesson08RandomNumbers
	{
		public void Method1()
		{
			var random = new Random();
			var num1 = random.Next(1, 7); // 1..6
			var num2 = random.Next(1, 21); // 1..20
			Console.WriteLine(num1);
			Console.WriteLine(num2);

			var num3 = random.NextDouble(); // 0..1
			Console.WriteLine(num3);
		}
	}
}
