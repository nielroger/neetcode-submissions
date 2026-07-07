public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        
        var result =  new List<List<int>>();
        BackTrack(nums, 0, new List<int>(), result, target);
        return result;
    }

    public void BackTrack(int[] nums, int start,List<int> current, List<List<int>> result, int remaining)
    {
        if(remaining == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for(int i = start; i < nums.Length; i++)
        {
            if(nums[i] > remaining) continue;
            current.Add(nums[i]);
            BackTrack(nums, i, current, result, remaining - nums[i]);
            current.RemoveAt(current.Count - 1);
        }
    }
}
