using CSharpProgramming.Study.BroCode;

namespace CSharpProgramming.Tests.BroCode
{
    public class Lesson05UserInputTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Pushpa\n30")]
        [TestCase("Kumara\n35")]
        public void Test1(string input)
        {
            var lesson = new Lesson05UserInput();

            using var sr = new StringReader(input);
            Console.SetIn(sr);
            lesson.Method1();
        }
    }
}
