public class WordDictionary {

    public Trie root;
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

    public WordDictionary() {
        root = new Trie();
    }
    
    public void AddWord(string word) {
        
        var node = root;
        foreach(var letter in word)
        {            int index = letter - 'a';
            if(node.children[index] == null)
            {
                node.children[index] = new Trie();
            }
            node = node.children[index];
        }
        node.isEnd = true;
    }
    
    public bool Search(string word) {
        
        var node =  root;
        return Search(node, 0, word);
    }

    public bool Search(Trie node, int index, string word)
    {
        if (node == null) return false;
        if(index == word.Length)
        {
            return node.isEnd;
        }
        if(word[index] == '.')
        {
            foreach(var child in node.children)
            {
                if(child != null && Search(child, index + 1, word))
                    return true;
            }
            return false;
        }
        else
        {
            int charIdx = word[index] - 'a';
            if(node.children[charIdx] == null)
            {
                return false;
            }
            else
            {
                return Search(node.children[charIdx], index + 1, word);
            }
        }
    }
}