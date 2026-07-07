public class PrefixTree {

    public class Trie
    {
        public Trie[] children;
        public bool isEnd;

        public Trie()
        {
            children = new Trie[26];
            isEnd = false;
        }
    }

    Trie root;
    public PrefixTree() {
        root = new Trie();
    }
    
    public void Insert(string word) {
        
        var node = root;

        foreach(var letter in word)
        {
            if(node.children[letter - 'a'] == null)
            {
                node.children[letter - 'a'] = new Trie();
            }
            node = node.children[letter - 'a'];
        }
        node.isEnd = true;
    }
    
    public bool Search(string word) {
        
        var node = root;

        foreach(var letter in word)
        {
            if(node.children[letter - 'a'] == null)
            {
                return false;
            }
            node = node.children[letter - 'a'];
        }

        return node.isEnd;
    }
    
    public bool StartsWith(string prefix) {
        
        var node = root;

        foreach(var letter in prefix)
        {
            if(node.children[letter - 'a'] == null)
            {
                return false;
            }
            node = node.children[letter - 'a'];
        }
        
        return true;
    }
}
