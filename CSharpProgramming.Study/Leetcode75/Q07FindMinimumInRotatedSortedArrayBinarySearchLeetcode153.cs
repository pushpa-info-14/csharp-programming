﻿namespace CSharpProgramming.Study.Leetcode75
{
    public class Q07FindMinimumInRotatedSortedArrayBinarySearchLeetcode153
    {
        public int FindMin(int[] nums)
        {
            var result = nums[0];
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] < nums[right])
                {
                    result = Math.Min(result, nums[left]);
                    break;
                }
                var mid = (left + right) / 2;
                result = Math.Min(result, nums[mid]);
                if (nums[mid] >= nums[left])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }
}
