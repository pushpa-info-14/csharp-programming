using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q1TwoSumInputArraySortedLeetcode167Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q1TwoSumInputArrayIsSortedLeetcode167();
            ConsoleLogger.Print(solution.TwoSum(new[] { 2, 7, 11, 15 }, 9));
            ConsoleLogger.Print(solution.TwoSum(new[] { 2, 3, 4 }, 6));
        }
    }
}
