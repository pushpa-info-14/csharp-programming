using CSharpProgramming.Study.General;

namespace CSharpProgramming.Tests.General
{
    public class StoringDifferentTypesInAnArrayTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var instance = new StoringDifferentTypesInAnArray();
            instance.Method1();
        }

        [Test]
        public void Test2()
        {
            var instance = new StoringDifferentTypesInAnArray();
            instance.Method2();
        }
    }
}
