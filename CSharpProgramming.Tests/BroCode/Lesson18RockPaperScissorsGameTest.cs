using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode;

public class Lesson18RockPaperScissorsGameTest
{
	[Theory]
	[InlineData("ROCK")]
	[InlineData("ROCK\nY\nPAPER")]
	[InlineData("ROCK\nY\nPAPER\nY\nSCISSORS")]
	[InlineData("ROCK\nY\nPAPER\nY\nSCISSORS\nY\nPAPER")]
	public void Test1(string input)
	{
		var lesson = new Lesson18RockPaperScissorsGame();

		using var sr = new StringReader(input);
		Console.SetIn(sr);

		lesson.Method1();
	}
}
