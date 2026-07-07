public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        

        var q  = new PriorityQueue<int, int>();

        foreach(var num in nums)
        {
            q.Enqueue(num, num);
            if(q.Count > k)
                q.Dequeue();
        }

        return q.Peek();
    }
}
