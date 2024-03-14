using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q69ImplementTriePrefixTreeLeetcode208Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q69ImplementTriePrefixTreeLeetcode208();

            solution.Insert("apple");
            var answer = solution.Search("apple");
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.True);

            answer = solution.Search("app");
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.False);

            answer = solution.StartsWith("app");
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.True);

            solution.Insert("app");
            answer = solution.Search("app");
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.True);
        }
    }
}
