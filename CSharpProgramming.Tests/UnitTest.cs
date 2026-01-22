using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests;

public class UnitTest
{
	private readonly ITestOutputHelper _outputHelper;

	public UnitTest(ITestOutputHelper testOutputHelper)
	{
		_outputHelper = testOutputHelper;
	}

	[Fact]
	public void Test1()
	{
		var hashSet = new HashSet<string>();
		hashSet.Add("12");

		var answer = hashSet.Contains("12");

		Assert.True(answer);

		var tupleHashSet = new HashSet<Tuple<int, int>>();
		tupleHashSet.Add(new Tuple<int, int>(1, 1));

		answer = tupleHashSet.Contains(new Tuple<int, int>(1, 1));

		Assert.True(answer);
	}

	[Fact]
	public void LeetcodeTest()
	{
		//int[] array = [11, 10, 9, 8, 7, 6, 5, 4, 3, 3, 3, 3, 3, 3, 2, 1, 1, 1, 0, 0, 0, -1, -2, -2, -3, -4, -15, -15, -15];
		//Array.Sort(array);

		//int[] array = [-2, -1, -1, -1, 0, 0, 0, 9, 10, 11];
		int[] array = [2, 2];
		//int[] array = [-1, 0, 0, 9, 10, 11];
		//int[] array = [-1, -1, 0, 0, 1, 2, 9, 10, 11];
		//int[] array = [-2, -1, 1, 1];
		//int[] array = [10, 9, 9, 7, 6, 5, 5, 4, 2, -8, -9, -10, -11, -11, -12, -13, -13, -13, -13, -14, -14, -15, -15, -16, -16, -16, -16, -17, -17];
		//Array.Sort(array);

		//var r = SearchInsert(array, 0);
		var r = SearchInsert2(array, 0);
		//_outputHelper.WriteLine(array.Length + "");
		//_outputHelper.WriteLine(r + "");
		//_outputHelper.WriteLine((array.Length - r) + "");
	}

	int SearchInsert2(int[] nums, int target)
	{
		var low = 0;
		var high = nums.Length - 1;

		if (target < nums[0]) return -1;
		if (target > nums[high]) return -1;

		while (low != high)
		{
			var mid = low + (high - low) / 2;

			if (target < nums[mid])
			{
				high = mid - 1;
			}
			else if (target > nums[mid])
			{
				low = mid + 1;
			}
			else
			{
				high = mid;
			}
		}

		_outputHelper.WriteLine(low + "--" + high);
		_outputHelper.WriteLine("start: " + high);

		low = 0;
		high = nums.Length - 1;

		while (low != high)
		{
			var mid = low + (high - low) / 2;

			if (target < nums[mid])
			{
				high = mid - 1;
			}
			else if (target > nums[mid])
			{
				low = mid + 1;
			}
			else
			{
				if (target == nums[mid + 1])
				{
					low = mid + 1;
				}
				else
				{
					high = mid;
				}
			}
		}

		_outputHelper.WriteLine(low + "--" + high);
		_outputHelper.WriteLine("end  : " + high);
		return -1;
	}

	int SearchInsert(int[] nums, int target)
	{
		var low = 0;
		var high = nums.Length - 1;

		if (target <= nums[low]) return low;

		while (low <= high)
		{
			var mid = low + (high - low) / 2;

			if (target < nums[mid]) high = mid - 1;
			else if (target > nums[mid]) low = mid + 1;
			else high = mid - 1;

			if (low > high) return high + 1;
		}

		return -1;
	}
}
