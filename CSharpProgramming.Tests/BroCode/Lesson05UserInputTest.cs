using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode
{
	public class Lesson05UserInputTest
	{
		[Theory]
		[InlineData("Pushpa\n30")]
		[InlineData("Kumara\n35")]
		public void Test1(string input)
		{
			var lesson = new Lesson05UserInput();

			using var sr = new StringReader(input);
			Console.SetIn(sr);
			lesson.Method1();
		}
	}
}
