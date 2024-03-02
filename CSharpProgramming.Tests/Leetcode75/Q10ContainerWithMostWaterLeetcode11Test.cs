using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q10ContainerWithMostWaterLeetcode11Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q10ContainerWithMostWaterLeetcode11();

            var answer = solution.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(49));

            answer = solution.MaxArea(new[] { 1, 1 });
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(1));
        }
    }
}
