public class Solution {
    public int[] CountBits(int n) {
        int[] ans = new int[n + 1];

        ans[0] = 0;

        for(int i = 1; i <=n ; i++)
        {
            int count = ans[i >> 1];
            if((i & 1) == 1)
            {
                count++;
            }
            ans[i] = count;
        }

        return ans;
    }
}
