using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q73FindMedianFromDataStreamHeapAndPriorityQueueLeetcode295Test
{
    [Fact]
    public void Test1()
    {
        var solution = new Q73FindMedianFromDataStreamHeapAndPriorityQueueLeetcode295();

        solution.AddNum(1);
        solution.AddNum(2);

        var answer = solution.FindMedian();
        ConsoleLogger.Print(answer);
        Assert.Equal(1.5, answer);

        solution.AddNum(3);
        answer = solution.FindMedian();
        ConsoleLogger.Print(answer);
        Assert.Equal(2.0, answer);

        solution.AddNum(8);
        answer = solution.FindMedian();
        ConsoleLogger.Print(answer);
        Assert.Equal(2.5, answer);
    }
}
