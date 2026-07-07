public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        
        var set = new HashSet<string>(wordList);
        if(!set.Contains(endWord))
            return 0;

        var q = new Queue<string>();
        q.Enqueue(beginWord);
        int steps = 1;
        while(q.Count > 0)
        {
            int size = q.Count;
            for(int i =0; i < size; i++)
            {
                string current = q.Dequeue();
                if(current == endWord) return steps;

                var chars = current.ToCharArray();
                for(int j = 0; j < chars.Length; j++)
                {
                    char original = chars[j];
                    for(char c = 'a'; c <= 'z'; c++)
                    {
                        if(c == original) continue;

                        chars[j] = c;

                        var next = new string(chars);
                        if(set.Contains(next))
                        {
                            q.Enqueue(next);
                            set.Remove(next);
                        }
                    }
                    chars[j] = original;
                }
            }

            steps++;
        }

        return 0;
    }
}