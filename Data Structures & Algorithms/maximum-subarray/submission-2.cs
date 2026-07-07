public class Solution {
    public int MaxSubArray(int[] nums) {
        

        int maxSum = int.MinValue;
        int currSum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            currSum = Math.Max(currSum + nums[i], nums[i]);
            maxSum = Math.Max(currSum, maxSum);
        }

        return maxSum;

    }
}
