using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode;

public class Lesson26ExceptionHandlingTest
{
    [Theory]
    [InlineData("4\n5\n")]
    [InlineData("4\n0\n")]
    [InlineData("4\npizza\n")]
    public void Test1(string input)
    {
        var lesson = new Lesson26ExceptionHandling();

        using var sr = new StringReader(input);
        Console.SetIn(sr);

        lesson.Method1();
    }
}
