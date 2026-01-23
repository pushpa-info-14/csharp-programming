using CSharpProgramming.Study.DesignPatterns.O2_Structural.O2_Facade;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Facade;

public class FacadeTest
{
	[Fact]
	public void Test1()
	{
		Console.WriteLine("\n---- OrderExample");
		new OrderExample().Test();

		Console.WriteLine("\n---- WithoutExample");
		new WithoutExample().Test();

		Console.WriteLine("\n---- WithExample");
		new WithExample().Test();
	}
}
