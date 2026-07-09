public class Solution {
    public string LongestPalindrome(string s) {
        
        int n = s.Length;
        bool[,] dp = new bool[n + 1, n + 1];

        for(int i = 0; i <= n ;i++)
            dp[i,i] = true;

        int maxLen = 1;
        int start = 0;
        for(int len = 2; len <= n; len++)
        {
            for(int i = 0; i + len - 1 < n; i++)
            {
                int j = i + len - 1;

                if(s[i] == s[j])
                {
                    if(len == 2 || dp[i + 1, j - 1])
                    {
                        dp[i,j] = true;
                        if(len > maxLen)
                        {
                            maxLen = len;
                            start = i;
                        }
                    }
                }
            }
        }

        return s.Substring(start, maxLen);
    }
}
