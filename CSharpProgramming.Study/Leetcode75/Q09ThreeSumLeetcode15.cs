namespace CSharpProgramming.Study.Leetcode75
{
	public class Q09ThreeSumLeetcode15
	{
		public IList<IList<int>> ThreeSum(int[] nums)
		{
			var result = new List<IList<int>>();

			var sortedNums = nums.ToList();
			sortedNums.Sort();
			nums = sortedNums.ToArray();

			for (var i = 0; i < nums.Length; i++)
			{
				if (i > 0 && nums[i] == nums[i - 1])
				{
					continue;
				}

				var left = i + 1;
				var right = nums.Length - 1;
				while (left < right)
				{
					var sum = nums[i] + nums[left] + nums[right];
					if (sum > 0)
					{
						right--;
					}
					else if (sum < 0)
					{
						left++;
					}
					else
					{
						result.Add(new List<int>() { nums[i], nums[left], nums[right] });
						left++;
						while (nums[left] == nums[left - 1] && left < right)
						{
							left++;
						}
					}
				}
			}

			return result;
		}
	}
}
