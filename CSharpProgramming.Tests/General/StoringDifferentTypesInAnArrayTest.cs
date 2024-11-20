using CSharpProgramming.Study.General;
using Xunit;

namespace CSharpProgramming.Tests.General;

public class StoringDifferentTypesInAnArrayTest
{
    [Fact]
    public void Test1()
    {
        var instance = new StoringDifferentTypesInAnArray();
        instance.Method1();
    }

    [Fact]
    public void Test2()
    {
        var instance = new StoringDifferentTypesInAnArray();
        instance.Method2();
    }
}
