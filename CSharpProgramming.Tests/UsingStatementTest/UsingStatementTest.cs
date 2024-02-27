using CSharpProgramming.Study.UsingStatement;

namespace CSharpProgramming.Tests.UsingStatementTest
{
    public class UsingStatementTest
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