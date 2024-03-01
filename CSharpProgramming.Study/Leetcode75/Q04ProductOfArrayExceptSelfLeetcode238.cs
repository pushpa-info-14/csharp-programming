﻿namespace CSharpProgramming.Study.Leetcode75
{
    public class Q04ProductOfArrayExceptSelfLeetcode238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            var prefix = 1;
            for (var i = 0; i < nums.Length; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            var postfix = 1;
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= postfix;
                postfix *= nums[i];
            }

            return result;
        }
    }
}
