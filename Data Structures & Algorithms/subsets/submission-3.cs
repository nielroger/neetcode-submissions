public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        
        var result =  new List<List<int>>();
        BackTrack(nums, result, 0, new List<int>());
        return result;
    }

    public void BackTrack(int[] nums, List<List<int>> result, int start, List<int> current)
    {
        result.Add(new List<int>(current));

        for(int i = start; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            BackTrack(nums, result, i + 1, current);
            current.RemoveAt(current.Count - 1);
        }        
    }
}
