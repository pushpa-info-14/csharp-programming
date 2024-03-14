using CSharpProgramming.Study.BroCode;

namespace CSharpProgramming.Tests.BroCode
{
    public class Lesson48GenericsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var lesson = new Lesson48Generics();
            lesson.Method1();
        }
    }
}
