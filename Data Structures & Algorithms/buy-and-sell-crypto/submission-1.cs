public class Solution {
    public int MaxProfit(int[] prices) {
        
        int left = int.MaxValue;
        int right = 0;
        int maxProfit = 0;
        for(int i = 0; i < prices.Length; i++)
        {
            if(prices[i] < left)
            {
                left = prices[i];
            }
            else
            {
                maxProfit = Math.Max(maxProfit, prices[i] - left);
            }
        }

        return maxProfit;
    }
}
