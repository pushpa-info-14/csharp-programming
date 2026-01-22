using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode
{
	public class Lesson01OutputTest
	{
		[Fact]
		public void Test1()
		{
			var lesson = new Lesson01Output();
			lesson.Method1();
		}
	}
}
