public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        
        int maxArea = 0;
        var visited = new bool[grid.Length, grid[0].Length];
        for(int i = 0 ; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == 1 && !visited[i,j])
                {
                    int currArea = MaxArea(grid, i, j, visited);
                    maxArea = Math.Max(maxArea, currArea);
                }
            }
        }

        return maxArea;
    }

    public int MaxArea(int[][] grid, int i, int j, bool[,] visited)
    {
        if(i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || visited[i,j] || grid[i][j] == 0)
        {
            return 0;
        }

        int result = 1;
        visited[i,j] = true;
        result += MaxArea(grid, i + 1, j, visited);
        result += MaxArea(grid, i - 1, j, visited);
        result += MaxArea(grid, i, j + 1, visited);
        result += MaxArea(grid, i, j - 1, visited);

        return result;
    }
}
