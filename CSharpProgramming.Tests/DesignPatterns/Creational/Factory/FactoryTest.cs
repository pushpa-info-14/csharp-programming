using CSharpProgramming.Study.DesignPatterns.O1_Creational.O1_Factory;
using CSharpProgramming.Study.DesignPatterns.O1_Creational.O1_Factory.Examples;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.Factory;

public class FactoryTest
{
	[Fact]
	public void Test1()
	{
		Console.WriteLine("\n---- WithoutFactoryProgram");
		WithoutFactoryProgram.Test();

		Console.WriteLine("\n---- WithFactoryProgram");
		WithFactoryProgram.Test();

		Console.WriteLine("\n---- Payment Gateway");
		PaymentGatewayProgram.Test();

		Console.WriteLine("\n---- Document Converter");
		DocumentConverterProgram.Test();

		Console.WriteLine("\n---- Logger");
		LoggerProgram.Test();

		Console.WriteLine("\n---- Notification");
		NotificationProgram.Test();

		Console.WriteLine("\n---- Discount");
		DiscountProgram.Test();

		Console.WriteLine("\n---- Transport");
		TransportProgram.Test();

		Console.WriteLine("\n---- Shape");
		ShapeProgram.Test();

		Console.WriteLine("\n---- Account");
		AccountProgram.Test();

		Console.WriteLine("\n---- Report");
		ReportProgram.Test();

		Console.WriteLine("\n---- StorageProvider");
		StorageProviderProgram.Test();

		Console.WriteLine("\n---- Theme");
		ThemeProgram.Test();
	}
}
