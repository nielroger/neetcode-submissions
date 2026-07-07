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

public class WordDictionary {
    
    public Trie root;
    public WordDictionary() {
        root = new Trie();
    }
    
    public void AddWord(string word) {
        
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
        return SearchInNode(word, 0, root);
    }

    private bool SearchInNode(string word, int i, Trie node) {
        if (node == null) return false;
        if (i == word.Length) return node.isEnd;

        char letter = word[i];
        if (letter != '.') {
            return SearchInNode(word, i + 1, node.child[letter - 'a']);
        } else {
            foreach (var subNode in node.child) {
                if (subNode != null && SearchInNode(word, i + 1, subNode)) return true;
            }
        }
        return false;
    }
}