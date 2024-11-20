using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q06MaximumProductSubarrayDynamicProgrammingLeetcode152Test
{
    [Fact]
    public void Test1()
    {
        var solution = new Q06MaximumProductSubarrayDynamicProgrammingLeetcode152();

        var answer = solution.MaxSubArray(new[] { 2, 3, -2, 4 });
        ConsoleLogger.Print(answer);
        Assert.Equal(6, answer);

        answer = solution.MaxSubArray(new[] { -2, 0, -1 });
        ConsoleLogger.Print(answer);
        Assert.Equal(0, answer);
    }
}
