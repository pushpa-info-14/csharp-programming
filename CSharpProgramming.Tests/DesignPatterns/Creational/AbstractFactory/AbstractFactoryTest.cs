using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory;
using CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.AbstractFactory;

public class AbstractFactoryTest
{
    [Fact]
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

        Console.WriteLine("\n---- Ecosystem");
        new EcosystemProgram().Test();

        Console.WriteLine("\n---- MediaApplication");
        new MediaApplicationProgram().Test();

        Console.WriteLine("\n---- BeverageMaker");
        new BeverageMakerProgram().Test();
    }
}
