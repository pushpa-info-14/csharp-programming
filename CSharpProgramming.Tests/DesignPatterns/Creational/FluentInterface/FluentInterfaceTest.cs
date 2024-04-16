using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.AutoMapperImplementationUsingFluentInterface;
using CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentHtmlTagBuilder;
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
        }
    }
}
