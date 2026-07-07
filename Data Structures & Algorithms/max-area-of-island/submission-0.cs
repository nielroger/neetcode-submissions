public class Solution {

    int maxArea = 0;
    public int MaxAreaOfIsland(int[][] grid) {
        bool[,] visited = new bool[grid.Length, grid[0].Length];
        for(int i  = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == 1 && !visited[i, j])
                {
                    maxArea = Math.Max(maxArea, DFS(grid, i, j, visited));
                }
            }
        }

        return maxArea;
    }

    public int DFS(int[][] grid, int i, int j, bool[,] visited)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == 0 || visited[i, j])
            return 0;

        visited[i,j] = true;
        int count = 1;
        
        count += DFS(grid, i + 1, j, visited);
        count += DFS(grid, i, j + 1, visited);
        count += DFS(grid, i - 1, j, visited);
        count += DFS(grid, i, j - 1, visited);
        
        return count;
    }
}