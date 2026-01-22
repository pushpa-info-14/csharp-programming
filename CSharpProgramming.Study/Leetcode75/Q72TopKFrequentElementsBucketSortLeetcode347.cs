namespace CSharpProgramming.Study.Leetcode75
{
	public class Q72TopKFrequentElementsBucketSortLeetcode347
	{
		public int[] TopKFrequent(int[] nums, int k)
		{
			var dict = new Dictionary<int, int>();

			foreach (var num in nums)
			{
				dict.TryAdd(num, 0);
				dict[num]++;
			}

			var freq = new List<List<int>>();
			for (var i = 0; i < nums.Length + 1; i++)
			{
				freq.Add(new List<int>());
			}

			foreach (var pair in dict)
			{
				freq[pair.Value].Add(pair.Key);
			}

			var result = new List<int>();
			for (var i = freq.Count - 1; i > 0; i--)
			{
				foreach (var element in freq[i])
				{
					result.Add(element);
					if (result.Count == k)
					{
						return result.ToArray();
					}
				}
			}

			return result.ToArray();
		}
	}
}
