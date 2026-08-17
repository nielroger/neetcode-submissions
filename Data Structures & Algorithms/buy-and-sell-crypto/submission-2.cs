public class Solution {
    public int MaxProfit(int[] prices) {
        
        int[] largest = new int[prices.Length];

        int max = 0;
        for(int i = prices.Length - 1; i >= 0; i--)
        {
            max = Math.Max(max, prices[i]);
            largest[i] = max;
        }

        int diff = 0;
        for(int i = 0; i < prices.Length; i++)
        {
            diff = Math.Max(diff, largest[i] - prices[i]);
        }

        return diff;
    }
}
