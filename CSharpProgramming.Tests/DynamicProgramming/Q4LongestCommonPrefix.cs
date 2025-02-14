using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.DynamicProgramming;

public class Q4LongestCommonPrefix(ITestOutputHelper output) : BaseTest(output)
{
    public class LongestCommonPrefix
    {
        public string Solution(string[] strs)
        {
            var result = "";

            for (var i = 0; i < strs[0].Length; i++)
            {
                for (var j = 0; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[0][i] != strs[j][i])
                    {
                        return result;
                    }
                }

                result += strs[0][i];
            }

            return result;
        }
    }

    [Fact]
    public void Test()
    {
        var longestCommonPrefix = new LongestCommonPrefix();

        WriteLine(longestCommonPrefix.Solution(["flower", "flow", "flight"]) + "");
        WriteLine(longestCommonPrefix.Solution(["a"]) + "");
    }
}
