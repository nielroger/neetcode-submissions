public class Solution {
    public int LengthOfLongestSubstring(string s) {

        int left = 0;
        int right = 0;
        int maxLen = 0;
        var map = new HashSet<char>();
        while(right < s.Length)
        {
            if(!map.Contains(s[right]))
            {
                map.Add(s[right]);
                maxLen = Math.Max(maxLen, right - left + 1);
                right++;
            }
            else
            {
                while(map.Contains(s[right])){
                    map.Remove(s[left++]);
                }
                map.Add(s[right++]);

            }
            
            
        }

        return maxLen;
    }
}
