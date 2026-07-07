public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        var set = new HashSet<int>(nums);
        var maxLen = 1;
        foreach(var num in nums)
        {   
            if(!set.Contains(num - 1))
            {
                var current = num;
                int length = 1;
                while(set.Contains(current + 1))
                {
                    length++;
                    maxLen = Math.Max(maxLen, length);
                    current++;
                }
            }
        }

        return maxLen;
    }
}
