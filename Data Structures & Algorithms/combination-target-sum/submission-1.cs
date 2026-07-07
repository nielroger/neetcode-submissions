public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        
        var result =  new List<List<int>>();
        BackTrack(nums, 0, new List<int>(), target, result);
        return result;
    }

    public void BackTrack(int[] nums, int index, List<int> current, int target, List<List<int>> result)
    {
        if(target < 0)
        {
            return;
        }
        if(target == 0)
        {
            result.Add(new List<int>(current));
        }

        for(int i = index; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            BackTrack(nums, i, current, target - nums[i], result);
            current.RemoveAt(current.Count - 1);
        }


    }
}
