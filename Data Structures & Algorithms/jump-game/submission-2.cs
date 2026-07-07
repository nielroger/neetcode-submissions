public class Solution {
    public bool CanJump(int[] nums) {
        
        int end = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(i > end)
            {
                return false;
            }
            end = Math.Max(end, nums[i] + i);
        }

        return true;
    }
}
