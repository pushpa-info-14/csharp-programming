using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q75SumOfTwoIntegersLeetcode371Test
{
	[Fact]
	public void Test1()
	{
		var solution = new Q75SumOfTwoIntegersLeetcode371();

		var answer1 = solution.GetSum(1, 2);
		var answer2 = solution.GetSum(-1, -2);
		var answer3 = solution.GetSum(1, -2);
		var answer4 = solution.GetSum(-2, 1);

		ConsoleLogger.Print(answer1);
		ConsoleLogger.Print(answer2);
		ConsoleLogger.Print(answer3);
		ConsoleLogger.Print(answer4);

		Assert.Multiple(() =>
		{
			Assert.Equal(3, answer1);
			Assert.Equal(-3, answer2);
			Assert.Equal(-1, answer3);
			Assert.Equal(-1, answer4);
		});
	}
}
