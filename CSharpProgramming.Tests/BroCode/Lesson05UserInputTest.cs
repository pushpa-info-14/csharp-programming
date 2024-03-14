using CSharpProgramming.Study.BroCode;

namespace CSharpProgramming.Tests.BroCode
{
    public class Lesson05UserInputTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var lesson = new Lesson05UserInput();

            using var sr = new StringReader("Pushpa\n30");
            Console.SetIn(sr);
            lesson.Method1();
        }
    }
}
