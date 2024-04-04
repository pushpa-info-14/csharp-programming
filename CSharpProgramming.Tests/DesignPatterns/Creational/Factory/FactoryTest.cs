using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.ASimpleSystemToHandleNotifications;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.CloudStorageSystem;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DesigningASystemForABank;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DevelopingAGraphicsEditor;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DiscountsInAnECommerceApplication;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DocumentConversionSystem;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.LoggingSystem;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.PaymentGatewayIntegration;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.ReportGeneration;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.TransportApplication;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.UIThemeSystem;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.With;
using CSharpProgramming.Study.DesignPatterns.Creational.Factory.Without;

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
            Console.WriteLine("\n---- Without Factory");
            new WithoutFactoryProgram().Test();

            Console.WriteLine("\n---- Factory");
            new FactoryProgram().Test();

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
