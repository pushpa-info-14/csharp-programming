// Ignore Spelling: nums

using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.LeetCode.Q0000_0500;

public class Q300LongestIncreasingSubsequence(ITestOutputHelper output) : BaseTest(output)
{
    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            var dp = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                dp[i] = 1;
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        dp[i] = Math.Max(dp[i], 1 + dp[j]);
                    }
                }

            }

            return dp.Max();
        }
    }

    [Fact]
    public void Test()
    {
        var s = new Solution();
        Print(s.LengthOfLIS([10, 9, 2, 5, 3, 7, 101, 18]));
        Print(s.LengthOfLIS([0, 1, 0, 3, 2, 3]));
        Print(s.LengthOfLIS([7, 7, 7, 7, 7, 7, 7]));
    }
}
