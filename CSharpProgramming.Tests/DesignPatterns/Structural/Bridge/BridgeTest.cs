using CSharpProgramming.Study.DesignPatterns.Structural.Bridge;
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
