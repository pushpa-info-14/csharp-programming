using CSharpProgramming.Tests.LeetCode.Common;
using System.Text.Json;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.Base;

public class BaseTest
{
	public readonly ITestOutputHelper output;

	public BaseTest(ITestOutputHelper output)
	{
		this.output = output;
	}

	public void WriteLine(string s)
	{
		output.WriteLine(s);
	}

	public void Print(object s)
	{
		output.WriteLine(JsonSerializer.Serialize(s));
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

		output.WriteLine(JsonSerializer.Serialize(res));
	}
}
