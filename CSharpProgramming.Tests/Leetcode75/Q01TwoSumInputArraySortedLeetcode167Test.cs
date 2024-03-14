using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q01TwoSumInputArraySortedLeetcode167Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q01TwoSumInputArrayIsSortedLeetcode167();

            var answer1 = solution.TwoSum(new[] { 2, 7, 11, 15 }, 9);
            var answer2 = solution.TwoSum(new[] { 2, 3, 4 }, 6);

            ConsoleLogger.Print(answer1);
            ConsoleLogger.Print(answer2);

            Assert.Multiple(() =>
            {
                Assert.That(answer1, Is.EqualTo(new[] { 1, 2 }));
                Assert.That(answer2, Is.EqualTo(new[] { 1, 3 }));
            });
        }
    }
}
