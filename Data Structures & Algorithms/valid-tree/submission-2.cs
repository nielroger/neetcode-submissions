public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        
        if(n - 1 != edges.Length) return false;

        var adj = new List<int>[n];
        for(int i = 0; i < n; i++)
        {
            adj[i] = new List<int>();
        }

        foreach(var edge in edges)
        {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        var visited = new bool[n];

        int count = 1;

        var q = new Queue<int>();
        q.Enqueue(0);
        visited[0] = true;
        while(q.Count > 0)
        {
            var temp = q.Dequeue();
            foreach(var item in adj[temp])
            {
                if(visited[item]) continue;

                visited[item] = true;
                count++;
                q.Enqueue(item);
            }
        }

        return count == n;

    }
}
