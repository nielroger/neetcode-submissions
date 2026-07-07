public class Solution {
    public List<List<int>> Permute(int[] nums) {
        
        var result = new List<List<int>>();
        var visited = new bool[nums.Length];
        BackTrack(nums, visited, new List<int>(), result);
        return result;
        
    }

    public void BackTrack(int[] nums, bool[] visited, List<int> current, List<List<int>> result)    
    {
        if(current.Count == nums.Length) result.Add( new List<int>(current));

        for(int i = 0; i < nums.Length; i++)
        {
            if(!visited[i])
            {
                visited[i] = true;
                current.Add(nums[i]);
                BackTrack(nums, visited, current, result);
                current.RemoveAt(current.Count - 1);
                visited[i] = false;
            }            
        }
    }
}
