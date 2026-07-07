public class Solution {
    
    int m;
    int n;
    public bool Exist(char[][] board, string word) {

        m = board.Length;
        n = board[0].Length;
        bool[,] visited = new bool[m,n];
        if(string.IsNullOrEmpty(word)) return false;

        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[0].Length; j++)
            {
                if(Exist(board, visited, i, j, word, 0))
                    return true;
            }
        }

        return false;

    }

    public bool Exist(char[][] board, bool[,] visited, int i, int j, string word, int index)
    {
        if(index == word.Length) return true;

        if(i < 0 || j < 0 || i >= m || j >= n || visited[i,j] || board[i][j] != word[index]) 
            return false;
        
        visited[i,j] = true;


        var result = Exist(board, visited, i + 1, j, word, index + 1) ||
                     Exist(board, visited, i - 1, j, word, index + 1) ||
                     Exist(board, visited, i, j + 1, word, index + 1) ||
                     Exist(board, visited, i, j - 1, word, index + 1);
        visited[i,j] = false;
        return result;
    }
}