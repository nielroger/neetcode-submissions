public class Solution {
    public int NumIslands(char[][] grid) {
        
        var visited = new bool[grid.Length, grid[0].Length];
        int count = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == '1' && !visited[i,j])
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

        visited[i,j] = true;
        var q = new Queue<(int x, int y)>();
        q.Enqueue((i,j));

        while(q.Count > 0)
        {
            var (x, y) = q.Dequeue();

            var dirs = new List<int[]>(){new int[2]{1,0}, new int[2]{-1,0}, new int[2]{0,1}, new int[2]{0,-1}};

            foreach(var dir in dirs)
            {
                int nx = x + dir[0];
                int ny = y + dir[1];

                if(nx < 0 || ny < 0 || nx >= grid.Length || ny >= grid[0].Length || visited[nx, ny] || grid[nx][ny] == '0')
                    continue;
                
                visited[nx, ny] = true;
                q.Enqueue((nx, ny));
            }
        }
    }

}