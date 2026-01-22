using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode;

public class Lesson48GenericsTest
{
	[Fact]
	public void Test1()
	{
		var lesson = new Lesson48Generics();
		lesson.Method1();
	}
}
