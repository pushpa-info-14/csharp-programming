using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.FluentEmployee;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.FluentInterface
{
    public class FluentInterfaceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("\n---- FluentEmployee");
            new FluentEmployeeProgram().Test();
        }
    }
}
