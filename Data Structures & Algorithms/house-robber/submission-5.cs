public class Solution {
    public int Rob(int[] nums) {
        int prev1 = 0;
        int prev2 = 0;
        int max = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            int curr = Math.Max(prev1, prev2 + nums[i]);
            prev2 = prev1;
            prev1 = curr;
        }

        return prev1;
    }
}
