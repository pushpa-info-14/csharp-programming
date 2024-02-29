using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q75SumOfTwoIntegersLeetcode371Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q75SumOfTwoIntegersLeetcode371();

            var answer1 = solution.GetSum(1, 2);
            var answer2 = solution.GetSum(-1, -2);
            var answer3 = solution.GetSum(1, -2);
            var answer4 = solution.GetSum(-2, 1);

            ConsoleLogger.Print(answer1);
            ConsoleLogger.Print(answer2);
            ConsoleLogger.Print(answer3);
            ConsoleLogger.Print(answer4);

            Assert.Multiple(() =>
            {
                Assert.That(answer1, Is.EqualTo(3));
                Assert.That(answer2, Is.EqualTo(-3));
                Assert.That(answer3, Is.EqualTo(-1));
                Assert.That(answer4, Is.EqualTo(-1));
            });
        }
    }
}
