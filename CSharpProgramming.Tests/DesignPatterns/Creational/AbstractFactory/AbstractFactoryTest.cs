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
		VehicleFactoryProgram.Test();

		Console.WriteLine("\n---- Institution");
		InstitutionProgram.Test();

		Console.WriteLine("\n---- PaymentProcessor");
		PaymentProcessorProgram.Test();

		Console.WriteLine("\n---- CrossPlatformApplication");
		CrossPlatformApplicationProgram.Test();

		Console.WriteLine("\n---- VehicleManufacturingPlant");
		VehicleManufacturingPlantProgram.Test();

		Console.WriteLine("\n---- ApplicationConfigurator");
		ApplicationConfiguratorProgram.Test();

		Console.WriteLine("\n---- FurnitureShop");
		FurnitureShopProgram.Test();

		Console.WriteLine("\n---- DatabaseManager");
		DatabaseManagerProgram.Test();

		Console.WriteLine("\n---- UserInterface");
		UserInterfaceProgram.Test();

		Console.WriteLine("\n---- Ecosystem");
		EcosystemProgram.Test();

		Console.WriteLine("\n---- MediaApplication");
		MediaApplicationProgram.Test();

		Console.WriteLine("\n---- BeverageMaker");
		BeverageMakerProgram.Test();
	}
}
