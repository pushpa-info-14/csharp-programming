using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q32GraphValidTreeLeetcode261Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q32GraphValidTreeLeetcode261();

            var answer1 = solution.GraphValidTree(5, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 1, 4 } });

            ConsoleLogger.Print(answer1);

            Assert.That(answer1, Is.True);
        }
    }
}
