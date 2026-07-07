public class Solution
{
    private static readonly int[][] Directions = new int[][]
    {
        new int[] {0,  1},
        new int[] {0, -1},
        new int[] {1,  0},
        new int[] {-1, 0}
    };

    public List<List<int>> PacificAtlantic(int[][] heights)
    {
        int rows = heights.Length;
        int cols = heights[0].Length;

        bool[,] pacificReachable  = new bool[rows, cols];
        bool[,] atlanticReachable = new bool[rows, cols];

        Queue<int[]> pacificQueue  = new Queue<int[]>();
        Queue<int[]> atlanticQueue = new Queue<int[]>();

        for (int r = 0; r < rows; r++)
        {
            pacificQueue.Enqueue(new int[] { r, 0 });
            pacificReachable[r, 0] = true;

            atlanticQueue.Enqueue(new int[] { r, cols - 1 });
            atlanticReachable[r, cols - 1] = true;
        }

        for (int c = 0; c < cols; c++)
        {
            pacificQueue.Enqueue(new int[] { 0, c });
            pacificReachable[0, c] = true;

            atlanticQueue.Enqueue(new int[] { rows - 1, c });
            atlanticReachable[rows - 1, c] = true;
        }

        BFS(heights, pacificQueue,  pacificReachable,  rows, cols);
        BFS(heights, atlanticQueue, atlanticReachable, rows, cols);

        var result = new List<List<int>>();

        for (int r = 0; r < rows; r++)
            for (int c = 0; c < cols; c++)
                if (pacificReachable[r, c] && atlanticReachable[r, c])
                    result.Add(new List<int> { r, c });

        return result;
    }

    private void BFS(int[][] heights, Queue<int[]> queue, bool[,] reachable, int rows, int cols)
    {
        while (queue.Count > 0)
        {
            int[] cell = queue.Dequeue();
            int r = cell[0];
            int c = cell[1];

            foreach (int[] dir in Directions)
            {
                int newRow = r + dir[0];
                int newCol = c + dir[1];

                if (newRow < 0 || newRow >= rows || newCol < 0 || newCol >= cols)
                    continue;

                if (reachable[newRow, newCol])
                    continue;

                if (heights[newRow][newCol] < heights[r][c])
                    continue;

                reachable[newRow, newCol] = true;
                queue.Enqueue(new int[] { newRow, newCol });
            }
        }
    }
}