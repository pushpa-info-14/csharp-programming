using CSharpProgramming.Study.BroCode;

namespace CSharpProgramming.Tests.BroCode
{
    public class Lesson30ClassesTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var lesson = new Lesson30Classes();
            lesson.Method1();
        }
    }
}
