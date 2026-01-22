using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q03ContainsDuplicateHashSetLeetcode217Test
{
	[Fact]
	public void Test1()
	{
		var solution = new Q03ContainsDuplicateHashSetLeetcode217();

		var answer = solution.ContainsDuplicate(new[] { 1, 2, 3, 1 });
		ConsoleLogger.Print(answer);
		Assert.True(answer);

		answer = solution.ContainsDuplicate(new[] { 1, 2, 3, 4 });
		ConsoleLogger.Print(answer);
		Assert.False(answer);

		answer = solution.ContainsDuplicate(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
		ConsoleLogger.Print(answer);
		Assert.True(answer);
	}
}
