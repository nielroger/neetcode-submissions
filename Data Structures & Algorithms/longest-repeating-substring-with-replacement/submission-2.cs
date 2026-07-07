public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int[] freq = new int[26];
        int left = 0;
        int maxCount = 0;
        int maxLen = 0;

        for(int right = 0; right < s.Length; right++)
        {
            var letter = s[right] - 'A';
            freq[letter]++;

            maxCount = Math.Max(maxCount, freq[letter]);
            int windowSize = right - left + 1;
            int replacements = windowSize - maxCount;

            if(replacements > k)
            {
                freq[s[left] - 'A']--;
                left++;
            }

            maxLen = Math.Max(maxLen, right - left + 1);
        }        
        return maxLen;
    }

    
}
