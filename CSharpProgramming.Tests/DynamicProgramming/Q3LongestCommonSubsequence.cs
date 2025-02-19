using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.DynamicProgramming;

public class Q3LongestCommonSubsequence(ITestOutputHelper output) : BaseTest(output)
{
    public class LongestCommonSubsequence
    {
        public long GetLength(int[] a, int[] b)
        {
            var dp = Calculate(a, b);

            return dp[a.Length, b.Length];
        }

        public int[] GetElements(int[] a, int[] b)
        {
            var dp = Calculate(a, b);
            var elements = ReconstructElements(dp, a, b);

            return elements;
        }

        public int[,] Calculate(int[] a, int[] b)
        {
            var dp = new int[a.Length + 1, b.Length + 1];


            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    dp[i, j] = 0;
                }
            }

            for (int i = 1; i <= a.Length; i++)
            {
                for (int j = 1; j <= b.Length; j++)
                {
                    if (a[i - 1] == b[j - 1])
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp;
        }

        public int[] ReconstructElements(int[,] dp, int[] a, int[] b)
        {
            var elements = new List<int>();

            var i = a.Length;
            var j = b.Length;

            while (i > 0 && j > 0)
            {
                if (a[i - 1] == b[j - 1])
                {
                    elements.Add(a[i - 1]);
                    i--;
                    j--;
                }
                else if (dp[i - 1, j] > dp[i, j - 1])
                {
                    i--;
                }
                else
                {
                    j--;
                }
            }

            elements.Reverse();
            return elements.ToArray();
        }
    }


    [Fact]
    public void Test()
    {
        var longestCommonSubsequence = new LongestCommonSubsequence();

        WriteLine(longestCommonSubsequence.GetLength([1, 2, 3, 4, 5], [1, 3, 5]) + "");

        var result = longestCommonSubsequence.GetElements([1, 2, 3, 4, 5], [1, 3, 5]);
        Print(result);
    }
}
