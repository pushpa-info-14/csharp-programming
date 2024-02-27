using CSharpProgramming.Study.UsingStatement;

namespace CSharpProgramming.Tests
{
    public class UnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            UsingStatement.Test1();
            UsingStatement.Test2();
        }
    }
}