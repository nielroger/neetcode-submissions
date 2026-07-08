public class Solution {
    public int CoinChange(int[] coins, int amount) {
        
        int[] map = new int[amount + 1];        
        Array.Fill(map, int.MaxValue);
        map[0] = 0;
        for(int i =1; i <= amount; i++)
        {
            for(int j = 0; j < coins.Length; j++)
            {
                if(coins[j] <= i && map[i - coins[j]] != int.MaxValue)
                {
                    map[i] = Math.Min(map[i], 1 + map[i - coins[j]]);
                }
            }
        }

        return map[amount] == int.MaxValue ? -1 : map[amount];
    }
}
