public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        
        var q = new PriorityQueue<int[], int>();

        foreach(var point in points)
        {
            int dist = point[0] * point[0] + point[1] * point[1];
            q.Enqueue(point, dist);
        }

        var result = new int[k][];

        for(int i = 0; i < k; i++)
        {
            result[i] = q.Dequeue();
        }

        return result;
    }
}
