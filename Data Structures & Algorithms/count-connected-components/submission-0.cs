public class Solution {

    public int[] visited;
    public List<int>[] adj;
    public int CountComponents(int n, int[][] edges) {

        visited = new int[n];
        adj = new List<int>[n];

        for(int i =0; i < n; i++)
        {
            adj[i] = new List<int>();
        }

        foreach(var edge in edges)
        {
            adj[edge[1]].Add(edge[0]);
            adj[edge[0]].Add(edge[1]);
        }

        int count = 0;
        for(int i = 0; i < n; i++)
        {
            if(visited[i] == 0)
            {
                count++;
                BFS(adj, i);                
            }
        }

        return count;
    }

    public void BFS(List<int>[] adj, int node)
    {

        var q = new Queue<int>();
        q.Enqueue(node);
        visited[node] = 1;
        while(q.Count > 0)
        {
            var temp = q.Dequeue();
            foreach(var edge in adj[temp])
            {
                if(visited[edge] == 1)
                {
                    continue;
                }
                visited[edge] = 1;
                q.Enqueue(edge);
            }
        }        
    }
}
