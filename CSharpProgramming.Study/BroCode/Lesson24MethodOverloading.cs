namespace CSharpProgramming.Study.BroCode
{
	public class Lesson24MethodOverloading
	{
		public void Method1()
		{
			// method overloading - Methods share name, but different parameters.
			//                      name + parameters = signature
			//                      Methods must have a unique signature

			Console.WriteLine(Multiply(4, 5));
			Console.WriteLine(Multiply(4, 5, 6));
		}

		public double Multiply(double x, double y)
		{
			return x * y;
		}

		public double Multiply(double x, double y, double z)
		{
			return x * y * z;
		}
	}
}
