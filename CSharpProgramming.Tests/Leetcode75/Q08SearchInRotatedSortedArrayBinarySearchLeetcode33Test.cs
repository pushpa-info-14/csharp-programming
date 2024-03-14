using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q08SearchInRotatedSortedArrayBinarySearchLeetcode33Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q08SearchInRotatedSortedArrayBinarySearchLeetcode33();

            var answer = solution.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(4));

            answer = solution.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3);
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(-1));

            answer = solution.Search(new[] { 1 }, 0);
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(-1));

            answer = solution.Search(new[] { 3, 1 }, 1);
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(1));
        }
    }
}
