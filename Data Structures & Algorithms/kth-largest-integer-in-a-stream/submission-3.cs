public class KthLargest {

    PriorityQueue<int, int> q = new PriorityQueue<int, int>();
    int maxCount = 0;
    public KthLargest(int k, int[] nums) {
        
        maxCount = k;
        foreach(var num in nums)
        {
            q.Enqueue(num, num);
            if(q.Count > maxCount)
            {
                q.Dequeue();
            }

        }

    }
    
    public int Add(int val) {
        q.Enqueue(val, val);
        if(q.Count > maxCount)
        {
            q.Dequeue();
        }
        
        return q.Peek();
    }
}
