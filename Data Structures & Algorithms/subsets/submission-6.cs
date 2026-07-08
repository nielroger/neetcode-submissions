public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();

        BackTrack(nums, 0, new List<int>(), result);
        return result;
    }

    public void BackTrack(int[] nums, int index, List<int> curr, List<List<int>> result)
    {

        result.Add(new List<int>(curr));

        for(int i = index; i < nums.Length; i++)
        {
            curr.Add(nums[i]);
            BackTrack(nums, i + 1, curr, result);
            curr.RemoveAt(curr.Count - 1);
        }
    }

}
