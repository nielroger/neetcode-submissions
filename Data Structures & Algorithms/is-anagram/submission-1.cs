public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)   
            return false;
        var smap = new int[26];        

        for(int i =0; i < s.Length; i++)
        {
            smap[s[i] - 'a']++;
            smap[t[i] - 'a']--;
        }

        for(int i =0; i < smap.Length; i++)
        {
            if(smap[i] != 0)
            {
                return false;
            }
        }

        return true;


    }
}
