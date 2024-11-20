using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q10ContainerWithMostWaterLeetcode11Test
{
    [Fact]
    public void Test1()
    {
        var solution = new Q10ContainerWithMostWaterLeetcode11();

        var answer = solution.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        ConsoleLogger.Print(answer);
        Assert.Equal(49, answer);

        answer = solution.MaxArea(new[] { 1, 1 });
        ConsoleLogger.Print(answer);
        Assert.Equal(1, answer);
    }
}
