using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q32GraphValidTreeLeetcode261Test
{
    [Fact]
    public void Test1()
    {
        var solution = new Q32GraphValidTreeLeetcode261();

        var answer1 = solution.GraphValidTree(5, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 1, 4 } });

        ConsoleLogger.Print(answer1);

        Assert.True(answer1);
    }
}
