using CSharpProgramming.Tests.Base;
using CSharpProgramming.Tests.LeetCode.Common;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.InterviewQuestions;

public class Q3LinkedListSorting(ITestOutputHelper output) : BaseTest(output)
{
	public class Solution
	{
		public static ListNode FindMiddle(ListNode head)
		{
			var slow = head;
			var fast = head.next; // Small trick to get the correct middle [5]->[2]->[3]->[4]->null
			while (fast != null && fast.next != null)
			{
				slow = slow.next;
				fast = fast.next.next;
			}
			return slow;
		}

		public static ListNode MergeTwoLists(ListNode head1, ListNode head2)
		{
			var dummy = new ListNode(0);
			var temp = dummy;
			while (head1 != null && head2 != null)
			{
				if (head1.val < head2.val)
				{
					temp.next = head1;
					temp = head1;
					head1 = head1.next;
				}
				else
				{
					temp.next = head2;
					temp = head2;
					head2 = head2.next;
				}
			}

			if (head1 != null) { temp.next = head1; }
			if (head2 != null) { temp.next = head2; }

			return dummy.next;
		}

		public static ListNode Sort(ListNode head)
		{
			if (head == null || head.next == null) return head;

			var middle = FindMiddle(head);
			var right = middle.next;
			middle.next = null;
			var left = head;

			left = Sort(left);
			right = Sort(right);
			return MergeTwoLists(left, right);
		}
	}

	[Fact]
	public void Test()
	{
		var head = new ListNode(5, new ListNode(2, new ListNode(3, new ListNode(4))));
		PrintListNodes(Solution.Sort(head));
	}
}
