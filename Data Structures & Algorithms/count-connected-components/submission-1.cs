public class Solution {
    
    public int CountComponents(int n, int[][] edges) {
        
        var visited = new int[n];
        var adj =  new List<int>[n];

        for(int i = 0; i < n; i++)
        {
            adj[i] = new List<int>();
        }
        foreach(var edge in edges)
        {
            adj[edge[1]].Add(edge[0]);
            adj[edge[0]].Add(edge[1]);
        }

        int count = 0;

        for(int i =0; i < n; i++)
        {
            if(visited[i] == 0)
            {
                count++;
                BFS(adj,  visited, i);
            }
        }

        return count;

    }

    public void BFS(List<int>[] adj, int[] visited, int i)
    {
        var q = new Queue<int>();
        q.Enqueue(i);
        visited[i] = 1;
        while(q.Count > 0)
        {
            var temp = q.Dequeue();

            foreach(var neighbor in adj[temp])
            {
                if(visited[neighbor] == 1)
                    continue;
                
                q.Enqueue(neighbor);
                visited[neighbor] = 1;
            }
        }


    }
}
