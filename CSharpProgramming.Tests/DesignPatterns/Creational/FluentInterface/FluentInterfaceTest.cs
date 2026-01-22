using CSharpProgramming.Study.DesignPatterns.O1_Creational.O5_FluentInterface;
using CSharpProgramming.Study.DesignPatterns.O1_Creational.O5_FluentInterface.Examples;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.FluentInterface;

public class FluentInterfaceTest
{
	[Fact]
	public void Test1()
	{
		Console.WriteLine("\n---- FluentEmployee");
		FluentEmployeeProgram.Test();

		Console.WriteLine("\n---- AutoMapper");
		AutoMapperProgram.Test();

		Console.WriteLine("\n---- FluentValidation");
		FluentValidationProgram.Test();

		Console.WriteLine("\n---- RestSharp");
		RestSharpProgram.TestAsync();

		Console.WriteLine("\n---- SqlQueryBuilder");
		SqlQueryBuilderProgram.Test();

		Console.WriteLine("\n---- HtmlTagBuilder");
		HtmlTagBuilderProgram.Test();

		Console.WriteLine("\n---- ShoppingCartBuilder");
		ShoppingCartBuilderProgram.Test();

		Console.WriteLine("\n---- UserProfileBuilder");
		UserProfileBuilderProgram.Test();

		Console.WriteLine("\n---- GameCharacterBuilder");
		GameCharacterBuilderProgram.Test();

		Console.WriteLine("\n---- PizzaBuilder");
		PizzaBuilderProgram.Test();

		Console.WriteLine("\n---- EntityFramework");
		EntityFrameworkProgram.Test();

		Console.WriteLine("\n---- EmailBuilder");
		EmailBuilderProgram.Test();
	}
}
