using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.LeetCode.Q0000_0500;

public class Q403FrogJump(ITestOutputHelper output) : BaseTest(output)
{
    public class Solution
    {
        public bool CanCross(int[] stones)
        {
            var dp = new Dictionary<int, HashSet<int>>();
            foreach (var num in stones)
            {
                dp[num] = new HashSet<int>();
            }
            dp[1] = new HashSet<int>([1]);

            for (int i = 0; i < stones.Length; i++)
            {
                if (!dp.ContainsKey(stones[i])) continue;

                foreach (var jump in dp[stones[i]].ToHashSet())
                {
                    if (dp.ContainsKey(stones[i] + jump))
                    {
                        dp[stones[i] + jump].Add(jump);
                    }
                    if (dp.ContainsKey(stones[i] + jump - 1))
                    {
                        dp[stones[i] + jump - 1].Add(jump - 1);
                    }
                    if (dp.ContainsKey(stones[i] + jump + 1))
                    {
                        dp[stones[i] + jump + 1].Add(jump + 1);
                    }
                }
            }

            return dp[stones[^1]].Count != 0;
        }
    }

    [Fact]
    public void Test()
    {
        Solution s = new Solution();
        Print(s.CanCross([0, 1, 3, 5, 6, 8, 12, 17]));
        Print(s.CanCross([0, 1, 2, 3, 4, 8, 9, 11]));
    }
}
