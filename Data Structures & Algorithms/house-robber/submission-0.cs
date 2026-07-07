public class Solution {
    public int Rob(int[] nums) {
        int prev1 = 0;
        int prev2 = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            int curr = Math.Max(prev2 + nums[i], prev1);
            prev2 = prev1;
            prev1 = curr;
        }

        return prev1;
    }
}
