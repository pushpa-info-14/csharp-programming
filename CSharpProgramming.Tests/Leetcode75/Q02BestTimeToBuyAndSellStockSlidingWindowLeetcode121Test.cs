using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q02BestTimeToBuyAndSellStockSlidingWindowLeetcode121Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q02BestTimeToBuyAndSellStockSlidingWindowLeetcode121();

            var answer = solution.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(5));
        }
    }
}
