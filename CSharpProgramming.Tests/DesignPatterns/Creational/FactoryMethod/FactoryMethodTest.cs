using CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod;
using CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.FactoryMethod
{
    public class FactoryMethodTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("\n---- CreditCard");
            new CreditCardProgram().Test();

            Console.WriteLine("\n---- NotificationSystem");
            new NotificationSystemProgram().Test();

            Console.WriteLine("\n---- DocumentService");
            new DocumentServiceProgram().Test();

            Console.WriteLine("\n---- AnalyticsService");
            new AnalyticsServiceProgram().Test();

            Console.WriteLine("\n---- ECommercePlatform");
            new PaymentGatewayIntegrationProgram().Test();

            Console.WriteLine("\n---- Transport");
            new TransportProgram().Test();
        }
    }
}
