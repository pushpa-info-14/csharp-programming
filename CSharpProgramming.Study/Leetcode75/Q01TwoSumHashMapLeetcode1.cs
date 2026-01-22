namespace CSharpProgramming.Study.Leetcode75
{
	public class Q01TwoSumHashMapLeetcode1
	{
		public int[] TwoSum(int[] nums, int target)
		{
			var result = new int[2];
			var previousMap = new Dictionary<int, int>();

			for (var i = 0; i < nums.Length; i++)
			{
				var diff = target - nums[i];
				if (previousMap.TryGetValue(diff, out var value))
				{
					result[0] = value;
					result[1] = i;
				}
				previousMap[nums[i]] = i;
			}

			return result;
		}
	}
}
