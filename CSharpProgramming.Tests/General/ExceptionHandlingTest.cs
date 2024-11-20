using CSharpProgramming.Study.General;
using Xunit;

namespace CSharpProgramming.Tests.General;

public class ExceptionHandlingTest
{
    [Fact]
    public void Test1()
    {
        try
        {
            ExceptionHandling.Hello1();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    [Fact]
    public void Test2()
    {
        try
        {
            ExceptionHandling.Hello2();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    [Fact]
    public void Test3()
    {
        try
        {
            ExceptionHandling.Hello3();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
