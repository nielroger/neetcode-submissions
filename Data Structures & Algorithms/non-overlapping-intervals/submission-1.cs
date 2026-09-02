public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        
        Array.Sort(intervals, (a,b) => a[1].CompareTo(b[1]));

        int count = 0;
        var curr = intervals[0];        

        for(int i = 1; i < intervals.Length; i++)
        {
            if(intervals[i][0] < curr[1])
            {
                count++;
            }
            else
            {
                curr = intervals[i];
            }
        }

        return count;
    }
}
