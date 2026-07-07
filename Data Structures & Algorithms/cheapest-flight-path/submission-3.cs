public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        
        var dist = new int[n];
        Array.Fill(dist, int.MaxValue);
        dist[src] = 0;

        for(int i = 0; i <= k; i++)
        {            
            var temp = (int[])dist.Clone();

            foreach(var flight in flights)
            { 
                int from = flight[0];
                int to = flight[1];
                int price = flight[2];

                if(dist[from] != int.MaxValue)
                { 
                    temp[to] = Math.Min(temp[to], dist[from] + price);
                }
            }

            dist = temp;
        }

        return dist[dst] == int.MaxValue ? -1 : dist[dst];
    }
}