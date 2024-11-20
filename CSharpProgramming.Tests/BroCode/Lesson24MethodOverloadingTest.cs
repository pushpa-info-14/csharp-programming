using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode;

public class Lesson24MethodOverloadingTest
{
    [Fact]
    public void Test1()
    {
        var lesson = new Lesson24MethodOverloading();
        lesson.Method1();
    }
}
