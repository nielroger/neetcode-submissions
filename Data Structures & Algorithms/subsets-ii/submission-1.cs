public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        
        var result = new List<List<int>>();
        Array.Sort(nums);
        BackTrack(nums, 0, new List<int>(), result);
        return result;
    }

    public void BackTrack(int[] nums, int start, List<int> current, List<List<int>> result)
    {
        result.Add(new List<int>(current));

        for(int i = start; i < nums.Length; i++)
        {
            if(i > start && nums[i] == nums[i - 1]) continue;

            current.Add(nums[i]);
            BackTrack(nums, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}