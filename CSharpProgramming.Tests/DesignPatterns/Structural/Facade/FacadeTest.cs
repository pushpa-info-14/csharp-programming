using CSharpProgramming.Study.DesignPatterns.Structural.Facade;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Adapter
{
    public class FacadeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
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
}
