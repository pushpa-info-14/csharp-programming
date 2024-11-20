using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode;

public class Lesson49MultiThreadingTest
{
    [Fact]
    public void Test1()
    {
        var lesson = new Lesson49MultiThreading();
        lesson.Method1();
    }
}
