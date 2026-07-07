public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        
        var dist = new int[n + 1];
        Array.Fill(dist, int.MaxValue);

        dist[k] = 0;
        var q = new Queue<int>();

        var adj = new List<int[]>[n + 1];
        for(int i = 0; i <= n; i++) adj[i] = new List<int[]>();
        foreach(var time in times)
        {
            adj[time[0]].Add(new int[] {time[1], time[2]});
        }

        q.Enqueue(k);        
        while(q.Count > 0)
        {
            var u = q.Dequeue();

            foreach(var edge in adj[u])
            {
                int v = edge[0], w = edge[1];
                if (dist[u] + w < dist[v]) {
                    dist[v] = dist[u] + w;
                    q.Enqueue(v);
                }
            }
        }

        int maxDist = 0;
        for (int i = 1; i <= n; i++) {
            if (dist[i] == int.MaxValue) return -1;
            maxDist = Math.Max(maxDist, dist[i]);
        }
        return maxDist;
    }
}