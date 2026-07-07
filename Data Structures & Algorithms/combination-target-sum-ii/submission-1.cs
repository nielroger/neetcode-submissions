public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);

        int[] map = new int[candidates.Length];
        var result = new List<List<int>>();
        BackTrack(candidates, map, 0, target, new List<int>(), result);
        return result;
    }

    public void BackTrack(int[] candidates,int[] map,  int start,int remaining, List<int> current, List<List<int>> result)
    { 
        if(remaining == 0)
        {
            result.Add(new List<int>(current));
            return;
        }


        for(int i = start; i < candidates.Length; i++)
        {
            if(i > start && candidates[i] == candidates[i-1]) continue;
            if(candidates[i] > remaining) break;

            current.Add(candidates[i]);
            BackTrack(candidates, map, i + 1, remaining - candidates[i], current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}