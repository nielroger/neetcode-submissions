public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        
        Array.Sort(nums);
        var result = new List<List<int>>();
        BackTrack(nums, 0, new List<int>(), result);
        return result;
    }

    public void BackTrack(int[] nums, int index, List<int> current, List<List<int>> result)
    {
        result.Add(new List<int>(current));

        for(int i = index; i < nums.Length; i++)
        {
            if(i > index && nums[i] == nums[i - 1]) continue;
            current.Add(nums[i]);
            BackTrack(nums, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}