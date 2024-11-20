using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.FluentInterface;

public class FluentInterfaceTest
{
    [Fact]
    public void Test1()
    {
        Console.WriteLine("\n---- FluentEmployee");
        new FluentEmployeeProgram().Test();

        Console.WriteLine("\n---- AutoMapper");
        new AutoMapperProgram().Test();

        Console.WriteLine("\n---- FluentValidation");
        new FluentValidationProgram().Test();

        Console.WriteLine("\n---- RestSharp");
        new RestSharpProgram().Test();

        Console.WriteLine("\n---- SqlQueryBuilder");
        new SqlQueryBuilderProgram().Test();

        Console.WriteLine("\n---- HtmlTagBuilder");
        new HtmlTagBuilderProgram().Test();

        Console.WriteLine("\n---- ShoppingCartBuilder");
        new ShoppingCartBuilderProgram().Test();

        Console.WriteLine("\n---- UserProfileBuilder");
        new UserProfileBuilderProgram().Test();

        Console.WriteLine("\n---- GameCharacterBuilder");
        new GameCharacterBuilderProgram().Test();

        Console.WriteLine("\n---- PizzaBuilder");
        new PizzaBuilderProgram().Test();

        Console.WriteLine("\n---- EntityFramework");
        new EntityFrameworkProgram().Test();

        Console.WriteLine("\n---- EmailBuilder");
        new EmailBuilderProgram().Test();
    }
}
