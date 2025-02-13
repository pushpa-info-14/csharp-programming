using System.Text.Json;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.Base;

public class BaseTest
{
    private readonly ITestOutputHelper _output;

    public BaseTest(ITestOutputHelper output)
    {
        _output = output;
    }

    public void WriteLine(object s)
    {
        _output.WriteLine(JsonSerializer.Serialize(s));
    }
}
