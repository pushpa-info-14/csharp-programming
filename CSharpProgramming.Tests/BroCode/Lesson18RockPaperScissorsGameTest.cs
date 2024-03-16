using CSharpProgramming.Study.BroCode;

namespace CSharpProgramming.Tests.BroCode
{
    public class Lesson18RockPaperScissorsGameTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("ROCK")]
        [TestCase("ROCK\nY\nPAPER")]
        [TestCase("ROCK\nY\nPAPER\nY\nSCISSORS")]
        [TestCase("ROCK\nY\nPAPER\nY\nSCISSORS\nY\nPAPER")]
        public void Test1(string input)
        {
            var lesson = new Lesson18RockPaperScissorsGame();

            using var sr = new StringReader(input);
            Console.SetIn(sr);

            lesson.Method1();
        }
    }
}
