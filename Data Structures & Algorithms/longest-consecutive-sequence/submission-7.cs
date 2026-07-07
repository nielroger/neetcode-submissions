public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        int maxSum = 0;
        var set = new HashSet<int>(nums);
        for(int i = 0; i < nums.Length; i++)
        {
            if(!set.Contains(nums[i] - 1))
            {
                int currentNum = nums[i];
                int currentStreak = 1;
                
                while(set.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak++;
                }
                maxSum = Math.Max(maxSum, currentStreak);
            }
        }

        return maxSum;
    }
}