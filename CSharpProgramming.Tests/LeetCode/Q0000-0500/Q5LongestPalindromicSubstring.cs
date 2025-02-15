using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.LeetCode.Q0000_0500;

public class Q5LongestPalindromicSubstring(ITestOutputHelper output) : BaseTest(output)
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            var n = s.Length;
            var res = "";
            var maxLength = 0;

            for (int i = 0; i < n; i++)
            {
                // Odd
                var l = i;
                var r = i;
                while (l >= 0 && r < n && s[l] == s[r])
                {
                    if (r - l + 1 > maxLength)
                    {
                        res = s.Substring(l, r - l + 1);
                        maxLength = r - l + 1;
                    }
                    l--;
                    r++;
                }

                // Even
                l = i;
                r = i + 1;
                while (l >= 0 && r < n && s[l] == s[r])
                {
                    if (r - l + 1 > maxLength)
                    {
                        res = s.Substring(l, r - l + 1);
                        maxLength = r - l + 1;
                    }
                    l--;
                    r++;
                }
            }

            return res;
        }
    }

    [Fact]
    public void Test()
    {
        var s = new Solution();
        WriteLine(s.LongestPalindrome("babad"));
        WriteLine(s.LongestPalindrome("cbbd"));
    }
}
