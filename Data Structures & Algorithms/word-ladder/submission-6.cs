public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        
        var wordSet = new HashSet<string>(wordList);
        if(!wordSet.Contains(endWord)) return 0;

        var q = new Queue<string>();
        q.Enqueue(beginWord);
        int steps = 1;
        
        while(q.Count > 0)
        {
            int size = q.Count;
            for(int i = 0 ;i < size; i++)
            {
                var curr = q.Dequeue();
                if(curr == endWord) return steps;

                var currChar = curr.ToCharArray();

                for(int j = 0; j < currChar.Length; j++)
                {
                    var original = currChar[j];
                    for(char c = 'a'; c <= 'z'; c++)
                    {
                        currChar[j] = c;
                        var newWord = new string(currChar);
                        if(wordSet.Contains(newWord))
                        {
                            wordSet.Remove(newWord);
                            q.Enqueue(newWord);
                        }
                    }
                    currChar[j] = original;
                }
                

             }
             steps++;
        }

        return 0;

    }
}
