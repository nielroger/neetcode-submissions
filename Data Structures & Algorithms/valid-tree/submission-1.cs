public class Solution {
    public bool ValidTree(int n, int[][] edges) {

        if(edges.Length != n - 1) return false;

        var adj = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            adj[i] = new List<int>();
        }
            

        var visited = new bool[n];
        foreach(var edge in edges)
        {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        var q = new Queue<int>();
        int count = 1;
        q.Enqueue(0);
        visited[0] = true;
        while(q.Count > 0)
        {
            var temp = q.Dequeue();

            foreach(var node in adj[temp])
            {
                if(visited[node]) continue;

                visited[node] = true;
                count++;
                q.Enqueue(node);
            }
        }


        return count == n;
    }
}
