public class KthLargest {

    PriorityQueue<int, int> queue;
    int k;
    public KthLargest(int k, int[] nums) {
         this.k = k;
         queue = new PriorityQueue<int, int>();
         foreach (int n in nums) {
             Add(n);
         }
    }
    
    public int Add(int val) {
        queue.Enqueue(val, val);
        if (queue.Count > k)
        {
            queue.Dequeue();
        }
        return queue.Peek();
    }
}