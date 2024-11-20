using CSharpProgramming.Study.DesignPatterns.Structural.Flyweight;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Flyweight;

public class FlyweightTest
{
    [Fact]
    public void Test1()
    {
        Console.WriteLine("\n---- ShapeProgram");
        new ShapeProgram().Test();

        Console.WriteLine("\n---- ForestSimulationProgram");
        new ForestSimulationProgram().Test();

        Console.WriteLine("\n---- CoffeeShopProgram");
        new CoffeeShopProgram().Test();

        Console.WriteLine("\n---- CADProgram");
        new CADProgram().Test();

        Console.WriteLine("\n---- VehicleLicensePlateManagementSystemProgram");
        new VehicleLicensePlateManagementSystemProgram().Test();

        Console.WriteLine("\n---- TextEditorProgram");
        new TextEditorProgram().Test();
    }
}
