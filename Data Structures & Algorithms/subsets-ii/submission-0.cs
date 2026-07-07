public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums); // Essential: groups duplicates together
        var result = new List<List<int>>();
        Backtrack(nums, 0, new List<int>(), result);
        return result;
    }

    private void Backtrack(int[] nums, int start, List<int> current, List<List<int>> result)
    {
        // Always snapshot — every node in the tree is a valid subset
        result.Add(new List<int>(current));

        for (int i = start; i < nums.Length; i++)
        {
            // Skip duplicates at the same recursion level
            if (i > start && nums[i] == nums[i - 1]) continue;

            current.Add(nums[i]);
            Backtrack(nums, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
