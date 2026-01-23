using CSharpProgramming.Study.DesignPatterns.O2_Structural.O3_Decorator;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Decorator;

public class DecoratorTest
{
	[Fact]
	public void Test1()
	{
		Console.WriteLine("\n---- CarProgram");
		new CarProgram().Test();

		Console.WriteLine("\n---- PizzaProgram");
		new PizzaProgram().Test();
	}
}
