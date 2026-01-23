using CSharpProgramming.Study.DesignPatterns.O2_Structural.O4_Bridge;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Bridge;

public class BridgeTest
{
	[Fact]
	public void Test1()
	{
		Console.WriteLine("\n---- RemoteControlProgram");
		new RemoteControlProgram().Test();

		Console.WriteLine("\n---- SendMessageProgram");
		new SendMessageProgram().Test();
	}
}
