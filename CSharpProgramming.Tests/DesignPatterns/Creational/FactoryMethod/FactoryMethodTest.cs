using CSharpProgramming.Study.DesignPatterns.O1_Creational.O2_FactoryMethod;
using CSharpProgramming.Study.DesignPatterns.O1_Creational.O2_FactoryMethod.Examples;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.FactoryMethod;

public class FactoryMethodTest
{
	[Fact]
	public void Test1()
	{
		Console.WriteLine("\n---- CreditCard");
		CreditCardProgram.Test();

		Console.WriteLine("\n---- NotificationSystem");
		NotificationSystemProgram.Test();

		Console.WriteLine("\n---- DocumentService");
		DocumentServiceProgram.Test();

		Console.WriteLine("\n---- AnalyticsService");
		AnalyticsServiceProgram.Test();

		Console.WriteLine("\n---- ECommercePlatform");
		PaymentGatewayIntegrationProgram.Test();

		Console.WriteLine("\n---- Transport");
		TransportProgram.Test();
	}
}
