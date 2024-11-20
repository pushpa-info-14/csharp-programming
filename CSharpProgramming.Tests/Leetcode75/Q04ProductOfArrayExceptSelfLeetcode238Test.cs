using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q04ProductOfArrayExceptSelfLeetcode238Test
{
    [Fact]
    public void Test1()
    {
        var solution = new Q04ProductOfArrayExceptSelfLeetcode238();

        var answer = solution.ProductExceptSelf([1, 2, 3, 4]);
        ConsoleLogger.Print(answer);
        Assert.Equal([24, 12, 8, 6], answer);
    }
}
