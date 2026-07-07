public class Solution {
    public List<List<int>> Permute(int[] nums) {
        
        var result = new List<List<int>>();
        Permute(nums, new bool[nums.Length], new List<int>(), result);
        return result;
    }

    public void Permute(int[] nums, bool[] visited, List<int> current, List<List<int>> result)
    {
        if(current.Count == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        for(int i = 0; i < nums.Length; i++)
        {
            if(!visited[i])
            {
                visited[i]= true;
                current.Add(nums[i]);
                Permute(nums, visited, current, result);
                current.RemoveAt(current.Count - 1);
                visited[i] = false;
            }

        }
    }
}
