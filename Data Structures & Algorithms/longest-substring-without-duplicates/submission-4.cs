public class Solution {
    public int LengthOfLongestSubstring(string s) {

        
        int[]map = new int[128];
        int maxLength = 0;
        int left = 0;
        int right = 0;
        while(right < s.Length)
        {
            int index = (int)s[right];
            if(map[index]== 0)
            {
                map[index]++;                
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
            else
            {
                while(map[index] > 0)
                {
                    map[(int)s[left++]]--;
                }
            }
        }

        return maxLength;
    }
}
