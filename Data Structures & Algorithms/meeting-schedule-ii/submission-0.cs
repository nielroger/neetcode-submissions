public class Solution
{
    public int MinMeetingRooms(List<Interval> intervals)
    {
        if (intervals == null || intervals.Count == 0)
            return 0;

        // Process meetings in start-time order.
        intervals.Sort((a, b) => a.start.CompareTo(b.start));

        // Stores the end time for each allocated room.
        var heap = new PriorityQueue<int, int>();

        foreach (Interval meeting in intervals)
        {
            // Reuse the room that becomes available first.
            if (heap.Count > 0 && heap.Peek() <= meeting.start)
            {
                heap.Dequeue();
            }

            // Assign the current meeting to a room.
            heap.Enqueue(meeting.end, meeting.end);
        }

        return heap.Count;
    }
}