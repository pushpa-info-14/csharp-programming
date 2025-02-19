using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.LeetCode.Q1500_2000;

public class Q1718ConstructTheLexicographicallyLargestValidSequence(ITestOutputHelper output) : BaseTest(output)
{
    public class Solution
    {
        public int[] ConstructDistancedSequence(int n)
        {
            var resultLength = 2 * n - 1;
            var result = new int[resultLength];
            var isNumberUsed = new bool[n + 1];

            bool Backtracking(int i)
            {
                if (i == resultLength)
                {
                    return true;
                }

                if (result[i] != 0)
                {
                    return Backtracking(i + 1);
                }

                for (int num = n; num > 0; num--)
                {
                    if (isNumberUsed[num]) continue;

                    isNumberUsed[num] = true;
                    result[i] = num;

                    if (num == 1)
                    {
                        if (Backtracking(i + 1))
                        {
                            return true;
                        }
                    }
                    else if (i + num < resultLength && result[i + num] == 0)
                    {
                        result[i + num] = num;
                        if (Backtracking(i + 1))
                        {
                            return true;
                        }
                        result[i + num] = 0;
                    }

                    isNumberUsed[num] = false;
                    result[i] = 0;
                }

                return false;
            }

            Backtracking(0);
            return result;
        }
    }

    [Fact]
    public void Test()
    {
        var s = new Solution();
        Print(s.ConstructDistancedSequence(3));
        Print(s.ConstructDistancedSequence(5));
        Print(s.ConstructDistancedSequence(10));
    }
}
