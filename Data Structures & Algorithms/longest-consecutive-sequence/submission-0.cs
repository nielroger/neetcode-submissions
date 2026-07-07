public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        var set = new HashSet<int>(nums);

        var res = 1;
        foreach(var num in set)
        {
            if(!set.Contains(num - 1))
            {
                var currentNum = num;
                var currentStreak = 1;

                while (set.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak += 1;
                }

                res = Math.Max(res, currentStreak);
            }
        }

        return res;
    }
}