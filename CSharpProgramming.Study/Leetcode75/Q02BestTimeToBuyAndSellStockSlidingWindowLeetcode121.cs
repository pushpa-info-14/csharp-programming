namespace CSharpProgramming.Study.Leetcode75
{
    public class Q02BestTimeToBuyAndSellStockSlidingWindowLeetcode121
    {
        public int MaxProfit(int[] prices)
        {
            var left = 0;
            var right = 0;
            var maxProfit = 0;

            while (right < prices.Length)
            {
                if (prices[left] < prices[right])
                {
                    var profit = prices[right] - prices[left];
                    maxProfit = Math.Max(maxProfit, profit);
                }
                else
                {
                    left = right;
                }
                right++;
            }
            return maxProfit;
        }
    }
}
