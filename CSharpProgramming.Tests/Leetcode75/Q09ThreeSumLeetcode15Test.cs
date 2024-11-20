using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q09ThreeSumLeetcode15Test
{
    [Fact]
    public void Test1()
    {
        var solution = new Q09ThreeSumLeetcode15();

        var answer = solution.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 });
        ConsoleLogger.Print(answer);
        Assert.Equal(new List<List<int>> { new() { -1, -1, 2 }, new() { -1, 0, 1 } }, answer);

        answer = solution.ThreeSum(new[] { 0, 1, 1 });
        ConsoleLogger.Print(answer);
        Assert.Equal(new List<List<int>>(), answer);
    }
}
