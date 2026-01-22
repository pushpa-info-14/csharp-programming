namespace CSharpProgramming.Study.BroCode
{
	public class Lesson04TypeCasting
	{
		public void Method1()
		{
			// Type Casting - Converting a value to a different data type.
			//                Useful when we accept user input (string).
			//                Different data types can do different things.

			double a = 3.14;
			int b = Convert.ToInt32(a);
			Console.WriteLine(a.GetType() + ": " + a);
			Console.WriteLine(b.GetType() + ": " + b);

			int c = 123;
			double d = Convert.ToDouble(c);
			Console.WriteLine(c.GetType() + ": " + c);
			Console.WriteLine(d.GetType() + ": " + d);

			int e = 321;
			string f = Convert.ToString(e);
			Console.WriteLine(e.GetType() + ": " + e);
			Console.WriteLine(f.GetType() + ": " + f);

			string g = "$";
			char h = Convert.ToChar(g);
			Console.WriteLine(g.GetType() + ": " + g);
			Console.WriteLine(h.GetType() + ": " + h);

			string i = "true";
			bool j = Convert.ToBoolean(i);
			Console.WriteLine(i.GetType() + ": " + i);
			Console.WriteLine(j.GetType() + ": " + j);
		}
	}
}
