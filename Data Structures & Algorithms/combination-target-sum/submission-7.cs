public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        
        var result = new List<List<int>>();
        BackTrack(nums, 0, target, new List<int>(), result);
        return result;
    }

    public void BackTrack(int[] nums, int index, int remaining, List<int> curr, List<List<int>> result)
    {
        if(remaining == 0)
            result.Add(new List<int>(curr));
        
        for(int i = index; i < nums.Length; i++)
        {
            if(remaining - nums[i] < 0) continue;
            curr.Add(nums[i]);
            BackTrack(nums, i, remaining - nums[i], curr, result);
            curr.RemoveAt(curr.Count - 1);
        }

    }
}
