public class Solution {
    public int OrangesRotting(int[][] grid) {
        
        int freshCount = 0;

        int m = grid.Length;
        int n = grid[0].Length;
        var q = new Queue<(int, int)>();
        for(int i =0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == 1) freshCount++;
                if(grid[i][j] == 2) q.Enqueue((i, j));
            }
        }

        if(freshCount == 0) return 0;

        int minutes = 0;
        while(q.Count > 0 && freshCount > 0)
        {
            minutes++;
            int size = q.Count();

            for(int i = 0; i < size; i++)
            {

            
            var (x, y) = q.Dequeue();
            var directions = new int[4][]{ new int[2]{1 , 0}, new int[2]{-1 , 0}, new int[2]{0 , 1}, new int[2]{0 , -1}};
            foreach(var dir in directions)
            {
                var nx = x + dir[0];
                var ny = y + dir[1];

                if(nx < 0 || ny < 0 || nx  >= m || ny >= n)
                    continue;
                
                if(grid[nx][ny] == 0 || grid[nx][ny] == 2)
                    continue;
                
                grid[nx][ny] = 2;
                q.Enqueue((nx, ny));
                freshCount--;                
            }
            }            
        }

        return freshCount == 0 ? minutes : -1;


    }
}