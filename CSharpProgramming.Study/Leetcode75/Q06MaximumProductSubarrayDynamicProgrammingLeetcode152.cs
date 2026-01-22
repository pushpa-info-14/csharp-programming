namespace CSharpProgramming.Study.Leetcode75
{
	public class Q06MaximumProductSubarrayDynamicProgrammingLeetcode152
	{
		public int MaxSubArray(int[] nums)
		{
			var maxProduct = nums[0];
			var currentMin = nums[0];
			var currentMax = nums[0];

			for (var i = 1; i < nums.Length; i++)
			{
				if (nums[i] < 0)
				{
					(currentMax, currentMin) = (currentMin, currentMax);
				}

				currentMax = Math.Max(nums[i], currentMax * nums[i]);
				currentMin = Math.Min(nums[i], currentMin * nums[i]);

				maxProduct = Math.Max(maxProduct, currentMax);
			}
			return maxProduct;
		}
	}
}
