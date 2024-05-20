using CSharpProgramming.Study.DesignPatterns.Structural.Bridge;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Adapter
{
    public class BridgeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("\n---- RemoteControlProgram");
            new RemoteControlProgram().Test();

            Console.WriteLine("\n---- SendMessageProgram");
            new SendMessageProgram().Test();
        }
    }
}
