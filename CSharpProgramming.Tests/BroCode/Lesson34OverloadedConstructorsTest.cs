using CSharpProgramming.Study.BroCode;
using Xunit;

namespace CSharpProgramming.Tests.BroCode;

public class Lesson34OverloadedConstructorsTest
{
    [Fact]
    public void Test1()
    {
        var lesson = new Lesson34OverloadedConstructors();
        lesson.Method1();
    }
}
