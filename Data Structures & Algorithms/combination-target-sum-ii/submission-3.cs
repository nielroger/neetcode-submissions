public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<List<int>>();

        Array.Sort(candidates);

        BackTrack(candidates, 0, target, new List<int>(), result);
        return result;
    }

    public void BackTrack(int[] arr, int index, int remaining, List<int> current, List<List<int>> result)
    {
        if(remaining == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for(int i = index; i < arr.Length; i++)
        {
            if(i > index && arr[i] == arr[i - 1]) continue;
            if(arr[i] > remaining) break;

            current.Add(arr[i]);
            BackTrack(arr, i + 1, remaining - arr[i], current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}