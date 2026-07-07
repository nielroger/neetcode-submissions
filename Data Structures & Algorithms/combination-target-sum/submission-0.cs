public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var result = new List<List<int>>();
        BackTrack(nums, target, 0, result, new List<int>());
        return result;
    }

    public void BackTrack(int[] nums, int remaining, int start, List<List<int>> result, List<int> current)
    {
        if(remaining == 0)
        {
            result.Add(new List<int>(current));
            return;        
        }

        for(int i = start; i < nums.Length; i++)
        {
            if(nums[i] > remaining)
                continue;
            
            current.Add(nums[i]);
            BackTrack(nums, remaining - nums[i], i, result, current);
            current.RemoveAt(current.Count - 1);
        }

    }
}
