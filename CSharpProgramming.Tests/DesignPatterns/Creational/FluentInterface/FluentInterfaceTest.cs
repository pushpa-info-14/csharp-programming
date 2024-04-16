using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.AutoMapperImplementationUsingFluentInterface;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentValidation;
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

            Console.WriteLine("\n---- AutoMapper");
            new AutoMapperProgram().Test();

            Console.WriteLine("\n---- FluentValidation");
            new FluentValidationProgram().Test();
        }
    }
}
