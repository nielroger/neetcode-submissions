public class Solution {
    public int LastStoneWeight(int[] stones) {
        
        var q = new PriorityQueue<int, int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));

        foreach(var stone in stones)
        {
            q.Enqueue(stone, stone);
        }

        while(q.Count > 0)
        {
            var temp = q.Dequeue();
            if(q.Count == 0)
            {
                return temp;
            }
            else if(q.Peek() == temp)
            {
                q.Dequeue();
            }
            else
            {
                var last = q.Dequeue();
                q.Enqueue(temp - last, temp - last);
            }
        }

        return 0;
    }
}