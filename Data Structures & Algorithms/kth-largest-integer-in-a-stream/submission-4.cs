public class KthLargest {

    PriorityQueue<int, int> q;
    int max;
    public KthLargest(int k, int[] nums) {
        
        max = k;
        q = new PriorityQueue<int, int>();
        foreach(var num in nums)
        {
            q.Enqueue(num, num);
            if(q.Count > max)
            {
                q.Dequeue();
            }
        }

    }
    
    public int Add(int val) {
        

        q.Enqueue(val, val);
        if(q.Count > max)
        {
            q.Dequeue();
        }

        return q.Peek();
    }
}
