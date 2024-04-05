using CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.CreditCard;
using CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.DocumentFormatConverter;
using CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.LogisticApplication;
using CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.NotificationSystem;
using CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.PaymentGatewayIntegration;
using CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.ReportGenerator;

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
            new ECommercePlatformProgram().Test();

            Console.WriteLine("\n---- Transport");
            new TransportProgram().Test();
        }
    }
}
