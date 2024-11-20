using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode;

public class Lesson19CalculatorProgramTest
{
    [Theory]
    [InlineData("10\n20\n+")]
    [InlineData("20\n10\n-")]
    [InlineData("20\n10\n*")]
    [InlineData("20\n2\n/\nY\n5\n6\n*")]
    public void Test1(string input)
    {
        var lesson = new Lesson19CalculatorProgram();

        using var sr = new StringReader(input);
        Console.SetIn(sr);

        lesson.Method1();
    }
}
