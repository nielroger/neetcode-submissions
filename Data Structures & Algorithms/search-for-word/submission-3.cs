public class Solution {
    public bool Exist(char[][] board, string word) {
        

        for(int i = 0 ; i < board.Length; i++)
        {
            for(int j = 0; j < board[0].Length; j++)
            {
                if(board[i][j] == word[0] && Exist(board, word, i, j, 0))
                {
                    return true;
                }
            }
        }

        return false;
    }
    
    public bool Exist(char[][] board, string word, int i, int j, int index)
    {
        if(index == word.Length) return true;

        if(i < 0 || j < 0 || i >= board.Length || j >= board[0].Length || board[i][j] != word[index])
        {
            return false;
        }

        char temp = board[i][j];
        board[i][j] = '#';
        bool found = Exist(board, word, i + 1, j, index + 1) ||
        Exist(board, word, i, j + 1, index + 1) ||
        Exist(board, word, i - 1, j, index + 1) ||
        Exist(board, word, i, j - 1, index + 1) ;
        board[i][j] = temp;

        return found;
    }
}