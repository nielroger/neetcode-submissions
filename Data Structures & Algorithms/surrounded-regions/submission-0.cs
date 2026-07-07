public class Solution
{
    // Fix 1: 'var' not allowed on fields → must use explicit type
    public int[][] directions = new int[][]
    {
        new int[] { 1,  0 },
        new int[] { 0,  1 },
        new int[] {-1,  0 },
        new int[] { 0, -1 }
    }; // Fix 2: missing semicolon

    public void Solve(char[][] board)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        // Fix 3: Removed the first two marking loops entirely
        // They marked border 'O' → 'S' BEFORE BFS checked for 'O'
        // So BFS never triggered (it was looking for 'O' but found 'S')

        for (int i = 0; i < rows; i++)
        {
            // Fix 4: col → cols
            // Fix 5: board[i][0] = 'S' was wrong index, should be board[i][cols-1]
            if (board[i][0] == 'O')        BFS(board, i, 0,        rows, cols);
            if (board[i][cols - 1] == 'O') BFS(board, i, cols - 1, rows, cols);
        }

        for (int i = 0; i < cols; i++)
        {
            if (board[0][i] == 'O')        BFS(board, 0,        i, rows, cols);
            if (board[rows - 1][i] == 'O') BFS(board, rows - 1, i, rows, cols);
        }

        // Fix 6: Merged the two final loops into one
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == 'O') board[i][j] = 'X';
                if (board[i][j] == 'S') board[i][j] = 'O';
            }
        }
    }

    public void BFS(char[][] board, int i, int j, int rows, int cols)
    {
        var q = new Queue<(int x, int y)>();

        // Fix 7: Mark starting cell as 'S' before enqueuing
        // Without this, the starting border cell was never marked safe
        board[i][j] = 'S';
        q.Enqueue((i, j));

        while (q.Count > 0)
        {
            var (x, y) = q.Dequeue();

            foreach (var dir in directions)
            {
                int nx = x + dir[0];
                int ny = y + dir[1];

                // Fix 8: 'rows' and 'cols' were out of scope here → use parameters
                if (nx < 0 || nx >= rows || ny < 0 || ny >= cols)
                    continue;

                if (board[nx][ny] != 'O')
                    continue;

                board[nx][ny] = 'S';
                q.Enqueue((nx, ny));
            }
        }
    }
}