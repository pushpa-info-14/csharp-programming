using CSharpProgramming.Study.DesignPatterns.Creational.Prototype;
using CSharpProgramming.Study.DesignPatterns.Creational.Prototype.Employee;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.Prototype
{
    public class PrototypeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("\n---- Example1");
            new Example1().Test();

            Console.WriteLine("\n---- Example2");
            new Example2().Test();

            Console.WriteLine("\n---- Employee");
            new EmployeeProgram().Test();
        }
    }
}
