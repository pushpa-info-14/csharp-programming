using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests;

public class PassByValueOrReferenceTest
{
    private readonly ITestOutputHelper _output;

    public PassByValueOrReferenceTest(ITestOutputHelper testOutputHelper)
    {
        _output = testOutputHelper;
    }

    /**
    public void DoSomething(Image image)
    {
        // This change won't be seen by the caller: it's changing the value
        // of the parameter.
        image = Image.FromStream(...);
    }

    public void DoSomething(ref Image image)
    {
        // This change *will* be seen by the caller: it's changing the value
        // of the parameter, but we're using pass by reference
        image = Image.FromStream(...);
    }

    public void DoSomething(Image image)
    {
        // This change *will* be seen by the caller: it's changing the data
        // within the object that the parameter value refers to.
        image.RotateFlip(...);
    }
    */

    [Fact]
    void Test()
    {
        void Method1(int a)
        {
            a = 20;
            _output.WriteLine("Inside the method: " + a);
        }

        void Method2(ref int a)
        {
            a = 20;
            _output.WriteLine("Inside the method: " + a);
        }

        var number = 10;
        var number2 = 30;

        _output.WriteLine("Before: " + number);
        Method1(number);
        _output.WriteLine("After: " + number);

        _output.WriteLine("Before: " + number2);
        Method2(ref number2);
        _output.WriteLine(number2 + "");
    }
}
