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
		ReportBuilderProgram.Test();

		Console.WriteLine("\n---- BeverageBuilder");
		BeverageBuilderProgram.Test();

		Console.WriteLine("\n---- ComputerShop");
		ComputerShopProgram.Test();

		Console.WriteLine("\n---- MealCreator");
		MealCreatorProgram.Test();

		Console.WriteLine("\n---- UserProfileBuilder");
		UserProfileBuilderProgram.Test();

		Console.WriteLine("\n---- TravelAgent");
		TravelAgentProgram.Test();

		Console.WriteLine("\n---- ServerDeployment");
		ServerDeploymentProgram.Test();

		Console.WriteLine("\n---- StringBuilder");
		StringBuilderProgram.Test();

		// Console.WriteLine("\n---- HttpRequestMessage");
		// HttpRequestMessageProgram.Test();
	}
}
