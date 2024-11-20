using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q05MaximumSubarrayDynamicProgrammingLeetcode53Test
{
    [Fact]
    public void Test1()
    {
        var solution = new Q05MaximumSubarrayDynamicProgrammingLeetcode53();

        var answer = solution.MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        ConsoleLogger.Print(answer);
        Assert.Equal(6, answer);

        answer = solution.MaxSubArray(new[] { 1 });
        ConsoleLogger.Print(answer);
        Assert.Equal(1, answer);

        answer = solution.MaxSubArray(new[] { 5, 4, -1, 7, 8 });
        ConsoleLogger.Print(answer);
        Assert.Equal(23, answer);
    }
}
