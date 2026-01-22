using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q70DesignAndSearchWordsDataStructureLeetcode211Test
{
	[Fact]
	public void Test1()
	{
		var solution = new Q70DesignAndSearchWordsDataStructureLeetcode211();

		solution.AddWord("bad");
		solution.AddWord("dad");
		solution.AddWord("mad");

		var answer1 = solution.Search("pad");
		var answer2 = solution.Search("bad");
		var answer3 = solution.Search(".ad");
		var answer4 = solution.Search("b..");

		ConsoleLogger.Print(answer1);
		ConsoleLogger.Print(answer2);
		ConsoleLogger.Print(answer3);
		ConsoleLogger.Print(answer4);

		Assert.Multiple(() =>
		{
			Assert.False(answer1);
			Assert.True(answer2);
			Assert.True(answer3);
			Assert.True(answer4);
		});
	}
}
