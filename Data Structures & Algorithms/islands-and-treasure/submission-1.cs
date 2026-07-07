public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == 0)
                {
                    DFS(grid, i, j, 0);
                }
            }
        }
    }

    public void DFS(int[][] grid, int i, int j, int dist)
    {
        if(i < 0 || j < 0  || i >= grid.Length || j >= grid[0].Length || grid[i][j] == -1 || (dist > 0 && grid[i][j] <= dist))
        {
            return;
        }

        grid[i][j] = dist;

        DFS(grid, i + 1, j, dist + 1);
        DFS(grid, i - 1, j, dist + 1);
        DFS(grid, i, j + 1, dist + 1);
        DFS(grid, i, j - 1, dist + 1);
    }
}