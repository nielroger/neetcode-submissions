public class KthLargest {

    public int count = 0;
    public PriorityQueue<int, int> q = new PriorityQueue<int,int>();
    public KthLargest(int k, int[] nums) {
        
        count = k;
        foreach(var num in nums)
        {
            q.Enqueue(num, num);
            if(q.Count > count)
            {
                q.Dequeue();
            }

        }

    }
    
    public int Add(int val) {
        
        q.Enqueue(val, val);
        if(q.Count > count)
        {
            q.Dequeue();
        }

        return q.Peek();
    }
}
