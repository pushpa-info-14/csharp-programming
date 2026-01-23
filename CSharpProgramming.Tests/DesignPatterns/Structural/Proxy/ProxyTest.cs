using CSharpProgramming.Study.DesignPatterns.O2_Structural.O7_Proxy.O3_ProtectionProxy;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Proxy;

public class ProxyTest
{
	[Fact]
	public void Test1()
	{
		Console.WriteLine("\n---- FolderProxyProgram");
		new FolderProxyProgram().Test();
	}
}
