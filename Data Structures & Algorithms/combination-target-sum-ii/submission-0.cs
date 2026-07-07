public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);

        var result =  new List<List<int>>();
        BackTrack(candidates, result, target, 0, new List<int>());
        return result;
    }

    public void BackTrack(int[] candidates, List<List<int>> result, int remaining, int start, List<int> current)
    {
        if(remaining == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for(int i = start; i < candidates.Length; i++)
        {
            if(candidates[i] > remaining)
                break;
            
            if(i > start && candidates[i] == candidates[i - 1]) continue;

            current.Add(candidates[i]);
            BackTrack(candidates, result, remaining - candidates[i], i + 1, current);
            current.RemoveAt(current.Count - 1);
        }
    }
}