using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q71WordSearch2BacktrackingTrieLeetcode212Test
{
	[Fact]
	public void Test1()
	{
		var solution = new Q71WordSearch2BacktrackingTrieLeetcode212();

		var answer = solution.FindWords(new[]
		{
			new[] { 'o', 'a', 'a', 'n' },
			new[] { 'e', 't', 'a', 'e' },
			new[] { 'i', 'h', 'k', 'r' },
			new[] { 'i', 'f', 'l', 'v' }
		}, new[] { "oath", "pea", "eat", "rain" });

		ConsoleLogger.Print(answer);
		Assert.Equal(["oath", "eat"], answer);

		answer = solution.FindWords(new[]
		{
			new[] { 'o', 'a', 'b', 'n' },
			new[] { 'o', 't', 'a', 'e' },
			new[] { 'a', 'h', 'k', 'r' },
			new[] { 'a', 'f', 'l', 'v' }
		}, new[] { "oa", "oaa" });

		ConsoleLogger.Print(answer);
		Assert.Equal(["oa", "oaa"], answer);
	}
}
