using CSharpProgramming.Tests.LeetCode.Common;
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

    public void WriteLine(string s)
    {
        _output.WriteLine(s);
    }

    public void Print(object s)
    {
        _output.WriteLine(JsonSerializer.Serialize(s));
    }

    public void PrintListNodes(ListNode listNode)
    {
        var res = new List<int>();

        var cur = listNode;
        while (cur != null)
        {
            res.Add(cur.val);
            cur = cur.next;
        }

        _output.WriteLine(JsonSerializer.Serialize(res));
    }
}
