using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode;

public class Lesson11IfStatementsTest
{
	[Fact]
	public void Test1()
	{
		var lesson = new Lesson11IfStatements();

		using var sr = new StringReader("30");
		Console.SetIn(sr);
		lesson.Method1();
	}
}
