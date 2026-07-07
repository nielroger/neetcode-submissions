public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == 0)
                {
                    BFS(grid, i, j);
                }
            }
        }
    }

    public void BFS(int[][] grid, int i, int j)
    {
        var q = new Queue<(int i, int j)>();
        q.Enqueue((i, j));

        var visited = new bool[grid.Length, grid[0].Length];
        visited[i,j] = true;
        while(q.Count > 0)
        {
            var (x, y) = q.Dequeue();

            var dir = new int[4][] { new int[2] {1 , 0}, new int[2] { -1 , 0}, new int[2] {0 , 1} ,new int[2] {0 , -1}};
            foreach(var direction in dir)
            {
                int nx = x + direction[0];
                int ny = y + direction[1];

                if(nx < 0 || ny < 0 || nx >= grid.Length || ny >= grid[0].Length
                || grid[nx][ny] == -1 || grid[nx][ny] == 0 || visited[nx, ny])
                    continue;
                
                grid[nx][ny] = Math.Min(grid[nx][ny], grid[x][y] + 1);
                q.Enqueue((nx, ny));
                visited[nx, ny] = true;

            }
        }
    }
}