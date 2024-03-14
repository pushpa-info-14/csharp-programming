using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q71WordSearch2BacktrackingTrieLeetcode212Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q71WordSearch2BacktrackingTrieLeetcode212();

            var answer = solution.FindWords(new[]
            {
                new[] { 'o', 'a', 'a', 'n' },
                new[] { 'e', 't', 'a', 'e' },
                new[] { 'i', 'h', 'k', 'r' },
                new[] { 'i', 'f', 'l', 'v' }
            }, new[] { "oath", "pea", "eat", "rain" });

            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(new[] { "oath", "eat" }));

            answer = solution.FindWords(new[]
            {
                new[] { 'o', 'a', 'b', 'n' },
                new[] { 'o', 't', 'a', 'e' },
                new[] { 'a', 'h', 'k', 'r' },
                new[] { 'a', 'f', 'l', 'v' }
            }, new[] { "oa", "oaa" });

            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(new[] { "oa", "oaa" }));
        }
    }
}
