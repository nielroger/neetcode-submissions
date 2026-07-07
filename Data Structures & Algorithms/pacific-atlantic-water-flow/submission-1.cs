public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        
        var result = new List<List<int>>();
        var pacificQ = new Queue<(int i, int j)>();
        var atlanticQ = new Queue<(int i, int j)>();
        
        int m = heights.Length;
        int n = heights[0].Length;
        var pacificMap = new bool[m,n];
        var atlanticMap = new bool[m,n];
        for(int i = 0; i < m; i++)
        {
            pacificQ.Enqueue((i, 0));
            atlanticQ.Enqueue((i, n - 1));
        }

        for(int i = 0; i < n; i++)
        {
            pacificQ.Enqueue((0, i));
            atlanticQ.Enqueue((m - 1, i));
        }

        BFS(pacificQ, heights, pacificMap);
        BFS(atlanticQ, heights, atlanticMap);

        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(pacificMap[i,j] && atlanticMap[i,j])
                {
                    result.Add(new List<int>(){i,j});
                }
            }
        }

        return result;

    }

    public void BFS(Queue<(int i, int j)> queue, int[][] heights, bool[,] map)
    {
        foreach(var cell in queue) map[cell.i, cell.j] = true;
        while(queue.Count > 0)
        {
            var (x, y) = queue.Dequeue();

            int[][] directions = new int[][] { new int[]{1, 0}, new int[]{-1, 0}, new int[]{0, 1}, new int[]{0, -1} };
            foreach(var dir in directions)
            {
                int nx = x + dir[0]; int ny = y + dir[1]; 
                if(nx < 0 || ny < 0 || nx >= heights.Length || ny >= heights[0].Length)
                    continue;
                
                if(map[nx, ny] == true || heights[nx][ny] < heights[x][y])
                    continue;
                
                map[nx,ny] = true;
                queue.Enqueue((nx, ny));
            }
        }
    }
}