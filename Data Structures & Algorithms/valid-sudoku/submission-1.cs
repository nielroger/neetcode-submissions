public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        int rows = board.Length;
        int cols = board[0].Length;

        for(int i = 0; i < rows; i++)
        {
            var hsr = new HashSet<char>();
            var hsc = new HashSet<char>();
            var hsx = new HashSet<char>();

            for(int j = 0; j < cols; j++)
            {
                if(board[i][j] != '.' && !hsr.Add(board[i][j])) return false;
                if(board[j][i] != '.' && !hsc.Add(board[j][i])) return false;

                int r = (i / 3) * 3 + j / 3;
                int c = (i % 3) * 3 + j % 3;

                if(board[r][c] != '.' && !hsx.Add(board[r][c])) return false;
            }
        }

        return true;
    }
}