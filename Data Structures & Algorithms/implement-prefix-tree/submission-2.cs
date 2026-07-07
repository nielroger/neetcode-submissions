public class PrefixTree {

    public Trie root;
    public PrefixTree() {
        root = new Trie();        
    }   
    
    public void Insert(string word) {
        
        var node = root;
        foreach(var letter in word)
        {
            if(node.child[letter - 'a'] == null)
            {
                node.child[letter - 'a'] = new Trie();
            }
            node = node.child[letter - 'a'];
        }
        node.isEnd = true;
    }
    
    public bool Search(string word) {
        
        var node = root;
        foreach(var letter in word)
        {
            if(node.child[letter - 'a'] == null)
            {
                return false;
            }
            node = node.child[letter - 'a'];
        }
        return node.isEnd;
    }
    
    public bool StartsWith(string prefix) {
        
        var node = root;
        foreach(var letter in prefix)
        {
            if(node.child[letter - 'a'] == null)
            {
                return false;
            }
            node = node.child[letter - 'a'];
        }
        return true;
    }
}

public class Trie
{
    public Trie[] child;
    public bool isEnd;

    public Trie()
    {
        child = new Trie[26];
        isEnd = false;
    }
    
}
