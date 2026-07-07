public class Solution {
    public int NumIslands(char[][] grid) {
        
        int count = 0;
        var visited = new bool[grid.Length, grid[0].Length];
        for(int i =0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == '1' && !visited[i, j])
                {
                    count++;
                    BFS(grid, i, j, visited);
                }
            }
        }
        return count;
    }

    public void BFS(char[][] grid, int i, int j, bool[,] visited)
    {

        var q = new Queue<(int x, int y)>();
        q.Enqueue((i , j));
        visited[i, j] = true;

        while(q.Count > 0)
        {
            var (x, y) = q.Dequeue();
            if(x + 1 < grid.Length && grid[x + 1][y] == '1' && !visited[x + 1, y]) { visited[x + 1, y] = true; q.Enqueue((x + 1, y)); }
            if(y + 1 < grid[0].Length && grid[x][y + 1] == '1' && !visited[x, y + 1]) { visited[x, y + 1] = true; q.Enqueue((x, y + 1)); }
            if(x - 1 >= 0 && grid[x - 1][y] == '1' && !visited[x - 1, y] ) { visited[x - 1, y] = true; q.Enqueue((x - 1, y)); }
            if(y - 1 >= 0 && grid[x][y - 1] == '1' && !visited[x, y - 1]) { visited[x, y - 1] = true; q.Enqueue((x, y - 1)); }
        }

    }
}