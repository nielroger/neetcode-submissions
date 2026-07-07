public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        if(s1.Length == 0) return false;
        if(s1.Length > s2.Length) return false;

        int[] count1 = new int[26];
        int[] count2 = new int[26];

        for(int i = 0; i < s1.Length; i++)
        {
            count1[s1[i] - 'a']++;
        }

    
        for(int right = 0; right < s2.Length; right++)
        {
            count2[s2[right] - 'a']++;

            if(right >= s1.Length) count2[s2[right - s1.Length] - 'a']--;
            if(Enumerable.SequenceEqual(count1, count2)) return true;
        }

        return false;
    }
}