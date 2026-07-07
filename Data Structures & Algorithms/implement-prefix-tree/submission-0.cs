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
public class PrefixTree {

    Trie root;
    public PrefixTree() {
        root = new Trie();
    }
    
    public void Insert(string word) {
        
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
    }
    
    public bool Search(string word) {
        var node = root;

        foreach(var letter in word)
        {
            int index = letter - 'a';
            if(node.child[index] == null)
            {
                return false;
            }
            node = node.child[index];
        }

        return node.isEnd;
    }
    
    public bool StartsWith(string prefix) {
        
        var node = root;

        foreach(var letter in prefix)
        {
            int index = letter - 'a';
            if(node.child[index] == null)
            {
                return false;
            }
            node = node.child[index];
        }

        return true;
    }
}