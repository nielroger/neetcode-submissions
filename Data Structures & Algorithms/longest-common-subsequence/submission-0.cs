public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        
        int m = text1.Length;
        int n = text2.Length;

        var map = new int[m + 1, n + 1];

        for(int i = 1; i <= m; i++)
        {
            for(int j = 1; j <= n; j++)
            {
                if(text1[i - 1] == text2[j - 1])
                    map[i, j] = 1 + map[i - 1, j - 1];
                else
                    map[i, j] = Math.Max(map[i - 1, j], map[i, j - 1]);
            }
        }
        return map[m, n];
    }
}