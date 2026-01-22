using CSharpProgramming.Study.DesignPatterns.Structural.Adapter;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Adapter;

public class AdapterTest
{
	[Fact]
	public void Test1()
	{
		Console.WriteLine("\n---- ObjectAdapterExample");
		new ObjectAdapterExample().Test();

		Console.WriteLine("\n---- ClassAdapterExample");
		new ClassAdapterExample().Test();

		Console.WriteLine("\n---- LanguageTranslatorProgram");
		new LanguageTranslatorProgram().Test();
	}
}
