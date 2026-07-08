public class Solution {
    public List<List<int>> Permute(int[] nums) {
        
        var result = new List<List<int>>();
        BackTrack(nums, new bool[nums.Length], new List<int>(), result);
        return result;
    }

    public void BackTrack(int[] nums, bool[] visited,  List<int> curr, List<List<int>> result)
    {
        if(curr.Count == nums.Length) 
            result.Add(new List<int>(curr));
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(!visited[i])
            {
                visited[i] = true;
                curr.Add(nums[i]);
                BackTrack(nums, visited, curr, result);
                curr.RemoveAt(curr.Count - 1);
                visited[i] = false;
            }
        }
    }
}
