public class Solution {
    public void Solve(char[][] board) {
        
        int m = board.Length;
        int n = board[0].Length;
        for(int i = 0; i < m; i++)
        { 
            if(board[i][0] == 'O') DFS(board, i, 0);
            if(board[i][n - 1] == 'O') DFS(board, i, n -1);
        }

        for(int i = 0; i < n; i++)
        {
            if(board[0][i] == 'O') DFS(board, 0, i);
            if(board[m - 1][i] == 'O')DFS(board, m - 1, i);
        }


        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j <  n; j++)
            {
                if(board[i][j] == 'O') board[i][j] = 'X';
                else if(board[i][j] == 'S') board[i][j] = 'O';
            }
        }
    }

    public void DFS(char[][] board, int i, int j)
    {
        if(i < 0 || j < 0 || i >= board.Length || j >= board[0].Length || board[i][j] != 'O')
        {
            return;
        }

        board[i][j] ='S';
        DFS(board, i + 1, j);
        DFS(board, i - 1, j);
        DFS(board, i, j + 1);
        DFS(board, i, j - 1);
    }
}