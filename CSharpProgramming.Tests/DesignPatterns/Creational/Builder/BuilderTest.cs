using CSharpProgramming.Study.DesignPatterns.Creational.Builder.BeverageBuilder;
using CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.BuildingAComplexComputerSystem;
using CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.BuildingASoftwareForARestaurant;
using CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.CreatingAConfigurationForAServerDeployment;
using CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.CreatingComplexProfileObjectsForAUserRegistrationSystem;
using CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.StringBuilder;
using CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.TravelAgencyWhereUsersCanCustomizeHolidayPackages;
using CSharpProgramming.Study.DesignPatterns.Creational.Builder.ReportBuilder;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.Builder
{
    public class BuilderTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
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
}
