using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode;

public class Lesson42InterfacesTest
{
	[Fact]
	public void Test1()
	{
		var lesson = new Lesson42Interfaces();
		lesson.Method1();
	}
}
