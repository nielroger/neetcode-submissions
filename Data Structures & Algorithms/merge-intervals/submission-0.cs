public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var result = new List<int[]>();
        var curr = intervals[0];

        foreach(var interval in intervals)
        {
            if(curr[1] >= interval[0])
            {
                curr[0] = Math.Min(curr[0], interval[0]);
                curr[1] = Math.Max(curr[1], interval[1]);
            }
            else
            {
                result.Add(curr);
                curr = interval;
            }
        }
        result.Add(curr);

        return result.ToArray();
    }
}
