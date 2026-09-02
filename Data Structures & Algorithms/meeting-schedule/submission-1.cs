public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        if (intervals.Count == 0) return true;
        intervals.Sort((a, b) => a.start.CompareTo(b.start));
        var curr = intervals[0];
        for(int i = 1; i < intervals.Count; i++)
        {
            if(curr.end > intervals[i].start) return false;
            else 
                curr = intervals[i];            
        }

        return true;
    }
}