using CSharpProgramming.Study.DesignPatterns.Creational.Factory;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.Factory
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
            Console.WriteLine("\n---- WithoutFactoryProgram");
            new WithoutFactoryProgram().Test();

            Console.WriteLine("\n---- WithFactoryProgram");
            new WithFactoryProgram().Test();

            Console.WriteLine("\n---- Payment Gateway");
            new PaymentGatewayProgram().Test();

            Console.WriteLine("\n---- Document Converter");
            new DocumentConverterProgram().Test();

            Console.WriteLine("\n---- Logger");
            new LoggerProgram().Test();

            Console.WriteLine("\n---- Notification");
            new NotificationProgram().Test();

            Console.WriteLine("\n---- Discount");
            new DiscountProgram().Test();

            Console.WriteLine("\n---- Transport");
            new TransportProgram().Test();

            Console.WriteLine("\n---- Shape");
            new ShapeProgram().Test();

            Console.WriteLine("\n---- Account");
            new AccountProgram().Test();

            Console.WriteLine("\n---- Report");
            new ReportProgram().Test();

            Console.WriteLine("\n---- StorageProvider");
            new StorageProviderProgram().Test();

            Console.WriteLine("\n---- Theme");
            new ThemeProgram().Test();
        }
    }
}
