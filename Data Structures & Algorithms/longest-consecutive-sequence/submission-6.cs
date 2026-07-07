public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        var set = new HashSet<int>(nums);
        int maxLength = 1;

        foreach(var num in nums)
        {
            if(!set.Contains(num - 1))
            {
                int curr = num;
                int length = 1;
                while(set.Contains(curr + 1))
                {
                    curr++;
                    length++;
                    maxLength = Math.Max(maxLength, length);
                }
            }
        }

        return maxLength;
    }
}
