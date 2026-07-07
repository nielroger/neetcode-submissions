public class Solution {
    public List<List<string>> Partition(string s) {
        List<List<string>> result = new List<List<string>>();
        Backtrack(s, 0, new List<string>(), result);
        return result;
    }

    private void Backtrack(string s, int start, List<string> current, List<List<string>> result) {
        if (start == s.Length) {
            result.Add(new List<string>(current));
            return;
        }

        for (int end = start; end < s.Length; end++) {
            if (IsPalindrome(s, start, end)) {
                current.Add(s.Substring(start, end - start + 1));
                Backtrack(s, end + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }

    private bool IsPalindrome(string s, int low, int high) {
        while (low < high) {
            if (s[low++] != s[high--]) return false;
        }
        return true;
    }
}