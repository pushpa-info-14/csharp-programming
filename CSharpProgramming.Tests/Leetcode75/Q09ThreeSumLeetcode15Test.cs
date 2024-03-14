using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q09ThreeSumLeetcode15Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q09ThreeSumLeetcode15();

            var answer = solution.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(new List<List<int>> { new() { -1, -1, 2 }, new() { -1, 0, 1 } }));

            answer = solution.ThreeSum(new[] { 0, 1, 1 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(new List<List<int>>()));
        }
    }
}
