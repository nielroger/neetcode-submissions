public class WordDictionary {

    public Trie root;
    public WordDictionary() {
        root = new Trie();
    }
    
    public void AddWord(string word) {
        
        var node = root;
        foreach(var letter in word)
        {            int index = letter - 'a';

            if(node.child[index] == null)
            {                node.child[index] = new Trie();
            }
            node = node.child[index];
        }
        node.isEnd = true;

    }
    
    public bool Search(string word) {
        
        var node = root;
        return Search(word, 0, node);
    }

    public bool Search(string word, int index, Trie node)
    {
        if (node == null) return false;
        if (index == word.Length) return node.isEnd;

        if(word[index] == '.')
        {            foreach(var child in node.child)
            {                if(Search(word, index + 1, child)) return true;
            }
            return false;
        }
        else
        {            if(node.child[word[index] - 'a'] == null) return false;
            else
            {                node = node.child[word[index] - 'a'];
                return Search(word, index + 1, node);
            }
        }

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