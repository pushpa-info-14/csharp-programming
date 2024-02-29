using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q72TopKFrequentElementsBucketSortLeetcode347Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q72TopKFrequentElementsBucketSortLeetcode347();

            var answer = solution.TopKFrequent(new[] { 1, 1, 1, 2, 2, 3 }, 2);
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(new[] { 1, 2 }));

            answer = solution.TopKFrequent(new[] { 1 }, 1);
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(new[] { 1 }));

            answer = solution.TopKFrequent(new[] { -1, -1 }, 1);
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(new[] { -1 }));
        }
    }
}
