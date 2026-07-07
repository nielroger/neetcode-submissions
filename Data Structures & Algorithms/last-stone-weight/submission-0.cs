public class Solution {
    public int LastStoneWeight(int[] stones) {
        
        var q = new PriorityQueue<int, int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));


        foreach(var stone in stones)
        {
            q.Enqueue(stone, stone);            
        }

        while(q.Count > 1)
        {
            int x = q.Dequeue();
            int y = q.Dequeue();

            if(x == y)
            {
                continue;
            }
            else
            {
                int z = Math.Abs(x - y);
                q.Enqueue(z, z);
            }
        }

        return q.Count == 1 ? q.Peek() : 0;
    }
}