using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q06MaximumProductSubarrayDynamicProgrammingLeetcode152Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q06MaximumProductSubarrayDynamicProgrammingLeetcode152();

            var answer = solution.MaxSubArray(new[] { 2, 3, -2, 4 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(6));

            answer = solution.MaxSubArray(new[] { -2, 0, -1 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(0));
        }
    }
}
