using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Institution;
using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleFactory;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.AbstractFactory
{
    public class AbstractFactoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("\n---- VehicleFactory");
            new VehicleFactoryProgram().Test();

            Console.WriteLine("\n---- Institution");
            new InstitutionProgram().Test();
        }
    }
}
