using CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.PaymentGatewayIntegration;
using CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.With;
using CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Without;

namespace CSharpProgramming.Tests.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern
{
    public class FactoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            new WithoutFactoryProgram().Test();
            new FactoryProgram().Test();
            new PaymentGatewayIntegrationProgram().Test();
        }
    }
}
