public class Solution {
    public int LastStoneWeight(int[] stones) {
        

        var q = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach(var stone in stones)
        {
            q.Enqueue(stone, stone);            
        }

        while(q.Count > 0)
        {
            var temp = q.Dequeue();
            if(q.Count == 0) return temp;
            var temp2 = q.Dequeue();
            if(temp != temp2)
            {
                int diff = Math.Abs(temp - temp2);
                q.Enqueue(diff, diff);
            }
        }

        return 0;
    }
}