public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        
        
        var q = new Queue<(int x, int y)>();
        for(int i = 0; i < grid.Length; i++)
        { 
            for(int j = 0; j < grid[0].Length; j++)
            { 
                if(grid[i][j] == 0)
                { 
                    q.Enqueue((i, j));
                }
            }
        }

        while(q.Count > 0)
        { 
            var(x, y) = q.Dequeue();
            var dirs = new List<int[]> { new int[]{1, 0}, new int[]{-1, 0}, new int[]{0, -1}, new int[]{0, 1} };
            foreach(var dir in dirs)
            { 
                int nx = x + dir[0];
                int ny = y + dir[1];

                if(nx < 0 || ny < 0 || nx >= grid.Length || ny >= grid[0].Length || grid[nx][ny] == -1)
                    continue;

                if(grid[nx][ny] <= grid[x][y] + 1)
                    continue;
                
                grid[nx][ny] = grid[x][y] + 1;
                q.Enqueue((nx, ny));
            }
        }
    }
}