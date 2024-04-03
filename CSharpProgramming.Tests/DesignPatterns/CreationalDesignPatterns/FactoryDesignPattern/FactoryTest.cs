using CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.With;
using CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Without;

namespace CSharpProgramming.Tests.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern
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
            var instance = new WithoutFactoryProgram();
            instance.Test();

            var instance2 = new FactoryProgram();
            instance2.Test();
        }
    }
}
