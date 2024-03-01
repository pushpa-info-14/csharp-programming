using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q03ContainsDuplicateHashSetLeetcode217Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q03ContainsDuplicateHashSetLeetcode217();

            var answer = solution.ContainsDuplicate(new[] { 1, 2, 3, 1 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.True);

            answer = solution.ContainsDuplicate(new[] { 1, 2, 3, 4 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.False);

            answer = solution.ContainsDuplicate(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.True);
        }
    }
}
