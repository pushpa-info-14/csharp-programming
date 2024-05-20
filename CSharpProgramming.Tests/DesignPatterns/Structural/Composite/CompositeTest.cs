using CSharpProgramming.Study.DesignPatterns.Structural.Composite;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Composite
{
    public class CompositeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
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
}
