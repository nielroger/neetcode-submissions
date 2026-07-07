public class Solution {
    public int LengthOfLongestSubstring(string s) {

        var set = new HashSet<char>();
        int left = 0;
        int right = 0;
        int maxLen = 0;
        while(right < s.Length)
        {
            if(!set.Contains(s[right]))
            {
                set.Add(s[right]);
                maxLen = Math.Max(maxLen, right - left + 1);
                right++;
            }
            else
            {
                while(set.Contains(s[right]))
                {
                    set.Remove(s[left++]);
                }
                set.Add(s[right++]);
            }
        }
        return maxLen;
    }
}