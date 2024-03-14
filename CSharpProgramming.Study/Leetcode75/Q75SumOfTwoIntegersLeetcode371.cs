namespace CSharpProgramming.Study.Leetcode75
{
    public class Q75SumOfTwoIntegersLeetcode371
    {
        public int GetSum(int a, int b)
        {
            while (b != 0)
            {
                var temp = a ^ b;
                b = (a & b) << 1;
                a = temp;
            }
            return a;
        }
    }
}
