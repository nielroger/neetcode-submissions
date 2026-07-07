public class Solution {
    public bool CanJump(int[] nums) {
        
        int maxFar = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(i > maxFar) return false;
            maxFar = Math.Max(i + nums[i], maxFar);
            
        }

        return true;
    }
}
