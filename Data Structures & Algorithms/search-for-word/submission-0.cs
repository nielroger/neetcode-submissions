public class Solution {
    public bool Exist(char[][] board, string word) {
        
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[0].Length; j++)
            {
                if(Search(board, i, j, 0, word))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public bool Search(char[][] board, int i, int j, int index, string word)
    {
        if(index == word.Length) 
            return true;
        
        if(i < 0 || j < 0 || i >= board.Length || j >= board[0].Length || word[index] != board[i][j])
            return false;
        
        char temp = board[i][j];
        board[i][j] = '#';

        bool found = Search(board, i + 1, j, index + 1, word) ||
                     Search(board, i, j + 1, index + 1, word) ||
                     Search(board, i - 1, j, index + 1, word) ||
                     Search(board, i, j - 1, index + 1, word);

        board[i][j] = temp;
        return found;
    }
}