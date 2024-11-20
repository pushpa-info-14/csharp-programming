using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q69ImplementTriePrefixTreeLeetcode208Test
{
    [Fact]
    public void Test1()
    {
        var solution = new Q69ImplementTriePrefixTreeLeetcode208();

        solution.Insert("apple");
        var answer = solution.Search("apple");
        ConsoleLogger.Print(answer);
        Assert.True(answer);

        answer = solution.Search("app");
        ConsoleLogger.Print(answer);
        Assert.False(answer);

        answer = solution.StartsWith("app");
        ConsoleLogger.Print(answer);
        Assert.True(answer);

        solution.Insert("app");
        answer = solution.Search("app");
        ConsoleLogger.Print(answer);
        Assert.True(answer);
    }
}
