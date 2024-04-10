using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformApplicationConfiguration;
using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.CrossPlatformUIDevelopment;
using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.DatabaseManager;
using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.FurnitureShop;
using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.MultiDeviceUserInterface;
using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.PaymentGatewaysInECommerce;
using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.VehicleManufacturingCompany;
using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Institution;
using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.VehicleFactory;

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

            Console.WriteLine("\n---- PaymentProcessor");
            new PaymentProcessorProgram().Test();

            Console.WriteLine("\n---- CrossPlatformApplication");
            new CrossPlatformApplicationProgram().Test();

            Console.WriteLine("\n---- VehicleManufacturingPlant");
            new VehicleManufacturingPlantProgram().Test();

            Console.WriteLine("\n---- ApplicationConfigurator");
            new ApplicationConfiguratorProgram().Test();

            Console.WriteLine("\n---- FurnitureShop");
            new FurnitureShopProgram().Test();

            Console.WriteLine("\n---- DatabaseManager");
            new DatabaseManagerProgram().Test();

            Console.WriteLine("\n---- UserInterface");
            new UserInterfaceProgram().Test();
        }
    }
}
