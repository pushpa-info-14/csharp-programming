namespace CSharpProgramming.Study.Leetcode75
{
    public class Q1TwoSumInputArrayIsSortedLeetcode167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var result = new int[2];
            var left = 0;
            var right = numbers.Length - 1;

            while (left < right)
            {
                var summation = numbers[left] + numbers[right];
                if (summation < target)
                {
                    left++;
                }
                else if (summation > target)
                {
                    right--;
                }
                else
                {
                    result[0] = left + 1;
                    result[1] = right + 1;
                    return result;
                }
            }

            return result;
        }
    }
}
