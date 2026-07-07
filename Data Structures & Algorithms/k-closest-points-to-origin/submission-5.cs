public class Solution {
    public int[][] KClosest(int[][] points, int k) {
         
        var queue = new PriorityQueue<int[], int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach(var point in points)
        {
            var dist = point[0] * point[0] + point[1] * point[1];

            queue.Enqueue(point, dist);
            if(queue.Count > k)
            {
                queue.Dequeue();
            }
        }

        var res = new int[k][];
        for(int i = 0; i < k; i++)
        {
            res[i] = queue.Dequeue();
        }

        return res;
    }
}