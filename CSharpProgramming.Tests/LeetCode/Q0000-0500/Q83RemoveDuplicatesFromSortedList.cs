using CSharpProgramming.Tests.Base;
using CSharpProgramming.Tests.LeetCode.Common;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.LeetCode.Q0000_0500;

public class Q83RemoveDuplicatesFromSortedList(ITestOutputHelper output) : BaseTest(output)
{
	public class Solution
	{
		public ListNode DeleteDuplicates(ListNode head)
		{
			var dummy = new ListNode(0, head);
			var cur = dummy.next;

			while (cur != null)
			{
				while (cur != null && cur.next != null && cur.val == cur.next.val)
				{
					cur.next = cur.next.next;
				}
				if (cur != null)
				{
					cur = cur.next;
				}
			}

			return dummy.next;
		}
	}

	[Fact]
	public void Test()
	{
		var head1 = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));
		var head2 = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1)))));

		var s = new Solution();
		PrintListNodes(s.DeleteDuplicates(head1));
		PrintListNodes(s.DeleteDuplicates(head2));
	}
}
