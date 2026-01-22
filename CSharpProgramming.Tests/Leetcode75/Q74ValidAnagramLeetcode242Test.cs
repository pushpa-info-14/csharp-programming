using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q74ValidAnagramLeetcode242Test
{
	[Fact]
	public void Test1()
	{
		var solution = new Q74ValidAnagramLeetcode242();

		var answer1 = solution.IsAnagram("anagram", "nagaram");
		var answer2 = solution.IsAnagram("rat", "car");
		var answer3 = solution.IsAnagram("aa", "a");
		var answer4 = solution.IsAnagram("aacc", "ccac");

		ConsoleLogger.Print(answer1);
		ConsoleLogger.Print(answer2);
		ConsoleLogger.Print(answer3);
		ConsoleLogger.Print(answer4);

		Assert.Multiple(() =>
		{
			Assert.True(answer1);
			Assert.False(answer2);
			Assert.False(answer3);
			Assert.False(answer4);
		});
	}
}
