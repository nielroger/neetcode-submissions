public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        
        
        int n = points.Length;
        if(n <= 0) return 0;

        int totalCost = 0;
        var minDist = new int[n];
        var inMST = new bool[n];

        Array.Fill(minDist, int.MaxValue);
        minDist[0] = 0;

        for(int i =0; i < n; i++)
        {            
            int u = -1;

            for(int v = 0; v < n; v++)
            {                if(!inMST[v] && ((u == -1) || minDist[v] < minDist[u]))
                {
                    u = v;
                }
            }

            inMST[u] = true;
            totalCost += minDist[u];
            for(int v = 0; v < n; v++)
            {                if(!inMST[v])
                {
                    int dist = Math.Abs(points[u][0] - points[v][0]) + Math.Abs(points[u][1] - points[v][1]);
                    if(dist < minDist[v])
                    {
                        minDist[v] = dist;
                    }
                }
            }
        }

        return totalCost;
    }
}