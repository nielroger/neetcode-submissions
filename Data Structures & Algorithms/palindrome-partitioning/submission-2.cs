public class Solution {
    public List<List<string>> Partition(string s) {
        var result = new List<List<string>>();
        BackTrack(s, 0, result, new List<string>());
        return result;
    }

    public void BackTrack(string s, int start, List<List<string>> result, List<string> current)
    {
        if(start == s.Length)
        {
            result.Add(new List<string>(current));
            return;            
        }

        for(int end = start; end < s.Length; end++)
        {
            if(IsPalindrome(s, start, end))
            {
                current.Add(s.Substring(start, end - start + 1));
                BackTrack(s, end + 1, result, current);
                current.RemoveAt(current.Count - 1);
            }
        }
    }

    public bool IsPalindrome(string s, int left, int right)
    {
        while(left < right)
        {
            if(s[left++] != s[right--]) return false;
        }
        return true;
    }
}