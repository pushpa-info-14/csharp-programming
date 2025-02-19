using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.InterviewQuestions;

public class Q2MaximumSubArray(ITestOutputHelper output) : BaseTest(output)
{
    public class Solution
    {
        public int MaxSubArraySum(int[] nums)
        {
            int maxSum = -int.MaxValue;
            int curentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                curentSum += nums[i];

                if (curentSum > maxSum)
                {
                    maxSum = curentSum;
                }

                if (curentSum < 0)
                {
                    curentSum = 0;
                }
            }

            return maxSum;
        }

        public int[] MaxSubArray(int[] nums)
        {
            int maxSum = -int.MaxValue;
            int curentSum = 0;
            int startIndex = -1;
            int endIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (curentSum == 0) startIndex = i;

                curentSum += nums[i];

                if (curentSum > maxSum)
                {
                    maxSum = curentSum;
                    endIndex = i;
                }

                if (curentSum < 0)
                {
                    curentSum = 0;
                }
            }

            var res = new int[endIndex - startIndex + 1];
            for (int i = startIndex; i < endIndex + 1; i++)
            {
                res[i - startIndex] = nums[i];
            }
            return res;
        }
    }

    [Fact]
    public void Test()
    {
        var s = new Solution();
        Print(s.MaxSubArraySum([-2, 1, -3, 4, -1, 2, 1, -5, 4]));
        Print(s.MaxSubArraySum([1]));
        Print(s.MaxSubArraySum([5, 4, -1, 7, 8]));
        Print(s.MaxSubArraySum([-1]));
        Print(s.MaxSubArraySum([3, 2, -6, 8, -3, 5]));

        Print(s.MaxSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]));
        Print(s.MaxSubArray([1]));
        Print(s.MaxSubArray([5, 4, -1, 7, 8]));
        Print(s.MaxSubArray([-1]));
        Print(s.MaxSubArray([3, 2, -6, 8, -3, 5]));
    }
}
