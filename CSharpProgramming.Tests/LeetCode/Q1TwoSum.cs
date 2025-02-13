// Ignore Spelling: nums

using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.LeetCode;

public class Q1TwoSum(ITestOutputHelper output) : BaseTest(output)
{
    public int[] TwoSum(int[] nums, int target)
    {
        var res = new int[2];

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (map.TryGetValue(nums[i], out var index))
            {
                res[0] = index;
                res[1] = i;
                return res;
            }
            map[target - nums[i]] = i;
        }

        return res;
    }

    [Fact]
    public void Test()
    {
        WriteLine(TwoSum([2, 7, 11, 15], 9));
        WriteLine(TwoSum([3, 2, 4], 6));
        WriteLine(TwoSum([3, 3], 6));
    }
}
