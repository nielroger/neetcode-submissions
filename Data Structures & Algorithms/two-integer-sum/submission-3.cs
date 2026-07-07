public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var set = new Dictionary<int, int>();

        for(int i =0; i < nums.Length; i++)
        {
            if(set.ContainsKey(target - nums[i]))
            {
                return new int[2]{set[target - nums[i]], i};
            }
            else
            {
                set.Add(nums[i], i);
            }
        }
        return new int[2]{-1, -1};
    }
}
