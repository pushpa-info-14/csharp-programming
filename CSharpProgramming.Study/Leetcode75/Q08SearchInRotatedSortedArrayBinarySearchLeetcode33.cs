namespace CSharpProgramming.Study.Leetcode75
{
    public class Q08SearchInRotatedSortedArrayBinarySearchLeetcode33
    {
        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[left] <= nums[mid])
                {
                    if (nums[mid] < target || nums[left] > target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    if (target < nums[mid] || target > nums[right])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }

            return -1;
        }
    }
}
