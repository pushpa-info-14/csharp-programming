namespace CSharpProgramming.Study.Leetcode75
{
    public class Q05MaximumSubarrayDynamicProgrammingLeetcode53
    {
        public int MaxSubArray(int[] nums)
        {
            var maxSum = nums[0];
            var currentSum = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                if (currentSum < 0)
                {
                    currentSum = 0;
                }
                currentSum += nums[i];
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }
    }
}
