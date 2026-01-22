using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode;

public class Lesson39MethodOverridingTest
{
	[Fact]
	public void Test1()
	{
		var lesson = new Lesson39MethodOverriding();
		lesson.Method1();
	}
}
