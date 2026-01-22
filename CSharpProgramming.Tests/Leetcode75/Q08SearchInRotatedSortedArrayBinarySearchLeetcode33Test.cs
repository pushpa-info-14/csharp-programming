using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q08SearchInRotatedSortedArrayBinarySearchLeetcode33Test
{
	[Fact]
	public void Test1()
	{
		var solution = new Q08SearchInRotatedSortedArrayBinarySearchLeetcode33();

		var answer = solution.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
		ConsoleLogger.Print(answer);
		Assert.Equal(4, answer);

		answer = solution.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3);
		ConsoleLogger.Print(answer);
		Assert.Equal(-1, answer);

		answer = solution.Search(new[] { 1 }, 0);
		ConsoleLogger.Print(answer);
		Assert.Equal(-1, answer);

		answer = solution.Search(new[] { 3, 1 }, 1);
		ConsoleLogger.Print(answer);
		Assert.Equal(1, answer);
	}
}
