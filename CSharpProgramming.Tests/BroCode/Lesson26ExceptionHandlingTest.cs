using CSharpProgramming.Study.BroCode;

namespace CSharpProgramming.Tests.BroCode
{
    public class Lesson26ExceptionHandlingTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("4\n5\n")]
        [TestCase("4\n0\n")]
        [TestCase("4\npizza\n")]
        public void Test1(string input)
        {
            var lesson = new Lesson26ExceptionHandling();

            using var sr = new StringReader(input);
            Console.SetIn(sr);

            lesson.Method1();
        }
    }
}
