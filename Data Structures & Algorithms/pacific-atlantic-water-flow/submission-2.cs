public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        
        var result =  new List<List<int>>();

        int m = heights.Length;
        int n = heights[0].Length;
        var pacificMap = new bool[m,n];
        var atlanticMap = new bool[m,n];


        for(int i = 0; i < m; i++)
        {
            DFS(heights, i, 0, -1, pacificMap);            
        }
        for(int i = 0; i < n; i++)
        {
            DFS(heights, 0, i, -1, pacificMap);            
        }

        for(int i = 0; i < m; i++)
        {
            DFS(heights, i, n - 1, -1, atlanticMap);            
        }
        for(int i = 0; i < n; i++)
        {
            DFS(heights, m - 1, i, -1, atlanticMap);            
        }

        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(pacificMap[i,j] && atlanticMap[i,j])
                {
                    result.Add(new List<int>(){ i, j});
                }
            }
        }

        return result;

    }

    public void DFS(int[][] heights, int i, int j, int prevHeight, bool[,] map)
    {
        if(i < 0 || j < 0 ||  i >= heights.Length || j >= heights[0].Length || map[i,j] || heights[i][j] < prevHeight)
        {
            return;
        }

        map[i,j] = true;
        DFS(heights, i + 1, j, heights[i][j], map);
        DFS(heights, i - 1, j, heights[i][j], map);
        DFS(heights, i, j + 1, heights[i][j], map);
        DFS(heights, i, j - 1, heights[i][j], map);
    }
}