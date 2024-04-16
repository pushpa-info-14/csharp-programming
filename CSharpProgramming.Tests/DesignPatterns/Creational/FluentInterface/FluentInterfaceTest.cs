using CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.CreatingComplexProfileObjectsForAUserRegistrationSystem;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.AutoMapperImplementationUsingFluentInterface;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.EntityFrameworkCodeFirstModelPropertiesConfiguration;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentEmailBuilder;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentGameCharacterBuilder;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentHtmlTagBuilder;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentPizzaBuilder;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentShoppingCartBuilder;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentSqlQueryBuilder;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentValidation;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.RestSharpForApiRequests;
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
}
