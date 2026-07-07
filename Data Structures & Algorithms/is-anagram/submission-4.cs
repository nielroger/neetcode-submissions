public class Solution {
    public bool IsAnagram(string s, string t) {
        var smap = new int[26];
        if(s.Length != t.Length) return false;
        for(int i =0; i < s.Length; i++)
        {
            smap[s[i] - 'a']++;
            smap[t[i] - 'a']--;
        }

        for(int i = 0; i < 26; i++)
        {
            if(smap[i] != 0) return false;
        }

        return true;
    }
}
