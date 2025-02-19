using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.LeetCode.Q0000_0500;

public class Q39CombinationSum(ITestOutputHelper output) : BaseTest(output)
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var n = candidates.Length;
            var res = new List<IList<int>>();
            var cur = new List<int>();

            void Backtrack(int index, int target)
            {
                if (target == 0)
                {
                    res.Add(cur.ToList());
                    return;
                }
                if (target < 0 || index == n) return;

                for (int i = index; i < n; i++)
                {
                    var candidate = candidates[i];
                    cur.Add(candidate);
                    Backtrack(i, target - candidate);
                    cur.Remove(candidate);
                }
            }

            Backtrack(0, target);
            return res;
        }

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            var n = candidates.Length;
            var res = new List<IList<int>>();
            var cur = new List<int>();

            void Backtrack(int index, int target)
            {
                if (target == 0)
                {
                    res.Add(cur.ToList());
                    return;
                }
                if (target < 0 || index == n) return;

                var candidate = candidates[index];
                cur.Add(candidate);
                Backtrack(index, target - candidate);
                cur.Remove(candidate);

                Backtrack(index + 1, target);
            }

            Backtrack(0, target);
            return res;
        }
    }

    [Fact]
    public void Test()
    {
        var s = new Solution();
        Print(s.CombinationSum([2, 3, 6, 7], 7));
        Print(s.CombinationSum([2, 3, 5], 8));
        Print(s.CombinationSum([2], 1));

        Print(s.CombinationSum2([2, 3, 6, 7], 7));
        Print(s.CombinationSum2([2, 3, 5], 8));
        Print(s.CombinationSum2([2], 1));
    }
}
