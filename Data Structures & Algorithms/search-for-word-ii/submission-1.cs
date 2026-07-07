public class Trie{

    public Trie[] child;
    public bool isEnd;
    public string word;
    public Trie()
    {
        child = new Trie[26];
        isEnd = false;
        word = string.Empty;
    }

}

public class Solution {

    Trie root;
    public Solution()
    {
        root = new Trie();
    }

    public void AddWord(string word)
    {
        var node = root;

        foreach(var letter in word)
        {
            int index = letter - 'a';
            if(node.child[index] == null)
            {
                node.child[index] = new Trie();
            }
            node = node.child[index];
        }

        node.isEnd = true;
        node.word = word;
    }

    public List<string> FindWords(char[][] board, string[] words) {

        var node = root;
        var result = new List<string>();
        foreach(var word in words)
        {
            AddWord(word);
        }

        bool[,] visited = new bool[board.Length, board[0].Length];
        for(int i =0;  i < board.Length; i++)
        {
            for(int j = 0; j< board[0].Length; j++)
            {
                Search(board, i, j, node, result, visited);
            }
        }
        return result;
    }

    public void Search(char[][] board, int i, int j, Trie node, List<string> result, bool[,] visited)
    {
        if(i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || visited[i, j]) return;

        var letter = board[i][j];
        var nextNode = node.child[letter - 'a'];
        if(nextNode == null) return;

        if(!string.IsNullOrEmpty(nextNode.word))
        {
            result.Add(nextNode.word);
            nextNode.word = string.Empty;
        }

        visited[i,j] = true;
        Search(board, i + 1, j, nextNode, result, visited);
        Search(board, i - 1, j, nextNode, result, visited);
        Search(board, i, j + 1, nextNode, result, visited);
        Search(board, i, j - 1, nextNode, result, visited);
        visited[i,j] = false;
    }
}