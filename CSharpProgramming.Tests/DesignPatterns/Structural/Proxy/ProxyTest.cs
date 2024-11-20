using CSharpProgramming.Study.DesignPatterns.Structural.Proxy;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Proxy;

public class ProxyTest
{
    [Fact]
    public void Test1()
    {
        Console.WriteLine("\n---- ProtectionProxyFolderProxyProgram");
        new ProtectionProxyFolderProxyProgram().Test();
    }
}
