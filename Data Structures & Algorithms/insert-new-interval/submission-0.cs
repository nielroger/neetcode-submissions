public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var result = new List<int[]>();

        for(int i = 0; i < intervals.Length; i++)
        {

            if(intervals[i][1] < newInterval[0])
            {
                result.Add(intervals[i]);
            }
            else if(newInterval[1] < intervals[i][0])
            {
                result.Add(newInterval);
                for (int j = i; j < intervals.Length; j++) result.Add(intervals[j]);
                return result.ToArray();
            }
            else
            {
                newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
                newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
            }
        }

        result.Add(newInterval);
        return result.ToArray();
    }
}