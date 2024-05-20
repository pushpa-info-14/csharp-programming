using CSharpProgramming.Study.DesignPatterns.Structural.Decorator;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Adapter
{
    public class DecoratorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("\n---- CarProgram");
            new CarProgram().Test();

            Console.WriteLine("\n---- PizzaProgram");
            new PizzaProgram().Test();
        }
    }
}
