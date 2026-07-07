public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        
        var result = new List<List<int>>();
        Array.Sort(candidates);
        BackTrack(candidates, 0, new List<int>(), result, target);
        return result;
    }

    public void BackTrack(int[] candidates, int start, List<int> current, List<List<int>> result, int remaining)
    {
        if(remaining == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for(int i = start; i < candidates.Length; i++)
        {
            if(i > start && candidates[i] == candidates[i - 1]) continue;

            if(candidates[i] > remaining) break;

            current.Add(candidates[i]);
            BackTrack(candidates, i + 1, current, result, remaining - candidates[i]);
            current.RemoveAt(current.Count - 1);            
        }
    }
}