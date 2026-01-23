using CSharpProgramming.Study.DesignPatterns.O2_Structural.O5_Composite;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Composite;

public class CompositeTest
{
	[Fact]
	public void Test1()
	{
		Console.WriteLine("\n---- ComputerProgram");
		new ComputerProgram().Test();

		Console.WriteLine("\n---- FileSystemProgram");
		new FileSystemProgram().Test();

		Console.WriteLine("\n---- CompanyProgram");
		new CompanyProgram().Test();
	}
}
