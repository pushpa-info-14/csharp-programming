using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q04ProductOfArrayExceptSelfLeetcode238Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q04ProductOfArrayExceptSelfLeetcode238();

            var answer = solution.ProductExceptSelf(new[] { 1, 2, 3, 4 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(new[] { 24, 12, 8, 6 }));
        }
    }
}
