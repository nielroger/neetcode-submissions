public class Solution {

    public Trie root;
    public class Trie
    {        
        public Trie[] children;
        public bool isEnd;
        public string word;
        public Trie()
        {            
            children = new Trie[26];
            isEnd = false;
            word = null;
        }
    }


    public void Insert(string word)
    {        
        var node = root;
        foreach(var letter in word)
        {            
            var index = letter - 'a';
            if(node.children[index] == null)
            {                
                node.children[index] = new Trie();
            }
            node = node.children[index];
        }
        node.isEnd = true;
        node.word = word;
    }

    public List<string> FindWords(char[][] board, string[] words) {        
        root = new Trie();
        foreach(var word in words)
        {            
            Insert(word);
        }

        var result = new List<string>();
        for(int i = 0; i < board.Length; i++)
        {            
            for(int j = 0; j < board[0].Length; j++)
            {                
                Search(board, root, i, j, new bool[board.Length, board[0].Length], result);
            }
        }

        return result;
    }

    public void Search(char[][] board, Trie node, int i, int j, bool[,] visited, List<string> result)
    {        
        if( i < 0 || j < 0 || i >= board.Length || j >= board[0].Length || visited[i,j] 
        || node.children[board[i][j] - 'a'] == null)
            return;

        node = node.children[board[i][j] - 'a'];
        if(node.word != null)
        {            
            result.Add(node.word);
            node.word = null;
        }

        visited[i,j] = true;
        Search(board, node, i + 1, j, visited, result);
        Search(board, node, i, j + 1, visited, result);
        Search(board, node, i - 1, j, visited, result);
        Search(board, node, i, j - 1, visited, result);
        visited[i,j] = false;
    }
}