public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        int[] prices = new int[n];
        Array.Fill(prices, int.MaxValue);
        prices[src] = 0;

        for (int i = 0; i <= k; i++) {
            int[] tempPrices = (int[])prices.Clone();
            foreach (var flight in flights) {
                int u = flight[0];
                int v = flight[1];
                int price = flight[2];
                if (prices[u] != int.MaxValue) {
                    tempPrices[v] = Math.Min(tempPrices[v], prices[u] + price);
                }
            }
            prices = tempPrices;
        }

        return prices[dst] == int.MaxValue ? -1 : prices[dst];
    }
}