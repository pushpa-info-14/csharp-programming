using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q72TopKFrequentElementsBucketSortLeetcode347Test
{
    [Fact]
    public void Test1()
    {
        var solution = new Q72TopKFrequentElementsBucketSortLeetcode347();

        var answer = solution.TopKFrequent(new[] { 1, 1, 1, 2, 2, 3 }, 2);
        ConsoleLogger.Print(answer);
        Assert.Equal([1, 2], answer);

        answer = solution.TopKFrequent(new[] { 1 }, 1);
        ConsoleLogger.Print(answer);
        Assert.Equal([1], answer);

        answer = solution.TopKFrequent(new[] { -1, -1 }, 1);
        ConsoleLogger.Print(answer);
        Assert.Equal([-1], answer);
    }
}
