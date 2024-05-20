using CSharpProgramming.Study.DesignPatterns.Structural.Adapter;

namespace CSharpProgramming.Tests.DesignPatterns.Structural.Adapter
{
    public class AdapterTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
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
}
