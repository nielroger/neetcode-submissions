public class Solution {
    public void Solve(char[][] board) {
        

        for(int i = 0; i < board.Length; i++)
        {
            DFS(board, i, 0);
            DFS(board, i, board[0].Length - 1);
        }

        for(int i = 0; i < board[0].Length; i++)
        {
            DFS(board, 0, i);
            DFS(board, board.Length - 1, i);
        }

        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[0].Length; j++)
            {
                if(board[i][j] == 'S')
                {
                    board[i][j] = 'O';
                }
                else if(board[i][j] == 'O')
                {
                    board[i][j] = 'X';
                }
            }
        }
    }

    public void DFS(char[][] board, int i, int j)
    {
        if(i < 0  || j < 0 || i >= board.Length || j >= board[0].Length || board[i][j] != 'O')
        {
            return;
        }

        board[i][j] = 'S';
        DFS(board, i + 1, j);
        DFS(board, i - 1, j);
        DFS(board, i, j + 1);
        DFS(board, i, j - 1);
    }
}