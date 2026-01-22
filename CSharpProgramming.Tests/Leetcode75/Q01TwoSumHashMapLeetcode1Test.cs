using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;
using Xunit;

namespace CSharpProgramming.Tests.Leetcode75;

public class Q01TwoSumHashMapLeetcode1Test
{
	[Fact]
	public void Test1()
	{
		var solution = new Q01TwoSumHashMapLeetcode1();

		var answer1 = solution.TwoSum(new[] { 2, 7, 11, 15 }, 9);
		var answer2 = solution.TwoSum(new[] { 2, 1, 5, 3 }, 4);

		ConsoleLogger.Print(answer1);
		ConsoleLogger.Print(answer2);

		Assert.Multiple(() =>
		{
			Assert.Equal(answer1, new[] { 0, 1 });
			Assert.Equal(answer2, new[] { 1, 3 });
		});
	}
}
