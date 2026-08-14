public class Solution {
     public int NetworkDelayTime(int[][] times, int n, int k) {
        
        var netTime = new int[n + 1];
        Array.Fill(netTime, int.MaxValue);
        netTime[k] = 0;

        var graph = new Dictionary<int, List<int[]>>();

        foreach(var time in times)
        {
            int from = time[0];
            int to = time[1];
            int cost = time[2];

            if(!graph.ContainsKey(from))
            {
                graph[from] = new List<int[]>();
            }

            graph[from].Add(new int[]{ to, cost });
        }

        var q = new Queue<int>();
        q.Enqueue(k);

        while(q.Count > 0)
        {
            var src = q.Dequeue();

            if(!graph.ContainsKey(src))
                continue;

            foreach(var node in graph[src])
            {
                var dst = node[0];
                var cost = node[1];

                if(netTime[src] + cost < netTime[dst])
                {
                    netTime[dst] = netTime[src] + cost;
                    q.Enqueue(dst);
                }
            }
        }

        int maxTime = 0;

        for(int i = 1; i <= n; i++)
        {
            if(netTime[i] == int.MaxValue)
                return -1;

            maxTime = Math.Max(maxTime, netTime[i]);
        }

        return maxTime;
    }
}
