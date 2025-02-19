using CSharpProgramming.Tests.Base;
using CSharpProgramming.Tests.LeetCode.Common;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.LeetCode.Q0000_0500;

public class Q2AddTwoNumbers(ITestOutputHelper output) : BaseTest(output)
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            var cur1 = l1;
            var cur2 = l2;
            var dummy = new ListNode(0);
            var res = dummy;

            while (cur1 != null && cur2 != null)
            {
                int curSum = carry + cur1.val + cur2.val;
                res.next = new ListNode(curSum % 10);
                carry = curSum / 10;
                res = res.next;
                cur1 = cur1.next;
                cur2 = cur2.next;
            }

            while (cur1 != null)
            {
                int curSum = carry + cur1.val;
                res.next = new ListNode(curSum % 10);
                carry = curSum / 10;
                res = res.next;
                cur1 = cur1.next;
            }

            while (cur2 != null)
            {
                int curSum = carry + cur2.val;
                res.next = new ListNode(curSum % 10);
                carry = curSum / 10;
                res = res.next;
                cur2 = cur2.next;
            }

            if (carry != 0)
            {
                res.next = new ListNode(carry);
            }

            return dummy.next;
        }
    }

    [Fact]
    public void Test()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        var s = new Solution();
        PrintListNodes(s.AddTwoNumbers(l1, l2));
    }
}