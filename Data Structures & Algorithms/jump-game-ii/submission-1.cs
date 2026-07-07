public class Solution {
    public int Jump(int[] nums) {
        

        int jumps = 0;
        int furthest = 0;
        int currentEnd = 0;
        for(int i = 0; i < nums.Length -1; i++)
        {
            
            furthest = Math.Max(furthest, i + nums[i]);
            if(i == currentEnd)
            {
                jumps++;
                currentEnd = furthest;
            }
        }

        return jumps;
    }
}
