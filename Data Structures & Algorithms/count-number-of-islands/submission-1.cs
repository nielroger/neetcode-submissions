public class Solution {
    public int NumIslands(char[][] grid) {
        
        int m = grid.Length;
        int n = grid[0].Length;
        bool[,] visited = new bool[m,n];
        int count =0;
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(!visited[i,j] && grid[i][j] == '1')
                {
                    count++;
                    DFS(grid, i, j, visited);
                }
            }
        }

        return count;
    }

    public void DFS(char[][] grid, int i, int j, bool[,] visited)
    {
        if(i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || visited[i,j] || grid[i][j] == '0')
            return;

        visited[i,j] = true;
        DFS(grid, i + 1, j, visited);
        DFS(grid, i - 1, j, visited);
        DFS(grid, i, j + 1, visited);
        DFS(grid, i, j - 1, visited);
    }
}
