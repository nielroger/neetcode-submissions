public class Solution {
    public int SwimInWater(int[][] grid) {
        

        int n = grid.Length;
        var q = new PriorityQueue<(int row, int col), int>();

        var dirs = new List<int[]>() {new int[2]{1, 0}, new int[2]{-1, 0}, new int[2]{0, 1} ,new int[2]{0, -1}};
        var visited =  new bool[n,n];
        q.Enqueue((0, 0), grid[0][0]);
        visited[0, 0] = true;

        while(q.Count > 0)
        {
            q.TryDequeue(out var cell, out int t);

            int r = cell.row; int col = cell.col;
            if(r == n - 1 && col == n - 1) return t;

            foreach(var dir in dirs)
            {
                int nr = r + dir[0];
                int nc = col + dir[1];

                if(nr < 0 || nc < 0 || nr >= n || nc >= n || visited[nr,nc])
                    continue;
                
                visited[nr,nc] = true;
                q.Enqueue((nr, nc), Math.Max(t, grid[nr][nc]));
            }

        }

        return -1;
    }
}