using CSharpProgramming.Study.BroCode;

namespace CSharpProgramming.Tests.BroCode
{
    public class Lesson24MethodOverloadingTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var lesson = new Lesson24MethodOverloading();
            lesson.Method1();
        }
    }
}
