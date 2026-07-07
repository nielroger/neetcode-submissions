public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        Array.Sort(nums);
        var result =  new List<List<int>>();
        BackTrack(nums, target,0, new List<int>(), result);
        return result;
    }

    public void BackTrack(int[] nums, int target, int start, List<int>current, List<List<int>> result)
    {

        if(target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for(int i = start; i < nums.Length; i++)
        {
            if(nums[i] > target) break;
            current.Add(nums[i]);
            BackTrack(nums, target - nums[i], i, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}