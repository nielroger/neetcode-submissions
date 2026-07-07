public class Solution {
    public int OrangesRotting(int[][] grid) {
        

        int freshCount = 0;
        var q = new Queue<(int r, int c)>();
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == 1) freshCount++;
                else if(grid[i][j] == 2) q.Enqueue((i,j));
            }
        }

        if(freshCount == 0) return 0;
        int minutes = -1;

        while(q.Count > 0)
        {

            int size = q.Count;
            minutes++;
            for(int i = 0; i < size; i++)
            {
                var (x, y) = q.Dequeue();

                var dirs = new List<int[]>(){new int[2]{1, 0} , new int[2]{-1, 0}, new int[2]{0, 1}, new int[2]{0, -1}};
                
                foreach(var dir in dirs)
                {
                    int nx = x + dir[0];
                    int ny = y + dir[1];

                    if(nx < 0 || ny < 0 || nx >= grid.Length || ny >= grid[0].Length || grid[nx][ny] == 0 || grid[nx][ny] == 2)
                        continue;
                
                    grid[nx][ny] = 2;
                    freshCount--;
                    q.Enqueue((nx, ny));

                }
            }
            
        }

        return freshCount == 0 ? minutes : -1;

    }
}