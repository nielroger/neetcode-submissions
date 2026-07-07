public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        int m = board.Length;
        int n = board[0].Length;
        for(int i =0; i < m; i++)
        {
            var hsr = new HashSet<char>();
            var hsc = new HashSet<char>();
            var hsx = new HashSet<char>();
            for(int j = 0; j < n; j++)
            {
                
                if(board[i][j] != '.')
                {
                    if(!hsr.Add(board[i][j])) return false;
                }

                if(board[j][i] != '.')
                {
                    if(!hsc.Add(board[j][i])) return false;
                }

                int x = (i / 3) * 3 + j / 3;
                int y = (i % 3) * 3 + j % 3;

                if(board[x][y] != '.')
                {
                    if(!hsx.Add(board[x][y])) return false;
                }
            }
        }

        return true;
    }
}