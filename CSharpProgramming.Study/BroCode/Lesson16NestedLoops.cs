namespace CSharpProgramming.Study.BroCode
{
	public class Lesson16NestedLoops
	{
		public void Method1()
		{
			// nested loops - Loops inside of other loops.
			//                Uses vary.
			//                Used a lot in sorting algorithms.

			var i = 0;
			while (i < 10)
			{
				for (var j = 0; j < 10; j++)
				{
					Console.WriteLine(i + " " + j);
				}
				i++;
			}
		}
	}
}
