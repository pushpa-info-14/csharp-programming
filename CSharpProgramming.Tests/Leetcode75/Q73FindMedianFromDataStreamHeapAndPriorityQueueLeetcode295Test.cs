using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q73FindMedianFromDataStreamHeapAndPriorityQueueLeetcode295Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q73FindMedianFromDataStreamHeapAndPriorityQueueLeetcode295();

            solution.AddNum(1);
            solution.AddNum(2);

            var answer = solution.FindMedian();
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(1.5));

            solution.AddNum(3);
            answer = solution.FindMedian();
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(2.0));

            solution.AddNum(8);
            answer = solution.FindMedian();
            ConsoleLogger.Print(answer);
            Assert.That(answer, Is.EqualTo(2.5));
        }
    }
}
