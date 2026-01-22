using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q07FindMinimumInRotatedSortedArrayBinarySearchLeetcode153Test
{
	[Fact]
	public void Test1()
	{
		var solution = new Q07FindMinimumInRotatedSortedArrayBinarySearchLeetcode153();

		var answer = solution.FindMin(new[] { 3, 4, 5, 1, 2 });
		ConsoleLogger.Print(answer);
		Assert.Equal(1, answer);

		answer = solution.FindMin(new[] { 4, 5, 6, 7, 0, 1, 2 });
		ConsoleLogger.Print(answer);
		Assert.Equal(0, answer);

		answer = solution.FindMin(new[] { 1, 2, 4, 5, 6, 7, 0 });
		ConsoleLogger.Print(answer);
		Assert.Equal(0, answer);
	}
}
