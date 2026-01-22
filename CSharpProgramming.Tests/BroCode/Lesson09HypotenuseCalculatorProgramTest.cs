using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode
{
	public class Lesson09HypotenuseCalculatorProgramTest
	{
		[Fact]
		public void Test1()
		{
			var lesson = new Lesson09HypotenuseCalculatorProgram();

			using var sr = new StringReader("4\n3");
			Console.SetIn(sr);
			lesson.Method1();
		}
	}
}
