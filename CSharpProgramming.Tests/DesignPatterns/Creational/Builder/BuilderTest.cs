using CSharpProgramming.Study.DesignPatterns.Creational.Builder;
using CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.Builder;

public class BuilderTest
{
    [Fact]
    public void Test1()
    {
        Console.WriteLine("\n---- ReportBuilder");
        new ReportBuilderProgram().Test();

        Console.WriteLine("\n---- BeverageBuilder");
        new BeverageBuilderProgram().Test();

        Console.WriteLine("\n---- ComputerShop");
        new ComputerShopProgram().Test();

        Console.WriteLine("\n---- MealCreator");
        new MealCreatorProgram().Test();

        Console.WriteLine("\n---- UserProfileBuilder");
        new UserProfileBuilderProgram().Test();

        Console.WriteLine("\n---- TravelAgent");
        new TravelAgentProgram().Test();

        Console.WriteLine("\n---- ServerDeployment");
        new ServerDeploymentProgram().Test();

        Console.WriteLine("\n---- StringBuilder");
        new StringBuilderProgram().Test();

        // Console.WriteLine("\n---- HttpRequestMessage");
        // new HttpRequestMessageProgram().Test();
    }
}
