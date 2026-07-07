public class Solution {
    public int SwimInWater(int[][] grid) {
        int n = grid.Length;
        var pq = new PriorityQueue<(int r, int c), int>();
        bool[,] visited = new bool[n, n];

        var dirs = new int[4][]{new int[2]{0,1}, new int[2]{1,0}, new int[2]{-1, 0}, new int[2]{0,-1}};

        pq.Enqueue((0, 0), grid[0][0]);
        visited[0, 0] = true;

        while(pq.Count > 0)
        {
            pq.TryDequeue(out var cell, out int t);

            int r = cell.r; int c = cell.c;
            if(r == n - 1 && c == n - 1) return t;
            foreach(var dir in dirs)
            {
                int nr = r + dir[0];
                int nc = c + dir[1];

                if(nr < 0 || nc < 0 || nr >= n || nc >= n || visited[nr,nc]) continue;
                
                visited[nr,nc] = true;
                pq.Enqueue((nr, nc), Math.Max(t, grid[nr][nc]));
            }
        
        }

        return -1;
    }
}