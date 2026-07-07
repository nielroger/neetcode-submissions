public class Solution {
    public string MinWindow(string s, string t) {
        
        var need =  new Dictionary<char, int>();
        foreach(var letter in t)
        {
            if(!need.ContainsKey(letter))
            {
                need.Add(letter, 0);
            }
            need[letter]++;
        }

        var have = new Dictionary<char, int>();
        int left = 0;
        int formed = 0;
        int required = need.Count;
        int bestStart = 0;
        int bestLen = int.MaxValue;

        for(int right = 0; right < s.Length; right++)
        {
            char  c= s[right];
            have[c] = have.GetValueOrDefault(c, 0) + 1;

            if(need.ContainsKey(c) && need[c] == have[c])
            {
                formed++;
            }

            while(formed == required)
            {
                if(right - left + 1 < bestLen)
                {
                    bestLen = right - left + 1;
                    bestStart = left;
                }

                char leftChar = s[left];
                have[leftChar]--;

                if(need.ContainsKey(leftChar) && have[leftChar] < need[leftChar])
                {
                    formed--;
                }

                left++;

            }
        }
        
        return bestLen == int.MaxValue ? "" : s.Substring(bestStart, bestLen);
        
    }
}
