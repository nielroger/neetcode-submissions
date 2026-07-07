public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var result = new List<List<int>>();
        var visited = new bool[nums.Length];
        BackTrack(nums, new List<int>(), result, visited);
        return result;
    }

    public void BackTrack(int[] nums, List<int> current, List<List<int>> result, bool[] visited)
    {
        if(current.Count == nums.Length)
        {
            result.Add(new List<int>(current));
            return;            
        }

        for(int i = 0; i < nums.Length; i++)
        {
            if(visited[i]) continue;

            visited[i] = true;
            current.Add(nums[i]);
            BackTrack(nums, current, result, visited);
            visited[i] = false;
            current.RemoveAt(current.Count - 1);
        }
    }
}