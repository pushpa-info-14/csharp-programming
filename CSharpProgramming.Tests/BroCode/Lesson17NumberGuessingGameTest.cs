using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode;

public class Lesson17NumberGuessingGameTest
{
    [Fact]
    public void Test1()
    {
        var lesson = new Lesson17NumberGuessingGame();

        var input = "0";
        for (var i = 1; i <= 100; i++)
        {
            input += "\n" + i;
        }
        using var sr = new StringReader(input);
        Console.SetIn(sr);

        lesson.Method1();
    }
}
