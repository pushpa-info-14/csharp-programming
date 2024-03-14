using CSharpProgramming.Study.BroCode;

namespace CSharpProgramming.Tests.BroCode
{
    public class Lesson17NumberGuessingGameTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var lesson = new Lesson17NumberGuessingGame();
            lesson.Method1();
        }
    }
}
