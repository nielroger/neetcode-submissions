public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        if(nums.Length == 0) return 0;
        var set = new HashSet<int>(nums);
        int res = 1;
        foreach(var num in nums)
        {
            if(!set.Contains(num - 1))
            {
                var current = num;
                var length = 1;

                while(set.Contains(current + 1))
                {
                    current++;
                    length++;
                    res = Math.Max(length, res);
                }
            }
        }

        return res;
    }
}
