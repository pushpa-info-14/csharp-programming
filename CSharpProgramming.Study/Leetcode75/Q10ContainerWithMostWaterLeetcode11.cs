namespace CSharpProgramming.Study.Leetcode75
{
    public class Q10ContainerWithMostWaterLeetcode11
    {
        public int MaxArea(int[] height)
        {
            var result = 0;
            var left = 0;
            var right = height.Length - 1;

            while (left < right)
            {
                result = Math.Max(result, (right - left) * Math.Min(height[left], height[right]));
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return result;
        }
    }
}
