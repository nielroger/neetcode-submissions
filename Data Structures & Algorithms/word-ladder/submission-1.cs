public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        HashSet<string> set = new HashSet<string>(wordList);
        if (!set.Contains(endWord)) return 0;

        Queue<string> queue = new Queue<string>();
        queue.Enqueue(beginWord);

        int steps = 1;
        while (queue.Count > 0) {
            int size = queue.Count;
            for (int i = 0; i < size; i++) {
                string current = queue.Dequeue();
                if (current == endWord) return steps;

                char[] chars = current.ToCharArray();
                for (int j = 0; j < chars.Length; j++) {
                    char original = chars[j];
                    for (char c = 'a'; c <= 'z'; c++) {
                        if (c == original) continue;
                        chars[j] = c;
                        string next = new string(chars);
                        if (set.Contains(next)) {
                            queue.Enqueue(next);
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