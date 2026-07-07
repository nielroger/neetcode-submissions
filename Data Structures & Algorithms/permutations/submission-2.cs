public class Solution {
    public List<List<int>> Permute(int[] nums) {
        
        var result = new List<List<int>>();

        BackTrack(nums, result, new bool[nums.Length], new List<int>());
        return result;
    }

    public void BackTrack(int[] nums, List<List<int>> result, bool[] used, List<int> current)
    {
        if(current.Count == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        for(int i = 0; i < nums.Length; i++)
        {
            if(!used[i])
            {
                used[i] = true;
                current.Add(nums[i]);
                BackTrack(nums, result, used, current);
                used[i] = false;
                current.RemoveAt(current.Count- 1);
            }
        }
    }
}
