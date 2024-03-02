using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q07FindMinimumInRotatedSortedArrayBinarySearchLeetcode153Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q07FindMinimumInRotatedSortedArrayBinarySearchLeetcode153();

            var answer = solution.FindMin(new[] { 3, 4, 5, 1, 2 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(1));

            answer = solution.FindMin(new[] { 4, 5, 6, 7, 0, 1, 2 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(0));

            answer = solution.FindMin(new[] { 1, 2, 4, 5, 6, 7, 0 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(0));
        }
    }
}
