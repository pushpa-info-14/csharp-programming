using CSharpProgramming.Study.DesignPatterns.O2_Structural.O7_Proxy.O1_VirtualProxy;
using CSharpProgramming.Study.DesignPatterns.O2_Structural.O7_Proxy.O2_RemoteProxy;
using CSharpProgramming.Study.DesignPatterns.O2_Structural.O7_Proxy.O3_ProtectionProxy;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Proxy;

public class ProxyTest
{
	[Fact]
	public void Test1()
	{
		Console.WriteLine("\n---- Virtual Proxy");
		Console.WriteLine("\n---- ImageLoaderProgram");
		ImageLoaderProgram.Test();

		Console.WriteLine("\n---- Remote Proxy");
		Console.WriteLine("\n---- UserServiceProgram");
		UserServiceProgram.Test();
		Console.WriteLine("\n---- WeatherServiceProgram");
		WeatherServiceProgram.Test();
		Console.WriteLine("\n---- BookInventoryProgram");
		BookInventoryProgram.Test();


		Console.WriteLine("\n---- FolderProxyProgram");
		FolderProxyProgram.Test();
	}
}
