public class Solution {
    public int CountComponents(int n, int[][] edges) {

        var visited = new int[n];
        var adj = new List<int>[n];
        for (int i = 0; i < n; i++) adj[i] = new List<int>();

        foreach(var edge in edges)
        { 
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        int count = 0;
        for(int i =0 ; i < n; i++)
        { 
            if(visited[i] == 0)
            { 
                count++;
                BFS(visited, adj, i);
            }
        }

        return count;
    }

    public void BFS(int[] visited, List<int>[] adj, int i)
    {
        visited[i] = 1;

        var q = new Queue<int>();
        q.Enqueue(i);

        while(q.Count > 0)
        {
            var temp = q.Dequeue();
            foreach(var item in adj[temp])
            {
                if(visited[item] == 0)
                {
                    visited[item] = 1;
                    q.Enqueue(item);
                }
            }
        }

        return ;
    }
}
