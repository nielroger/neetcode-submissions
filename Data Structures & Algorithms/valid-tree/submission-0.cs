public class Solution
{
    public bool ValidTree(int n, int[][] edges)
    {
        // Step 1: A valid tree must have exactly n - 1 edges
        if (edges.Length != n - 1) return false;

        // Step 2: Build adjacency list (undirected → both directions)
        var adj = new List<int>[n];
        for (int i = 0; i < n; i++)
            adj[i] = new List<int>();

        foreach (var edge in edges)
        {
            int a = edge[0];
            int b = edge[1];
            adj[a].Add(b);
            adj[b].Add(a);  // undirected → add both ways
        }

        // Step 3: BFS from node 0, count visited nodes
        var visited = new bool[n];
        var q = new Queue<int>();

        q.Enqueue(0);
        visited[0] = true;
        int count = 1;

        while (q.Count > 0)
        {
            int node = q.Dequeue();

            foreach (int neighbor in adj[node])
            {
                if (visited[neighbor]) continue;

                visited[neighbor] = true;
                q.Enqueue(neighbor);
                count++;
            }
        }

        // Step 4: All nodes must be visited
        return count == n;
    }
}