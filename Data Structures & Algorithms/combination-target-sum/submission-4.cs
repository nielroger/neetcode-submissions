public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        
        var result = new List<List<int>>();
        BackTrack(nums, 0, target, new List<int>(), result);
        return result;
    }

    public void BackTrack(int[] nums, int start, int remaining, List<int> current, List<List<int>> result)
    {
        if(remaining == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for(int i = start; i < nums.Length; i++)
        {
            if(nums[i] > remaining)
            {
                continue;
            }
            current.Add(nums[i]);
            BackTrack(nums, i, remaining - nums[i], current, result);
            current.RemoveAt(current.Count - 1);
        }
    }    
}
