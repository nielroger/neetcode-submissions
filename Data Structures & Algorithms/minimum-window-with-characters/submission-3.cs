public class Solution {
    public string MinWindow(string s, string t) {
        

        var need = new int[128];

        foreach(var letter in t)
        {
            need[letter]++;
        }

        int required = t.Length;

        int left = 0;
        int len = int.MaxValue;
        int start = 0;

        for(int right = 0; right < s.Length; right++)
        {
            if(need[s[right]] > 0) required--;
            need[s[right]]--;

            while(required == 0)
            {
                if (right - left + 1 < len) {
                    len = right - left + 1;
                    start = left;
                }

                need[s[left]]++;
                if(need[s[left]] > 0) required++; 
                left++;
            }
        }

        return len == int.MaxValue ? "" : s.Substring(start, len);

    }
}
