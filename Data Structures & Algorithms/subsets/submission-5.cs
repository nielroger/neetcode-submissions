public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        
        var result = new List<List<int>>();
        BackTrack(nums, 0, result, new List<int>());
        return result;
    }

    public void BackTrack(int[] nums, int index, List<List<int>> result, List<int> current)
    {
        result.Add(new List<int>(current));

        for(int i = index; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            BackTrack(nums, i + 1, result, current);
            current.RemoveAt(current.Count - 1);
        }
    }
}