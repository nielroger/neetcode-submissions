public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        
        var set = new HashSet<string>(wordList);
        if(!set.Contains(endWord)) return 0;

        var q = new Queue<string>();

        q.Enqueue(beginWord);
        int count = 1;

        while(q.Count > 0)
        {
            int size = q.Count;
            for(int i = 0; i < size; i++)
            {                
                var current = q.Dequeue();
                if (current == endWord) return count;
                var currentCharArr = current.ToCharArray();

                for(int j = 0; j < currentCharArr.Length; j++)
                {
                    var original = currentCharArr[j];
                    for(char c = 'a'; c <= 'z'; c++)
                    {
                        currentCharArr[j] = c;
                        var newString = new string(currentCharArr);
                        if(set.Contains(newString))
                        {
                            set.Remove(newString);
                            q.Enqueue(newString);
                        }
                    }
                    currentCharArr[j] = original;
                }
            }
            count++;
        }

        return 0;
    }
}