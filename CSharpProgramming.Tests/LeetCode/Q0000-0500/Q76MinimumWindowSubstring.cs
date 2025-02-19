using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.LeetCode.Q0000_0500;

public class Q76MinimumWindowSubstring(ITestOutputHelper output) : BaseTest(output)
{
    public class Solution
    {
        public string MinWindow(string s, string t)
        {
            var map = new int[256];
            int minLength = int.MaxValue;
            int startIndex = -1;
            int l = 0;
            int r = 0;
            int n = s.Length;
            int m = t.Length;
            int count = 0;

            foreach (var c in t)
            {
                map[(int)c] += 1;
            }

            while (r < n)
            {
                if (map[(int)s[r]] > 0)
                {
                    count++;
                }
                map[(int)s[r]] -= 1;

                while (count == m)
                {
                    if (r - l + 1 < minLength)
                    {
                        minLength = r - l + 1;
                        startIndex = l;
                    }

                    map[(int)s[l]] += 1;
                    if (map[(int)s[l]] > 0)
                    {
                        count--;
                    }

                    l++;
                }
                r++;
            }

            var res = "";
            if (startIndex != -1)
            {
                res = s.Substring(startIndex, minLength);
            }
            return res;
        }
    }

    [Fact]
    public void Test()
    {
        var s = new Solution();
        WriteLine(s.MinWindow("ADOBECODEBANC", "ABC"));
        WriteLine(s.MinWindow("a", "a"));
        WriteLine(s.MinWindow("a", "aa"));
    }
}
