using CSharpProgramming.Study.BroCode;

namespace CSharpProgramming.Tests.BroCode
{
    public class Lesson01OutputTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var lesson = new Lesson01Output();
            lesson.Method1();
        }
    }
}
